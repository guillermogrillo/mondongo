using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Consulta_Millas
{
    public partial class ConsultaMillas : Form
    {

        private Controller.MillasController millasController = null;


        public ConsultaMillas()
        {
            InitializeComponent();
            millasController = new Controller.MillasController();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String dni = tbDni.Text;

            if(!dni.Equals(""))
            {
                List<Model.HistorialMillasModel> millas = millasController.buscarMillas(dni);
                dgvHistorialMillas.DataSource = millas;
                dgvHistorialMillas.AutoGenerateColumns = true;
                dgvHistorialMillas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgvHistorialMillas.Columns[0].Visible = false;
                dgvHistorialMillas.Columns[1].Visible = false;

                dgvHistorialMillas.Columns[2].HeaderText = "Cant. de millas";
                dgvHistorialMillas.Columns[2].ReadOnly = true;
                dgvHistorialMillas.Columns[2].Width = 100;

                dgvHistorialMillas.Columns[3].HeaderText = "Fecha de Operación";
                dgvHistorialMillas.Columns[3].ReadOnly = true;
                dgvHistorialMillas.Columns[3].Width = 100;

                dgvHistorialMillas.Columns[4].HeaderText = "Tipo de Operación";
                dgvHistorialMillas.Columns[4].ReadOnly = true;
                dgvHistorialMillas.Columns[4].Width = 100;

                dgvHistorialMillas.Columns[5].HeaderText = "Descripción";
                dgvHistorialMillas.Columns[5].ReadOnly = true;
                dgvHistorialMillas.Columns[5].Width = 200;

                double millasTotales = 0;
                foreach(Model.HistorialMillasModel hist in millas)
                {
                    if(hist.tipoOperacion.Equals(Model.TipoOperacion.Acreditacion))
                    {
                        millasTotales = millasTotales + hist.millas;
                    }
                    else
                    {
                        millasTotales = millasTotales - hist.millas;
                    }
                }

                tbMillasAcumuladas.Text = millasTotales.ToString();

            }
            else
            {
                MessageBox.Show("Debe ingresar el dni");
            }
            

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new AerolineasFRBA().Show();
        }

        private void ConsultaMillas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
