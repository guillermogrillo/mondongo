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
            dgvVuelos.Columns[6].Visible = false;
            dgvVuelos.Columns[11].Visible = false;

            dgvVuelos.Columns[1].HeaderText = "Ciudad Origen";
            dgvVuelos.Columns[1].ReadOnly = true;
            dgvVuelos.Columns[1].Width = 100;

            dgvVuelos.Columns[2].HeaderText = "Ciudad Destino";
            dgvVuelos.Columns[2].ReadOnly = true;
            dgvVuelos.Columns[2].Width = 100;

            dgvVuelos.Columns[3].HeaderText = "Tipo de Servicio";
            dgvVuelos.Columns[3].ReadOnly = true;
            dgvVuelos.Columns[3].Width = 65;

            dgvVuelos.Columns[4].HeaderText = "Matricula";
            dgvVuelos.Columns[4].ReadOnly = true;
            dgvVuelos.Columns[4].Width = 65;

            dgvVuelos.Columns[5].HeaderText = "Kg. Disponibles";
            dgvVuelos.Columns[5].ReadOnly = true;
            dgvVuelos.Columns[5].Width = 65;

            dgvVuelos.Columns[7].HeaderText = "Butacas Disponibles Pasillo";
            dgvVuelos.Columns[7].ReadOnly = true;
            dgvVuelos.Columns[7].Width = 65;

            dgvVuelos.Columns[8].HeaderText = "Butacas Disponibles Ventanilla";
            dgvVuelos.Columns[8].ReadOnly = true;
            dgvVuelos.Columns[8].Width = 65;

            dgvVuelos.Columns[9].HeaderText = "Fecha Salida";
            dgvVuelos.Columns[9].ReadOnly = true;
            dgvVuelos.Columns[9].Width = 100;

            dgvVuelos.Columns[10].HeaderText = "Fecha Llegada Estimada";
            dgvVuelos.Columns[10].ReadOnly = true;
            dgvVuelos.Columns[10].Width = 100;

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
            compraModel.butacasSeleccionadas = new Dictionary<string, List<int>>();
            compraModel.butacasSeleccionadas.Add(Model.TipoButaca.PASILLO.ToString(), new List<int>());
            compraModel.butacasSeleccionadas.Add(Model.TipoButaca.VENTANILLA.ToString(), new List<int>());
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
