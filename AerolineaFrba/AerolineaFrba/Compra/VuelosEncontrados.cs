using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class VuelosEncontrados : Form
    {

        Dao.ViajeDao viajeDao = null;
        Model.CompraModel compraModel = null;
        Model.ViajeModel vueloElegido = null;

        public VuelosEncontrados(Model.CompraModel _compraModel)
        {
            InitializeComponent();
            viajeDao = new Dao.ViajeDao();
            this.compraModel = _compraModel;
            btnSeleccionar.Enabled = false;
        }

        private void VuelosEncontrados_Load(object sender, EventArgs e)
        {
            dgvVuelos.AutoGenerateColumns = true;
            dgvVuelos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVuelos.DataSource = compraModel.vuelos;
            dgvVuelos.Columns[0].Visible = false;
            dgvVuelos.Columns[3].Visible = false;
            dgvVuelos.Columns[4].Visible = false;
            dgvVuelos.Columns[5].Visible = false;
            dgvVuelos.Columns[6].Visible = false;

            dgvVuelos.Columns[1].HeaderText = "Fecha Salida";            
            dgvVuelos.Columns[1].ReadOnly = true;
            dgvVuelos.Columns[1].Width = 70;

            dgvVuelos.Columns[2].HeaderText = "Hora Salida";            
            dgvVuelos.Columns[2].ReadOnly = true;
            dgvVuelos.Columns[2].Width = 55;

            dgvVuelos.Columns[7].HeaderText = "Ciudad Origen";
            dgvVuelos.Columns[7].ReadOnly = true;
            dgvVuelos.Columns[7].Width = 100;

            dgvVuelos.Columns[8].HeaderText = "Ciudad Destino";
            dgvVuelos.Columns[8].ReadOnly = true;
            dgvVuelos.Columns[8].Width = 100;

            dgvVuelos.Columns[9].HeaderText = "Tipo de Servicio";
            dgvVuelos.Columns[9].ReadOnly = true;
            dgvVuelos.Columns[9].Width = 65;

            dgvVuelos.Columns[10].HeaderText = "Matricula";
            dgvVuelos.Columns[10].ReadOnly = true;
            dgvVuelos.Columns[10].Width = 65;

            dgvVuelos.Columns[11].HeaderText = "Butacas Disponibles";
            dgvVuelos.Columns[11].ReadOnly = true;
            dgvVuelos.Columns[11].Width = 65;

            dgvVuelos.Columns[12].HeaderText = "Kg. Disponibles";
            dgvVuelos.Columns[12].ReadOnly = true;
            dgvVuelos.Columns[12].Width = 65;

            dgvVuelos.SelectedRows[0].Selected = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new Compra.BusquedaVuelos().Show();
        }

        private void dgvVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.Close();
            compraModel.clientes = new List<Model.ClienteModel>();
            new Compra.Pasajeros(compraModel).Show();
        }

        private void dgvVuelos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            vueloElegido = (Model.ViajeModel)dgvVuelos.CurrentRow.DataBoundItem;
            compraModel.vueloElegido = vueloElegido;
            btnSeleccionar.Enabled = true;
        }
    }
}
