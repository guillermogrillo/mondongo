using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Listado_Estadistico
{
    public partial class ListadosEstadisticos : Form
    {


        private Controller.ListadoController listadoController = null;

        public ListadosEstadisticos()
        {
            InitializeComponent();
            listadoController = new Controller.ListadoController();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(tbAño.Text.Equals("")){
                MessageBox.Show("Debe ingresar año y semestre");
            }
            else
            {
                int año = Convert.ToInt32(tbAño.Text);
                int semestre = Convert.ToInt32(cbSemestre.SelectedValue);

                if (rbDestinosMasComprados.Checked)
                {
                    dgvListado.DataSource = listadoController.listarDestinosMasVendidos(año, semestre);
                    dgvListado.Columns[0].HeaderText = "Destino";
                    dgvListado.Columns[0].ReadOnly = true;
                    dgvListado.Columns[0].Width = 200;

                    dgvListado.Columns[1].HeaderText = "Cantidad";
                    dgvListado.Columns[1].ReadOnly = true;
                    dgvListado.Columns[1].Width = 50;
                }
                else if (rbDestinosAeronavesVacias.Checked)
                {
                    dgvListado.DataSource = listadoController.listarDestinosConAeronavesMasVacias(año, semestre);
                    dgvListado.Columns[0].HeaderText = "Destino";
                    dgvListado.Columns[0].ReadOnly = true;
                    dgvListado.Columns[0].Width = 200;

                    dgvListado.Columns[1].HeaderText = "Cantidad";
                    dgvListado.Columns[1].ReadOnly = true;
                    dgvListado.Columns[1].Width = 50;
                }
                else if (rbDestinosPasajesCancelados.Checked)
                {
                    dgvListado.DataSource = listadoController.listarDestinosConMasPasajesCancelados(año, semestre);
                    dgvListado.Columns[0].HeaderText = "Destino";
                    dgvListado.Columns[0].ReadOnly = true;
                    dgvListado.Columns[0].Width = 200;

                    dgvListado.Columns[1].HeaderText = "Cantidad";
                    dgvListado.Columns[1].ReadOnly = true;
                    dgvListado.Columns[1].Width = 50;
                }
                else if (rbClientesPuntosAcumulados.Checked)
                {
                    dgvListado.DataSource = listadoController.listarClientes(año, semestre);
                    dgvListado.Columns[0].Visible = false;

                    dgvListado.Columns[1].HeaderText = "Nombre";
                    dgvListado.Columns[1].ReadOnly = true;
                    dgvListado.Columns[1].Width = 100;

                    dgvListado.Columns[2].HeaderText = "Apellido";
                    dgvListado.Columns[2].ReadOnly = true;
                    dgvListado.Columns[2].Width = 100;

                    dgvListado.Columns[3].HeaderText = "Cantidad";
                    dgvListado.Columns[3].ReadOnly = true;
                    dgvListado.Columns[3].Width = 50;
                }
                else if (rbAeronavesFueraServicio.Checked)
                {
                    dgvListado.DataSource = listadoController.listarAeronaves(año, semestre);
                }
            }
                
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new AerolineasFRBA().Show();
        }

        private void tbAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSemestre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ListadosEstadisticos_Load(object sender, EventArgs e)
        {
            List<int> semestres = new List<int>();
            semestres.Add(1);
            semestres.Add(2);
            cbSemestre.DataSource = semestres;
            cbSemestre.SelectedIndex = 0;
        }
    }
}
