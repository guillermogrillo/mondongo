using System;
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
        public AerolineasFRBA()
        {
            InitializeComponent();                   
        }

        private void btnLoginAdministrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login.LoginAdministrador().Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu.Menu().Show();

        }
    }
}
