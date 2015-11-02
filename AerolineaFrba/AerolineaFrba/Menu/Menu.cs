using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Menu
{
    public partial class Menu : Form
    {

        private Boolean _esAdmin { get; set; }

        public Menu()
        {
            InitializeComponent();            
        }

        public Menu(Boolean esAdmin)
        {
            InitializeComponent();
            _esAdmin = esAdmin;
            this.btnABMRol.Visible = esAdmin;
            this.btnABMRutaAerea.Visible = esAdmin;            
            this.btnABMAeronaves.Visible = esAdmin;
            this.btnGenerarViaje.Visible = esAdmin;
            this.btnListado.Visible = esAdmin;
            this.btnRegistrarLlegada.Visible = esAdmin;
            this.grpAdministrador.Visible = esAdmin;            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AerolineasFRBA().Show();
        }

        private void btnABMRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Abm_Rol.ABMRoles().Show();
        }

        private void btnComprarPasajes_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Compra.BusquedaVuelos(_esAdmin).Show();
        }
       
    }
}
