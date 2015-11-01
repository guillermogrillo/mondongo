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
        Model.CiudadModel ciudadSeleccionada = null;

        public BuscadorCiudades()
        {
            InitializeComponent();
            controller = new Controller.CiudadController();
            btnAceptar.Enabled = false;
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
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
