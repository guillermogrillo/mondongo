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
    public partial class BuscadorCiudad : Form
    {
        public BuscadorCiudad()
        {
            InitializeComponent();
        }

        private void BuscadorCiudad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2015DataSet.ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.gD2C2015DataSet.ciudades);

        }
    }
}
