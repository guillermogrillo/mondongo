using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ciudad
{
    public partial class AbmCiudad : Form
    {              
        Controller.CiudadController controller = null;                

        public AbmCiudad()
        {
            InitializeComponent();
            controller = new Controller.CiudadController();
        }

        private void AbmCiudad_Load(object sender, EventArgs e)
        {
            dgvCiudad.AutoGenerateColumns = true;
            dgvCiudad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;            
            dgvCiudad.DataSource = controller.buscarTodasLasCiudades();            
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvCiudad.DataSource = controller.buscarCiudades(tbCiudad.Text);
            
        }

        private void dgvCiudad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu.Menu().Show();
        }

     



    }
}
