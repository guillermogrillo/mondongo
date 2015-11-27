using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class GeneradorViajes : Form
    {

        public Model.CiudadModel ciudadOrigen = null;
        public Model.CiudadModel ciudadDestino = null;
        private Controller.RutaController rutaController = null;
        private Controller.TipoServicioController tipoServicioController = null;
        private Controller.AeronaveController aeronaveController = null;
        private Controller.ViajeController viajeController = null;
        private Model.RutaModel rutaEncontrada = null;
        private Model.AeronaveModel aeronaveSeleccionada = null;
        DateTime fechaSistema = Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings.Get("fechaSistema"));

        public GeneradorViajes()
        {
            InitializeComponent();

            dpFechaSalida.Format = DateTimePickerFormat.Custom;
            dpFechaSalida.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dpFechaSalida.Value = fechaSistema;

            dpFechaLlegadaEstimada.Format = DateTimePickerFormat.Custom;
            dpFechaLlegadaEstimada.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dpFechaLlegadaEstimada.Value = fechaSistema;

            rutaController = new Controller.RutaController();
            tipoServicioController = new Controller.TipoServicioController();
            aeronaveController = new Controller.AeronaveController();
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

        private void btnBuscarCiudadOrigen_Click(object sender, EventArgs e)
        {
            Generacion_Viaje.BuscadorCiudades busquedaCiudad = new Generacion_Viaje.BuscadorCiudades(this, 0);
            this.Hide();
            busquedaCiudad.Show();
        }

        private void btnBuscarCiudadDestino_Click(object sender, EventArgs e)
        {
            Generacion_Viaje.BuscadorCiudades busquedaCiudad = new Generacion_Viaje.BuscadorCiudades(this, 1);
            this.Hide();
            busquedaCiudad.Show();
        }

        private void GeneradorViajes_Load(object sender, EventArgs e)
        {
            gbViajePasoDos.Visible = false;

            cbTipoServicio.DataSource = tipoServicioController.buscarTiposServicio();
            cbTipoServicio.DisplayMember = "tipoServicio";
        }

        private void dpFechaSalida_ValueChanged(object sender, EventArgs e)
        {   
            if(rutaEncontrada != null){
                DateTime fechaSalida = dpFechaSalida.Value;
                DateTime fechaLlegadaEstimada = fechaSalida.AddHours(rutaEncontrada.horasVuelo);
                dpFechaLlegadaEstimada.Value = fechaLlegadaEstimada;            
            }
            
        }

        private void btnBuscarRuta_Click(object sender, EventArgs e)
        {
            int tipoServicioId = (cbTipoServicio.SelectedValue as Model.TipoServicioModel).id;
            rutaEncontrada = rutaController.buscarRuta(ciudadOrigen.ciudadId, ciudadDestino.ciudadId, tipoServicioId);

            if (rutaEncontrada != null)
            {
                gbViajePasoDos.Visible = true;                                               

                List<Model.AeronaveModel> todasLasAeronaves =  aeronaveController.buscarAeronaves();
                List<Model.AeronaveModel> aeronavesDisponibles = new List<Model.AeronaveModel>();
                DateTime fechaSalida = dpFechaSalida.Value;
                foreach (Model.AeronaveModel aeronave in todasLasAeronaves)
                {
                    Boolean tieneViajesAsignados = aeronaveController.chequearViajesAsignados(aeronave.matricula, fechaSalida, fechaSalida.AddDays(1));
                    Model.TipoServicioModel tipoDeServicio = cbTipoServicio.SelectedValue as Model.TipoServicioModel;
                    if (!tieneViajesAsignados && aeronave.idTipoServicio == tipoDeServicio.id)
                    {
                        aeronavesDisponibles.Add(aeronave);
                    }
                }

                cbAeronaves.DataSource = aeronavesDisponibles;
                cbAeronaves.DisplayMember = "matricula";

            }else{
                MessageBox.Show("No se encontraron rutas con los parámetros ingresados");
            }
           
        }

        private void tbCiudadOrigen_TextChanged(object sender, EventArgs e)
        {
            gbViajePasoDos.Visible = false;
        }

        private void tbCiudadDestino_TextChanged(object sender, EventArgs e)
        {
            gbViajePasoDos.Visible = false;
        }

        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbViajePasoDos.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaSalida = dpFechaSalida.Value;
            DateTime fechaLlegadaEstimada = dpFechaLlegadaEstimada.Value;
            if (fechaSalida < fechaSistema || fechaLlegadaEstimada < fechaSistema)
            {
                MessageBox.Show("Las fechas de salida y de llegada estimada deben ser posteriores a la fecha de sistema.");
            }else{
                Model.ViajeModel viaje = new Model.ViajeModel(rutaEncontrada.idRuta,aeronaveSeleccionada.matricula,fechaSalida, fechaLlegadaEstimada ,aeronaveSeleccionada.cantButacasPas,aeronaveSeleccionada.cantButacasVen,aeronaveSeleccionada.capacidadKg);                                   
                viajeController.guardarViaje(viaje, rutaEncontrada, aeronaveSeleccionada);
                this.Close();
                new AerolineasFRBA().Show();
            }            
        }

        private void cbAeronaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            aeronaveSeleccionada = cbAeronaves.SelectedValue as Model.AeronaveModel;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new AerolineasFRBA().Show();
        }
    }
}
