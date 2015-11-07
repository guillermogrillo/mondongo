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
    public partial class NuevaFuncionalidad : Form
    {

        int rolId;
        Controller.RolController controller = null;
        Model.FuncionalidadModel funcionalidadSeleccionada = null;

        public NuevaFuncionalidad(int _rolId)
        {
            InitializeComponent();
            this.rolId = _rolId;
            controller = new Controller.RolController();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Abm_Rol.ABMFuncionalidades(rolId).Show();
        }

        private void NuevaFuncionalidad_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            List<Model.FuncionalidadModel> funcionalidadesDelRol = controller.buscarFuncionalidadesDelRol(rolId, true);
            cbFuncionalidades.Enabled = (funcionalidadesDelRol.Count > 0);
            cbFuncionalidades.DataSource = funcionalidadesDelRol;
            cbFuncionalidades.DisplayMember = "_funcionalidadNombre";
            cbFuncionalidades.SelectedIndex = 0;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {      
            controller.agregarFuncionalidadAlRol(funcionalidadSeleccionada._funcionalidadId, rolId);
            this.Hide();
            new Abm_Rol.ABMFuncionalidades(rolId).Show();
        }

        private void cbFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            funcionalidadSeleccionada = cbFuncionalidades.SelectedItem as Model.FuncionalidadModel;
            btnGuardar.Enabled = true;
        }
    }
}
