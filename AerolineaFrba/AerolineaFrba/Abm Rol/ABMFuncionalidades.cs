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
    public partial class ABMFuncionalidades : Form
    {
        
        Controller.RolController controller = null;
        int rolId;
        Model.FuncionalidadModel funcionalidadSeleccionada = null;

        public ABMFuncionalidades(int _rolId)
        {
            InitializeComponent();
            this.rolId = _rolId;
            controller = new Controller.RolController();
            btnBorrarFuncionalidad.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Abm_Rol.ABMRoles().Show();
        }

        private void ABMFuncionalidades_Load(object sender, EventArgs e)
        {
            dgvFuncionalidades.AutoGenerateColumns = true;
            dgvFuncionalidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionalidades.DataSource = controller.buscarFuncionalidadesDelRol(rolId, false);
            dgvFuncionalidades.Columns[0].Visible = false;            
            dgvFuncionalidades.Columns[1].HeaderText = "Nombre";
            dgvFuncionalidades.Columns[1].Width = 300;
            dgvFuncionalidades.Columns[1].ReadOnly = true;
            dgvFuncionalidades.Columns[2].HeaderText = "Descripcion";
            dgvFuncionalidades.Columns[2].Width = 400;
            dgvFuncionalidades.Columns[2].ReadOnly = true;
            dgvFuncionalidades.SelectedRows[0].Selected = true;
        }

        private void dgvFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            funcionalidadSeleccionada = (Model.FuncionalidadModel)dgvFuncionalidades.CurrentRow.DataBoundItem;
            btnBorrarFuncionalidad.Enabled = true;
        }

        private void btnBorrarFuncionalidad_Click(object sender, EventArgs e)
        {
            if (funcionalidadSeleccionada != null)
            {
                var exito = controller.borrarFuncionalidadDelRol(funcionalidadSeleccionada._funcionalidadId, rolId);
                if (exito)
                {
                    dgvFuncionalidades.DataSource = controller.buscarFuncionalidadesDelRol(rolId, false);
                }
            }
        }

        private void btnAgregarFuncionalidad_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Abm_Rol.NuevaFuncionalidad(rolId).Show();
        }
    }
}
