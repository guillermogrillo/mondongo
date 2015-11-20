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


        public List<Model.FuncionalidadModel> funcionalidades = null;
        
        public Menu(List<Model.FuncionalidadModel> _funcionalidades)
        {
            InitializeComponent();
            funcionalidades = _funcionalidades;
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

        private void btnABMRutaAerea_Click(object sender, EventArgs e)
        {
            this.Close();
            new Abm_Ruta.AbmRuta().Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            foreach (Model.FuncionalidadModel funcionalidad in funcionalidades)
            {
                Control[] controles = this.Controls.Find(funcionalidad._funcionalidadNombre,true);
                controles[0].Visible = true;
            }
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            this.Close();
            new Listado_Estadistico.ListadosEstadisticos().Show();
        }       
    }
}
