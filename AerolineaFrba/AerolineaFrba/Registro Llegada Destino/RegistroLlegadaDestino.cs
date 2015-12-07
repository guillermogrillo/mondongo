using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Registro_Llegada_Destino
{
    public partial class RegistroLlegadaDestino : Form
    {

        Controller.RutaController rutaController = null;
        Controller.ViajeController viajeController = null;
        Controller.TipoServicioController tipoServicioController = null;
        Controller.MillasController millasController = null;
        Controller.CompraController compraController = null;
        public Model.CiudadModel ciudadOrigen = null;
        public Model.CiudadModel ciudadDestino = null;
        public List<Model.ViajeRegistroLlegadaModel> vuelosEncontrados = null;
        Model.ViajeRegistroLlegadaModel vueloSeleccionado = null;
        Model.TipoServicioModel tipoServicioSeleccionado = null;
        DateTime fechaSistema = Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings.Get("fechaSistema"));

        public RegistroLlegadaDestino()
        {
            InitializeComponent();
            rutaController = new Controller.RutaController();
            viajeController = new Controller.ViajeController();
            tipoServicioController = new Controller.TipoServicioController();
            millasController = new Controller.MillasController();
            compraController = new Controller.CompraController();
            dpFechaSalida.Value = fechaSistema;
            dpFechaLlegada.Value = fechaSistema;
        }

        public Model.CiudadModel setCiudadOrigen()
        {
            return ciudadOrigen;
        }

        public void setCiudadOrigen(Model.CiudadModel ciudadModel)
        {
            ciudadOrigen = ciudadModel;
            tbCiudadOrigen.Text = ciudadOrigen.nombre;
        }

        public Model.CiudadModel getCiudadDestino()
        {
            return ciudadDestino;
        }

        public void setCiudadDestino(Model.CiudadModel ciudadModel)
        {
            ciudadDestino = ciudadModel;
            tbCiudadDestino.Text = ciudadDestino.nombre;
        }

        private void btnBuscarCiudadDesde_Click(object sender, EventArgs e)
        {
            Registro_Llegada_Destino.BuscadorCiudades busquedaCiudad = new Registro_Llegada_Destino.BuscadorCiudades(this, 0);
            this.Hide();
            busquedaCiudad.Show();
        }

        private void btnBuscarCiudadHasta_Click(object sender, EventArgs e)
        {
            Registro_Llegada_Destino.BuscadorCiudades busquedaCiudad = new Registro_Llegada_Destino.BuscadorCiudades(this, 1);
            this.Hide();
            busquedaCiudad.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tipoServicioSeleccionado = cbTipoServicio.SelectedItem as Model.TipoServicioModel;
            Model.RutaModel ruta = rutaController.buscarRuta(ciudadOrigen.ciudadId, ciudadDestino.ciudadId, tipoServicioSeleccionado.id);
            if (ruta != null)
            {
                vuelosEncontrados = viajeController.buscarViajes(ruta.idRuta, tbMatricula.Text, dpFechaSalida.Value);
                if (vuelosEncontrados.Count > 0)
                {
                    gbViajes.Enabled = true;
                    dgvViajes.DataSource = vuelosEncontrados;                    
                    dgvViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    dgvViajes.Columns[0].HeaderText = "Id. de Viaje";
                    dgvViajes.Columns[0].ReadOnly = true;
                    dgvViajes.Columns[0].Width = 75;
                   
                    dgvViajes.Columns[1].HeaderText = "Fecha Salida";
                    dgvViajes.Columns[1].ReadOnly = true;
                    dgvViajes.Columns[1].Width = 135;

                    dgvViajes.Columns[2].HeaderText = "Fecha Llegada Estimada";
                    dgvViajes.Columns[2].ReadOnly = true;
                    dgvViajes.Columns[2].Width = 135;

                    dgvViajes.Columns[3].Visible = false;

                }
                else
                {
                    MessageBox.Show("No existe ningun vuelo para los parámetros ingresados.", "Búsqueda de viajes", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No existe ningun vuelo entre las ciudades pedidas.", "Búsqueda de viajes", MessageBoxButtons.OK);
            }
        }

        private void RegistroLlegadaDestino_Load(object sender, EventArgs e)
        {
            gbViajes.Enabled = false;
            dpFechaLlegada.Enabled = false;
            btnRegistrar.Enabled = false;
            dpFechaSalida.Format = DateTimePickerFormat.Custom;
            dpFechaSalida.CustomFormat = "dd'/'MM'/'yyyy";
            
            cbTipoServicio.DataSource = tipoServicioController.buscarTiposServicio();
            cbTipoServicio.DisplayMember = "tipoServicio";
            cbTipoServicio.SelectedIndex = 0;
        }

        private void dgvViajes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            vueloSeleccionado = (Model.ViajeRegistroLlegadaModel)dgvViajes.CurrentRow.DataBoundItem;            
            btnRegistrar.Enabled = true;
            dpFechaLlegada.Enabled = true;
            dpFechaLlegada.Value = vueloSeleccionado.fechaLlegadaEstimada;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            DateTime fechaLlegada = fechaSistema.Date.Add(dpFechaLlegada.Value.TimeOfDay);
          
            if (fechaLlegada < vueloSeleccionado.fechaSalida)
            {
                MessageBox.Show("La fecha y hora de llegada no puede ser previa a la de salida");
            }
            else
            {
                if (dpFechaLlegada.Value>fechaSistema)
                {
                    MessageBox.Show("La fecha de llegada no puede ser posterior a la fecha de sistema");
                }
                else
                {
                    var fechaHoraLlegadaFormateada = fechaLlegada.ToString("dd'/'MM'/'yyyy HH':'mm':'ss");
                    vueloSeleccionado.fechaLlegada = Convert.ToDateTime(fechaHoraLlegadaFormateada);
                    this.Enabled = false;
                    Cursor.Current = Cursors.WaitCursor;
                    Boolean modificado = viajeController.actualizarViaje(vueloSeleccionado);

                    List<Model.VentaModel> ventasDelViaje = compraController.buscarVentas(vueloSeleccionado.viajeId);

                    foreach (Model.VentaModel venta in ventasDelViaje)
                    {

                        List<Model.PasajeModel> pasajesDeLaVenta = compraController.buscarPasajes(venta.ventaPnr);
                        Model.HistorialMillasModel historialMillas = null;
                        double millasAsignadas = 0;
                        foreach (Model.PasajeModel pasaje in pasajesDeLaVenta)
                        {
                            millasAsignadas = pasaje.pasajeMonto * 0.1;
                            historialMillas = new Model.HistorialMillasModel(pasaje.pasajeCliente, millasAsignadas, fechaSistema, Model.TipoOperacion.ACREDITACION, "ACREDITACIÓN DE MILLAS POR PASAJE COMPRADO");
                            millasController.registrarMillas(historialMillas);
                        }


                        Model.PaqueteModel paqueteDeLaVenta = compraController.buscarPaquetes(venta.ventaPnr);
                        if (paqueteDeLaVenta != null)
                        {
                            millasAsignadas = paqueteDeLaVenta.paqueteMonto * 0.1;
                            historialMillas = new Model.HistorialMillasModel(venta.ventaClientePagador, millasAsignadas, fechaSistema, Model.TipoOperacion.ACREDITACION, "ACREDITACIÓN DE MILLAS POR PAQUETE COMPRADO");
                            millasController.registrarMillas(historialMillas);
                        }

                    }

                    MessageBox.Show("Se registró correctamente la llegada a destino del vuelo.");
                    Cursor.Current = Cursors.Default;
                    this.Enabled = true;

                    this.Close();
                    new AerolineasFRBA().Show();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new AerolineasFRBA().Show();
        }
    }
}
