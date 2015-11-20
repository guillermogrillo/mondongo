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

        public LoginAdministrador()
        {
            InitializeComponent();
            rolController = new Controller.RolController();    

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {            
            Boolean usuarioValido = new Controller.LoginController().autenticar(tbUsuario.Text,tbContraseña.Text);
            if (!usuarioValido)
            {
                lblError.Text = "El Usuario o Contraseña ingresados son inválidos";
            }
            else
            {
                lblError.Text = "";
                List<Model.FuncionalidadModel> funcionalidades = rolController.buscarFuncionalidadesDelRol(1, false);
                this.Hide();
                new Menu.Menu(funcionalidades).Show();
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
