using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class AbmRuta : Form
    {
        private Controller.RutaController _controller;

        private Boolean isBack = true;

        public AbmRuta()
        {
            _controller = new Controller.RutaController();
            InitializeComponent();
        }

        private void AbmRuta_Load(object sender, EventArgs e)
        {
            dgRutas.RowHeadersWidth = 25;
            dgRutas.Columns[0].Width = 80;
            dgRutas.Columns[1].Width = 80;
            dgRutas.Columns[2].Width = 80;
            dgRutas.Columns[3].Width = 80;
            dgRutas.Columns[4].Width = 80;
            dgRutas.Columns[5].Width = 80;
            dgRutas.Columns[6].Width = 80;
            dgRutas.DataSource = _controller.buscarTodasLasRutas();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            isBack = false;
            this.Close();
            new Abm_Ruta.RutaForm().Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Model.RutaModel ruta = (Model.RutaModel)dgRutas.CurrentRow.DataBoundItem;
            if (ruta == null) return;

            isBack = false;
            this.Close();
            new Abm_Ruta.RutaForm(ruta).Show();
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            if(isBack)
                new Menu.Menu().Show();
        }
    }
}
