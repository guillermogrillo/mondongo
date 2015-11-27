using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Consulta_Millas
{
    public partial class SeleccionClienteDuplicado : Form
    {
        private List<Model.ClienteModel> clientes = null;
        private Model.ClienteModel clienteSeleccionado = null;
        private Consulta_Millas.ConsultaMillas pantalla = null;

        public SeleccionClienteDuplicado(List<Model.ClienteModel> clientes, Consulta_Millas.ConsultaMillas pantalla)
        {
            InitializeComponent();
            this.clientes = clientes;
            this.pantalla = pantalla;
            cbClientes.DataSource = clientes;
            cbClientes.DisplayMember = "NombreCompleto";
            cbClientes.SelectedIndex = 0;
        }


        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            pantalla.Show();
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteSeleccionado = cbClientes.SelectedItem as Model.ClienteModel;
            pantalla.setClientePantalla(clienteSeleccionado);
        }

    }
}
