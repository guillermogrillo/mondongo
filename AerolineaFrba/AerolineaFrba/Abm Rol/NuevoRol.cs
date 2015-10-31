using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Rol
{
    public partial class NuevoRol : Form
    {

        private Controller.RolController controller;

        public NuevoRol()
        {
            InitializeComponent();
            controller = new Controller.RolController();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controller.agregarNuevoRol(tbNombreRol.Text);
            this.Hide();
            new Abm_Rol.ABMRoles().Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Abm_Rol.ABMRoles().Show();
        }
    }
}
