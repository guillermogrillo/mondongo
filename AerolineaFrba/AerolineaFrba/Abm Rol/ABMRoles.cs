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
    public partial class ABMRoles : Form
    {


        private Controller.RolController controller;
        private Model.RolModel rolSeleccionado { get; set; }        

        public ABMRoles()
        {
            InitializeComponent();
            controller = new Controller.RolController();
            btnBorrarRol.Enabled = false;
            btnCambiarEstado.Enabled = false;
            btnFuncionalidades.Enabled = false;
        }     

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu.Menu(true).Show();
        }

        private void ABMRoles_Load(object sender, EventArgs e)
        {
            dgvRoles.AutoGenerateColumns = true;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.DataSource = controller.buscarTodosLosRoles();
            dgvRoles.Columns[0].Visible = false;
            dgvRoles.Columns[1].HeaderText = "Nombre";
            dgvRoles.Columns[1].Width = 200;
            dgvRoles.Columns[1].ReadOnly = true;
            dgvRoles.Columns[2].HeaderText = "Estado";
            dgvRoles.Columns[2].Width = 110;
            dgvRoles.Columns[2].ReadOnly = true;
            dgvRoles.SelectedRows[0].Selected = true;
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Abm_Rol.NuevoRol().Show();
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rolSeleccionado = (Model.RolModel)dgvRoles.CurrentRow.DataBoundItem;
            if (rolSeleccionado._rolHabilitado != Model.Estado.Borrado)
            {
                btnBorrarRol.Enabled = true;
                btnCambiarEstado.Enabled = true;
                btnFuncionalidades.Enabled = true;
            }
            else
            {
                btnCambiarEstado.Enabled = false;
                btnBorrarRol.Enabled = false;
                btnFuncionalidades.Enabled = false;
            }
                
        }

        private void btnBorrarRol_Click(object sender, EventArgs e)
        {
            if(rolSeleccionado != null)
            {
                var exito = controller.cambiarEstadoRol(rolSeleccionado._rolId, (int)Model.Estado.Borrado);
                if (exito)
                {
                    dgvRoles.DataSource = controller.buscarTodosLosRoles();
                }
            }
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            int nuevoEstado = 1;
            if (rolSeleccionado != null)
            {
                if(rolSeleccionado._rolHabilitado == Model.Estado.Deshabilitado)
                {
                    nuevoEstado = (int)Model.Estado.Habilitado;
                }else if(rolSeleccionado._rolHabilitado == Model.Estado.Habilitado)
                {
                    nuevoEstado = (int)Model.Estado.Deshabilitado;
                }
                var exito = controller.cambiarEstadoRol(rolSeleccionado._rolId, nuevoEstado);
                if (exito)
                {
                    dgvRoles.DataSource = controller.buscarTodosLosRoles();
                }
            }
        }

        private void btnFuncionalidades_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Rol.ABMFuncionalidades pantallaFuncionalidades = new Abm_Rol.ABMFuncionalidades(rolSeleccionado._rolId);            
            pantallaFuncionalidades.Show();
        }
  

    }
}
