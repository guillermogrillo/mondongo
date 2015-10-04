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
    public partial class BusquedaVuelos : Form
    {

        private Boolean _esAdmin { get; set; }

        public BusquedaVuelos(Boolean esAdmin)
        {
            InitializeComponent();
            _esAdmin = esAdmin;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu.Menu(_esAdmin).Show();
        }

        private void tbCantidadPasajeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCantidadPasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }     
        }

        private void dpFechaViaje_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Controller.CompraController compraController = new Controller.CompraController();
            compraController.buscarViajes(tbCiudadOrigen.Text, tbCiudadDestino.Text, dpFechaViaje.Text, tbCantidadPasajeros.Text);
        }
    }
}
