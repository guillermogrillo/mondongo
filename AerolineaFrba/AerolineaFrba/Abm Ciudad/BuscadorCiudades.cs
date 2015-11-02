using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class BuscadorCiudades : Form
    {

        Controller.CiudadController controller = null;
        public Model.CiudadModel ciudadSeleccionada = null;
        int modo;
        Compra.BusquedaVuelos pantalla;

        public BuscadorCiudades(Compra.BusquedaVuelos _pantalla, int _modo)
        {
            InitializeComponent();
            controller = new Controller.CiudadController();
            btnAceptar.Enabled = false;
            this.modo = _modo;
            this.pantalla = _pantalla;
        }

        private void BuscadorCiudades_Load(object sender, EventArgs e)
        {
            dgvCiudades.AutoGenerateColumns = true;
            dgvCiudades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCiudades.DataSource = controller.buscarTodasLasCiudades();
            dgvCiudades.Columns[0].Visible = false;
            dgvCiudades.Columns[1].HeaderText = "Nombre";
            dgvCiudades.Columns[1].Width = 200;
            dgvCiudades.Columns[1].ReadOnly = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(modo == 0){
                pantalla.setCiudadOrigen(ciudadSeleccionada);
            }else{
                pantalla.setCiudadDestino(ciudadSeleccionada);
            }
            
            this.Hide();
            pantalla.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            pantalla.Show();
        }

        private void dgvCiudades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ciudadSeleccionada = (Model.CiudadModel)dgvCiudades.CurrentRow.DataBoundItem;
            btnAceptar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCiudades.DataSource = controller.buscarCiudades(tbCiudad.Text);
        }

        

    }
}
