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
    public partial class Pasajeros : Form
    {

        Model.CompraModel compraModel = null;
        Model.ClienteModel clienteSeleccionado = null;

        public Pasajeros(Model.CompraModel _compraModel)
        {
            InitializeComponent();
            compraModel = _compraModel;
        }

        private void Pasajeros_Load(object sender, EventArgs e)
        {            
            btnEditar.Enabled = false;
            btnQuitar.Enabled = false;
            if(compraModel.clientes.Count==compraModel.cantidadPax)
            {
                btnAgregar.Enabled = false;
            }
            btnSiguiente.Enabled = false;
            lblPasajerosACargar.Text = compraModel.cantidadPax.ToString();           
            lblPasajerosYaCargados.Text = "0";
            if (compraModel.clientes != null)
            {
                lblPasajerosYaCargados.Text = compraModel.clientes.Count.ToString();
            }
            if(lblPasajerosACargar.Text.Equals(lblPasajerosYaCargados.Text))
            {
                btnSiguiente.Enabled = true;
            }

            dgvClientes.DataSource = compraModel.clientes;
            dgvClientes.AutoGenerateColumns = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvClientes.Columns[0].Visible = false;

            dgvClientes.Columns[1].HeaderText = "DNI";
            dgvClientes.Columns[1].ReadOnly = true;
            dgvClientes.Columns[1].Width = 70;

            dgvClientes.Columns[2].HeaderText = "Nombre";
            dgvClientes.Columns[2].ReadOnly = true;
            dgvClientes.Columns[2].Width = 80;

            dgvClientes.Columns[3].HeaderText = "Apellido";
            dgvClientes.Columns[3].ReadOnly = true;
            dgvClientes.Columns[3].Width = 80;

            dgvClientes.Columns[4].Visible = false;
            dgvClientes.Columns[5].Visible = false;
            dgvClientes.Columns[6].Visible = false;
            dgvClientes.Columns[7].Visible = false;
            dgvClientes.Columns[8].Visible = false;
            dgvClientes.Columns[9].Visible = false;
            dgvClientes.Columns[10].Visible = false;
            dgvClientes.Columns[11].Visible = false; 
        }

        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            clienteSeleccionado = (Model.ClienteModel)dgvClientes.CurrentRow.DataBoundItem;
            btnQuitar.Enabled = true;
            btnEditar.Enabled = true;

            String detalleButaca =  "Tipo de butaca: " + clienteSeleccionado.butaca.tipo +                                     
                                    " | Nro: " + clienteSeleccionado.butaca.numero;
            lblDetalleButaca.Text = detalleButaca;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new VuelosEncontrados(compraModel).Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
            new Compra.NuevoPasajero(compraModel).Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Close();
            new Compra.Pagador(compraModel).Show();
        }
    }
}
