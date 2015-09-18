﻿using System;
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
            this.Hide();
            new Menu.Menu().Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AerolineaFrba.AerolineasFRBA().Show();
        }
    }
}
