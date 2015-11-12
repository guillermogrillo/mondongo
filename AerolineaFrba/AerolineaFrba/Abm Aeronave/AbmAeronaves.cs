using AerolineaFrba.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Aeronave
{
    public partial class AbmAeronaves : Form
    {
        Controller.AeronaveController _controller;

        private Boolean isBack;

        public AbmAeronaves()
        {
            isBack = true;
            _controller = new Controller.AeronaveController();
            InitializeComponent();
        }

        private void AbmAeronaves_Load(object sender, EventArgs e)
        {
            cargarAeronaves(); 
            DGVAeronave.RowHeadersWidth = 25;
            DGVAeronave.Columns[0].Width = 80;
            DGVAeronave.Columns[1].Width = 80;
            DGVAeronave.Columns[2].Width = 80;
            DGVAeronave.Columns[3].Width = 80;
        }

        public void cargarAeronaves()
        {
            DGVAeronave.DataSource = _controller.buscarAeronaves();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            AeronaveModel aeronave = (Model.AeronaveModel)DGVAeronave.CurrentRow.DataBoundItem;
            if (aeronave == null) return;

            this.Hide();
            Abm_Aeronave.AeronaveForm aeronaveForm = new Abm_Aeronave.AeronaveForm(this, aeronave);
            aeronaveForm.habilitarMatricula(false);
            aeronaveForm.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abm_Aeronave.AeronaveForm aeronaveForm = new Abm_Aeronave.AeronaveForm(this, null);
            aeronaveForm.habilitarMatricula(true);
            aeronaveForm.Show();
        }

        private void fueraServicioBtn_Click(object sender, EventArgs e)
        {
            AeronaveModel aeronave = (Model.AeronaveModel)DGVAeronave.CurrentRow.DataBoundItem;
            DialogResult pregunta = MessageBox.Show("Esta seguro de dejar fuera de servicio la aeronave "+aeronave.matricula+"?",
                                                    "Atencion",
                                                    MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.No)
                return;

            Abm_Aeronave.BajaAeronaveForm fueraServicioForm = new Abm_Aeronave.BajaAeronaveForm(aeronave, true);
            fueraServicioForm.Height = 160;
            fueraServicioForm.Show();
        }

        private void bajaBtn_Click(object sender, EventArgs e)
        {
            AeronaveModel aeronave = (Model.AeronaveModel)DGVAeronave.CurrentRow.DataBoundItem;
            DialogResult pregunta = MessageBox.Show("Se dara de baja la aeronave " + aeronave.matricula + ". Esta seguro?",
                                                    "Atencion",
                                                    MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.No)
                return;

            Abm_Aeronave.BajaAeronaveForm fueraServicioForm = new Abm_Aeronave.BajaAeronaveForm(aeronave, false);
            fueraServicioForm.Height = 160;
            fueraServicioForm.Show();
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            if (isBack)
                new Menu.Menu().Show();
        }

        
    }
}
