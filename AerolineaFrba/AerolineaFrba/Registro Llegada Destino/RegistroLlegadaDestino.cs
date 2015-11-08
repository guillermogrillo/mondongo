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
        public Model.CiudadModel ciudadOrigen = null;
        public Model.CiudadModel ciudadDestino = null;
        public List<Model.ViajeModel> vuelosEncontrados = null;
        Model.ViajeModel vueloSeleccionado = null;

        public RegistroLlegadaDestino()
        {
            InitializeComponent();
            rutaController = new Controller.RutaController();
            viajeController = new Controller.ViajeController();
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
            Model.RutaModel ruta = rutaController.buscarRuta(ciudadOrigen.ciudadId, ciudadDestino.ciudadId);
            if (ruta != null)
            {
                vuelosEncontrados = viajeController.buscarViajes(ruta.idRuta, tbMatricula.Text, dpFechaSalida.Value);
                if (vuelosEncontrados.Count > 0)
                {
                    gbViajes.Enabled = true;
                    dgvViajes.DataSource = vuelosEncontrados;                    
                    dgvViajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvViajes.Columns[0].Visible = false;
                    dgvViajes.Columns[3].Visible = false;
                    dgvViajes.Columns[4].Visible = false;
                    dgvViajes.Columns[7].Visible = false;
                    dgvViajes.Columns[8].Visible = false;                    
                    dgvViajes.Columns[10].Visible = false;
                    dgvViajes.Columns[11].Visible = false;


                    dgvViajes.Columns[1].HeaderText = "Fecha Salida";
                    dgvViajes.Columns[1].ReadOnly = true;
                    dgvViajes.Columns[1].Width = 80;

                    dgvViajes.Columns[2].HeaderText = "Hora Salida";
                    dgvViajes.Columns[2].ReadOnly = true;
                    dgvViajes.Columns[2].Width = 60;

                    dgvViajes.Columns[5].HeaderText = "Fecha Llegada Estimada";
                    dgvViajes.Columns[5].ReadOnly = true;
                    dgvViajes.Columns[5].Width = 80;

                    dgvViajes.Columns[6].HeaderText = "Hora Llegada Estimada";
                    dgvViajes.Columns[6].ReadOnly = true;
                    dgvViajes.Columns[6].Width = 60;


                    dgvViajes.Columns[9].HeaderText = "Tipo de Servicio";
                    dgvViajes.Columns[9].ReadOnly = true;
                    dgvViajes.Columns[9].Width = 70;

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

            dpFechaLlegada.Format = DateTimePickerFormat.Custom;
            dpFechaLlegada.CustomFormat = "dd'/'MM'/'yyyy hh':'mm':'ss"; 
        }

        private void dgvViajes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            vueloSeleccionado = (Model.ViajeModel)dgvViajes.CurrentRow.DataBoundItem;            
            btnRegistrar.Enabled = true;
            dpFechaLlegada.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            DateTime fechaLlegada = dpFechaLlegada.Value;

            var fechaLlegadaFormateada = fechaLlegada.ToString("dd'/'MM'/'yyyy");
            var horaLlegadaFormateada = fechaLlegada.ToString("HH':'mm':'ss");
            vueloSeleccionado.fechaLlegada = fechaLlegadaFormateada;
            vueloSeleccionado.horaLlegada = horaLlegadaFormateada;
            Boolean modificado = viajeController.actualizarViaje(vueloSeleccionado);
            this.Close();
            new Menu.Menu().Show();
        }
    }
}
