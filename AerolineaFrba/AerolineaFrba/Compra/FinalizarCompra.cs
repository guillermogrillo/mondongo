using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class FinalizarCompra : Form
    {

        private Model.CompraModel compraModel;
        private int pnr;

        public FinalizarCompra(Model.CompraModel compraModel, int pnr)
        {
            InitializeComponent();
            this.compraModel = compraModel;
            this.pnr = pnr;
        }

        private void FinalizarCompra_Load(object sender, EventArgs e)
        {
            lblPnr.Text = pnr.ToString();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
            new AerolineasFRBA().Show();
        }
    }
}
