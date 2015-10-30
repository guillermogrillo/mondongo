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
        public ABMRoles()
        {
            InitializeComponent();
            Controller.RolController controller = new Controller.RolController();
            List<Model.RolModel> roles = controller.buscarTodosLosRoles();
            cbRol.DisplayMember = "_rolNombre";
            //cbRol.ValueMember = "_rolNombre";  
            cbRol.DataSource = roles;
            cbRol.SelectedIndex = 1;
                     
        }

        private Model.RolModel rolSeleccionado { get; set; }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            rolSeleccionado = cbRol.SelectedValue as Model.RolModel;         
            DataTable table = new DataTable();
            table.Columns.Add("Nombre");

            List<Model.FuncionalidadModel> funcionalidadesDelRol = rolSeleccionado._rolFuncionalidades;
            foreach(Model.FuncionalidadModel funcionalidad in funcionalidadesDelRol)
            {
                DataRow dr = table.NewRow();
                dr["Nombre"] = funcionalidad._funcionalidadNombre;                
                table.Rows.Add(dr);
            }
            dgvFuncionalidades.DataSource = table;
            DataGridViewColumn column = dgvFuncionalidades.Columns[0];
            column.Width = 300;
        }

    }
}
