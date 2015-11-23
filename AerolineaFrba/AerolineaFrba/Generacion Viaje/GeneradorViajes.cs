using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Generacion_Viaje
{
    public partial class GeneradorViajes : Form
    {

        public Model.CiudadModel ciudadOrigen = null;
        public Model.CiudadModel ciudadDestino = null;


        public GeneradorViajes()
        {
            InitializeComponent();
        }


        public Model.CiudadModel setCiudadOrigen()
        {
            return ciudadOrigen;
        }

        public void setCiudadOrigen(Model.CiudadModel ciudadModel)
        {
            ciudadOrigen = ciudadModel;
            tbCiudadOrigen.Text = ciudadOrigen.nombre;
        }

        public Model.CiudadModel getCiudadDestino()
        {
            return ciudadDestino;
        }

        public void setCiudadDestino(Model.CiudadModel ciudadModel)
        {
            ciudadDestino = ciudadModel;
            tbCiudadDestino.Text = ciudadDestino.nombre;
        }

        private void btnBuscarCiudadOrigen_Click(object sender, EventArgs e)
        {
            Generacion_Viaje.BuscadorCiudades busquedaCiudad = new Generacion_Viaje.BuscadorCiudades(this, 0);
            this.Hide();
            busquedaCiudad.Show();
        }

        private void btnBuscarCiudadDestino_Click(object sender, EventArgs e)
        {
            Generacion_Viaje.BuscadorCiudades busquedaCiudad = new Generacion_Viaje.BuscadorCiudades(this, 1);
            this.Hide();
            busquedaCiudad.Show();
        }
    }
}
