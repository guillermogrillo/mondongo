using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Login
{
    public partial class LoginAdministrador : Form
    {


        Controller.RolController rolController = null;
        Controller.LoginController loginController = null;

        public LoginAdministrador()
        {
            InitializeComponent();
            rolController = new Controller.RolController();
            loginController = new Controller.LoginController();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Model.RespuestaLoginModel respuestaLogin = loginController.buscarUsuario(tbUsuario.Text, tbContraseña.Text);

            Model.LoginRespuesta respuesta = respuestaLogin.codigoRespuesta;

            if (respuesta == Model.LoginRespuesta.OK)
            {
                lblError.Text = "";
                List<Model.FuncionalidadModel> funcionalidades = rolController.buscarFuncionalidadesDelRol(1, false);
                this.Hide();
                new Menu.Menu(funcionalidades).Show();
            }
            else if(respuesta == Model.LoginRespuesta.NO_ENCONTRADO)
            {
                lblError.Text = "Usuario inexistente.";
            }
            else if(respuesta == Model.LoginRespuesta.CONTRASEÑA_INCORRECTA)
            {
                lblError.Text = "Contraseña incorrecta.";
            }
            else if (respuesta == Model.LoginRespuesta.BLOQUEADO)
            {
                lblError.Text = "Usuario bloqueado.";
            }
              

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AerolineaFrba.AerolineasFRBA().Show();
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
