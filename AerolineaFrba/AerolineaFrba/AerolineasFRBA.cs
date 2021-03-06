﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    public partial class AerolineasFRBA : Form
    {


        Controller.RolController rolController = null;

        public AerolineasFRBA()
        {
            InitializeComponent();
            rolController = new Controller.RolController();    
        }

        private void btnLoginAdministrador_Click(object sender, EventArgs e)
        {            
            this.Hide();
            Controller.Utils.GetInstance.isAdmin(true);
            new Login.LoginAdministrador().Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            List<Model.FuncionalidadModel> funcionalidades = rolController.buscarFuncionalidadesDelRol(2, false);
            this.Hide();
            Controller.Utils.GetInstance.isAdmin(false);
            new Menu.Menu(funcionalidades).Show();

        }

        private void AerolineasFRBA_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
