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
        private Model.FuncionalidadModel funcionalidadSeleccionada = null;
        private List<Model.FuncionalidadModel> funcionalidadesDelRol = new List<Model.FuncionalidadModel>();

        public ABMRoles()
        {
            InitializeComponent();
            controller = new Controller.RolController();                               
        }     

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            rolSeleccionado = cbRol.SelectedValue as Model.RolModel;            
            funcionalidadesDelRol = rolSeleccionado._rolFuncionalidades;
            cargarTablaFuncionalidades();
        }

        private void cargarTablaFuncionalidades()
        {
            dgvFuncionalidades.DataSource = funcionalidadesDelRol;
            dgvFuncionalidades.Columns[0].Visible = false;
            dgvFuncionalidades.Columns[1].HeaderText = "Funcionalidad";
            dgvFuncionalidades.Columns[1].Width = 320;
            dgvFuncionalidades.Columns[2].Visible = false;
        }

        private void dgvFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            funcionalidadSeleccionada = (Model.FuncionalidadModel)dgvFuncionalidades.CurrentRow.DataBoundItem;
            btnBorrarFuncionalidad.Enabled = true;
        }


        private void btnBorrarRol_Click(object sender, EventArgs e)
        {
            MessageBox.Show("querés borrar " + rolSeleccionado._rolNombre);
        }

        private void btnBorrarFuncionalidad_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("Está seguro que quiere quitar "+funcionalidadSeleccionada._funcionalidadNombre + "?",
                                     "Quitar Funcionalidad",
                                     MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                    controller.quitarFuncionalidadDelRol(funcionalidadSeleccionada._funcionalidadId,rolSeleccionado._rolId);
                    List<Model.FuncionalidadModel> funcionalidades = rolSeleccionado._rolFuncionalidades.Where(funcionalidad => funcionalidad._funcionalidadId != funcionalidadSeleccionada._funcionalidadId).ToList();
                    rolSeleccionado._rolFuncionalidades = funcionalidades;
                    dgvFuncionalidades.DataSource = funcionalidades;
                    dgvFuncionalidades.ClearSelection();
                    btnBorrarFuncionalidad.Enabled = false;
            }                       
        }

        private void ABMRoles_Load(object sender, EventArgs e)
        {
            dgvFuncionalidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<Model.RolModel> roles = controller.buscarTodosLosRoles();
            cbRol.DisplayMember = "_rolNombre";
            cbRol.DataSource = roles;
            cbRol.SelectedIndex = 0;
            btnBorrarFuncionalidad.Enabled = false;
            dgvFuncionalidades.ClearSelection();
        }
  

    }
}
