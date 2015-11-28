using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class BajaAeronaveForm : Form
    {
        public Model.AeronaveModel _aeronave;
        public Controller.AeronaveController _controller;
        public Controller.ViajeController _viajeController;
        public Controller.CompraController _compraController;
        //private Boolean fechaHastaEnabled;
        DateTime fechaSistema = Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings.Get("fechaSistema"));

        public BajaAeronaveForm(Model.AeronaveModel a, Boolean fechaVisible)
        {
            _aeronave = a;
            _controller = new Controller.AeronaveController();
            _compraController = new Controller.CompraController();
            _viajeController = new Controller.ViajeController();
            InitializeComponent();
            dpFechaHasta.Visible = fechaVisible;
            labelFechaHasta.Visible = fechaVisible;
            dpFechaDesde.Value = fechaSistema;
            dpFechaHasta.Value = fechaSistema;
        }

        //boton aceptar
        private void fueraServicio_click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dpFechaDesde.Value;
            DateTime fechaHasta = DateTime.MaxValue;
            if (dpFechaHasta.Visible) fechaHasta = dpFechaHasta.Value;

            if (fechaSistema.CompareTo(fechaDesde) == 1  || (fechaSistema.CompareTo(fechaDesde) == 0 && fechaDesde.TimeOfDay < fechaSistema.TimeOfDay))
            {
                MessageBox.Show("Fecha desde invalida"); return;
            }
            if (fechaDesde.CompareTo(fechaHasta) == 1 || (fechaDesde.CompareTo(fechaHasta) == 0 && fechaHasta.TimeOfDay <= fechaDesde.TimeOfDay))
            {
                MessageBox.Show("Fecha hasta invalida"); return;
            }

            Boolean tieneViajesAsignados = _controller.chequearViajesAsignados(_aeronave.matricula, fechaDesde, fechaHasta);

            if (!tieneViajesAsignados)
            {
                actualizarAeronave();

                MessageBox.Show("Aeronave fuera de servicio");
                Abm_Aeronave.AbmAeronaves abm_aeronaves = new Abm_Aeronave.AbmAeronaves();
                this.Close();
                abm_aeronaves.Show();
            }
            else
            {
                this.Height = 250;
            }

        }

        private void cancelar_click(object sender, EventArgs e)
        {
            Abm_Aeronave.AbmAeronaves abm_aeronaves = new Abm_Aeronave.AbmAeronaves();
            this.Close();
            abm_aeronaves.Show();
        }

        private void btCanelarViajes_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dpFechaDesde.Value;
            DateTime fechaHasta = DateTime.MaxValue;
            if (dpFechaHasta.Visible) fechaHasta = dpFechaHasta.Value;

            Dao.ViajeDao daoViajes = new Dao.ViajeDao();
            daoViajes.cancelarViajesAeronave(_aeronave.matricula, fechaDesde, fechaHasta);
            cargarDevolucionPasajes(fechaDesde, fechaHasta);
            cargarDevolucionPaquetes(fechaDesde, fechaHasta);
            
            MessageBox.Show("Se han cancelado todos los viajes para la fecha solicitada");
            Abm_Aeronave.AbmAeronaves abm_aeronaves = new Abm_Aeronave.AbmAeronaves();
            this.Close();
            abm_aeronaves.Show();
        }

        private void btSuplantarAeronave_Click(object sender, EventArgs e)
        {
            DateTime fechaHasta = DateTime.MaxValue;
            if (dpFechaHasta.Visible) fechaHasta = dpFechaHasta.Value;

            String respuesta = _controller.buscarAeronaveReemplazo(_aeronave, dpFechaDesde.Value, fechaHasta);

            if (respuesta.Contains("Atencion"))
                MessageBox.Show(respuesta);
            else
            {
                Dao.ViajeDao daoViajes = new Dao.ViajeDao();
                daoViajes.actualizarAeronaveViajes(_aeronave.matricula, respuesta, dpFechaDesde.Value, fechaHasta);

                actualizarAeronave();

                MessageBox.Show("Se ha suplantado la aeronave por " + respuesta);
                Abm_Aeronave.AbmAeronaves abm_aeronaves = new Abm_Aeronave.AbmAeronaves();
                this.Close();
                abm_aeronaves.Show();
            }
        }

        private void actualizarAeronave()
        {
            if (dpFechaHasta.Visible)
                _controller.fueraServicioAeronave(_aeronave.matricula, dpFechaDesde.Value, dpFechaHasta.Value);
            else
                _controller.bajaAeronave(_aeronave.matricula, dpFechaDesde.Value);
        }

        private void cargarDevolucionPasajes(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Model.PasajeModel> pasajes = _viajeController.pasajesParaDevolucion(_aeronave.matricula, fechaDesde, fechaHasta);
            foreach (Model.PasajeModel pasaje in pasajes)
            {
                _compraController.cargarDevolucionPasaje(pasaje.pasajePnr, pasaje.pasajeId, "Cancelacion de viaje");
            }
        }
        private void cargarDevolucionPaquetes(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Model.PaqueteModel> paquetes = _viajeController.paquetesParaDevolucion(_aeronave.matricula, fechaDesde, fechaHasta);
            foreach (Model.PaqueteModel paquete in paquetes)
            {
                _compraController.cargarDevolucionPasaje(paquete.paquetePnr, paquete.paqueteId, "Cancelacion de viaje");
            }
        }

    }
}
