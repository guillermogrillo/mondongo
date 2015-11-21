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
            btnEditarRol.Enabled = false;
            btnFuncionalidades.Enabled = false;
        }     

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new AerolineasFRBA().Show();
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
            new Abm_Rol.NuevoRol(null).Show();
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }


        private void btnFuncionalidades_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Rol.ABMFuncionalidades pantallaFuncionalidades = new Abm_Rol.ABMFuncionalidades(rolSeleccionado._rolId);            
            pantallaFuncionalidades.Show();
        }

        private void btnEditarRol_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Abm_Rol.NuevoRol(rolSeleccionado).Show();
        }

        private void dgvRoles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rolSeleccionado = (Model.RolModel)dgvRoles.CurrentRow.DataBoundItem;
            if (rolSeleccionado._rolHabilitado != Model.Estado.Borrado)
            {                
                btnEditarRol.Enabled = true;
                btnFuncionalidades.Enabled = true;
            }
            else
            {
                btnEditarRol.Enabled = false;               
                btnFuncionalidades.Enabled = false;
            }
        }
  

    }
}
