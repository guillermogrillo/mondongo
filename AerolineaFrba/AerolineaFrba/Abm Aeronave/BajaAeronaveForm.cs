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
        //private Boolean fechaHastaEnabled;

        public BajaAeronaveForm(Model.AeronaveModel a, Boolean fechaVisible)
        {
            _aeronave = a;
            _controller = new Controller.AeronaveController();
            dpFechaHasta.Visible = fechaVisible;
            InitializeComponent();
        }

        //boton aceptar
        private void fueraServicio_click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dpFechaDesde.Value;
            DateTime fechaHasta = DateTime.MaxValue;
            if (dpFechaHasta.Visible) fechaHasta = dpFechaHasta.Value;
            Boolean tieneViajesAsignados = _controller.chequearViajesAsignados(_aeronave.matricula, fechaDesde, fechaHasta);

            if (!tieneViajesAsignados)
            {
                actualizarAeronave();

                MessageBox.Show("Aeronave fuera de servicio");
                this.Close();
            }
            else
            {
                this.Height = 250;
            }

        }

        private void cancelar_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCanelarViajes_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dpFechaDesde.Value;
            DateTime fechaHasta = DateTime.MaxValue;
            if (dpFechaHasta.Visible) fechaHasta = dpFechaHasta.Value;

            Dao.ViajeDao daoViajes = new Dao.ViajeDao();
            daoViajes.cancelarViajesAeronave(_aeronave.matricula, fechaDesde, fechaHasta);
            this.Close();
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
                this.Close();
            }
        }

        private void actualizarAeronave()
        {
            if (dpFechaHasta.Visible)
                _controller.fueraServicioAeronave(_aeronave.matricula, dpFechaDesde.Value, dpFechaHasta.Value);
            else
                _controller.bajaAeronave(_aeronave.matricula, dpFechaDesde.Value);
        }

    }
}
