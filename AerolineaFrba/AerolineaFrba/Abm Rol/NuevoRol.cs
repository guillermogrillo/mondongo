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
        private Model.RolModel rol;

        public NuevoRol(Model.RolModel _rol)
        {
            InitializeComponent();
            controller = new Controller.RolController();
            rol = _rol;
            cbEstados.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(rol != null)
            {
                rol._rolHabilitado = (Model.Estado)cbEstados.SelectedValue;
                rol._rolNombre = tbNombreRol.Text;
                controller.modificarRol(rol);
            }
            else
            {
                controller.agregarNuevoRol(tbNombreRol.Text);
            }
            this.Hide();
            new Abm_Rol.ABMRoles().Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Abm_Rol.ABMRoles().Show();
        }

        private void NuevoRol_Load(object sender, EventArgs e)
        {
            cbEstados.DataSource = Enum.GetValues(typeof(Model.Estado));
            if (rol != null)
            {
                tbNombreRol.Text = rol._rolNombre;
                cbEstados.Enabled = true;
                cbEstados.SelectedIndex = (int)rol._rolHabilitado;
            }
            else
            {
                cbEstados.SelectedIndex = (int)Model.Estado.HABILITADO;
            }
                        
        }
    }
}
