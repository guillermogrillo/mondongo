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
        public LoginAdministrador()
        {
            InitializeComponent();
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
                this.Hide();
                new Menu.Menu(true).Show();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AerolineaFrba.AerolineasFRBA().Show();
        }
    }
}
