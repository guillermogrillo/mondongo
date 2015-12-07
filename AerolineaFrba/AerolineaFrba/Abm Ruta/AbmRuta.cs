using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class AbmRuta : Form
    {
        private Controller.RutaController _controller;
        private Controller.ViajeController viajeController;
        private Controller.CompraController compraController;


        private Boolean isBack = true;

        public AbmRuta()
        {            
            InitializeComponent();
            _controller = new Controller.RutaController();
            viajeController = new Controller.ViajeController();
            compraController = new Controller.CompraController();
        }

        private void AbmRuta_Load(object sender, EventArgs e)
        {
            dgRutas.RowHeadersWidth = 25;
            dgRutas.DataSource = _controller.buscarTodasLasRutas();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            isBack = false;
            this.Close();
            new Abm_Ruta.RutaForm().Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Model.RutaModel ruta = (Model.RutaModel)dgRutas.CurrentRow.DataBoundItem;
            if (ruta == null) return;

            isBack = false;
            this.Close();
            new Abm_Ruta.RutaForm(ruta).Show();
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            if(isBack)
                new AerolineasFRBA().Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Esta seguro de eliminar la ruta seleccionada?",
                                                    "Atencion",
                                                    MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.No)
                return;

            Model.RutaModel ruta = (Model.RutaModel)dgRutas.CurrentRow.DataBoundItem;            
            _controller.eliminarRuta(ruta.idRuta);
            cargarDevoluciones(ruta);
            dgRutas.DataSource = _controller.buscarTodasLasRutas();
            MessageBox.Show("Ruta eliminada");
        }

        private void cargarDevoluciones(Model.RutaModel ruta)
        {
            compraController.cargarDevolucionesPasajes(ruta, "Devolución de pasaje por cancelación de la Ruta");
            compraController.cargarDevolucionesPaquetes(ruta, "Devolución de paquete por cancelación de la Ruta");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
