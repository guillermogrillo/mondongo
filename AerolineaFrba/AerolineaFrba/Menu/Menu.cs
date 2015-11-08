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
        
        public Menu()
        {
            InitializeComponent();            
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            new AerolineasFRBA().Show();
        }

        private void btnABMRol_Click(object sender, EventArgs e)
        {
            this.Close();
            new Abm_Rol.ABMRoles().Show();
        }

        private void btnComprarPasajes_Click(object sender, EventArgs e)
        {
            this.Close();
            new Compra.BusquedaVuelos().Show();
        }
		
        private void btnABMAeronaves_Click(object sender, EventArgs e)
        {
            this.Close();
            new Abm_Aeronave.AbmAeronaves().Show();
        }

        private void btnRegistrarLlegada_Click(object sender, EventArgs e)
        {
            this.Close();
            new Registro_Llegada_Destino.RegistroLlegadaDestino().Show();
        }       
    }
}
