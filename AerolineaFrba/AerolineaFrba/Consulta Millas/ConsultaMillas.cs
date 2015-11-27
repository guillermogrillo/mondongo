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
        private Controller.ClienteController clienteController = null;
        private Model.ClienteModel clienteEncontrado = null;

        public ConsultaMillas()
        {
            InitializeComponent();
            millasController = new Controller.MillasController();
            clienteController = new Controller.ClienteController();
        }

        public void setClientePantalla(Model.ClienteModel cliente)
        {
            this.clienteEncontrado = cliente;
            List<Model.HistorialMillasModel> millas = millasController.buscarMillas(cliente.clienteId);
            dgvHistorialMillas.DataSource = millas;
            armarGrilla();

            double millasTotales = 0;
            foreach (Model.HistorialMillasModel hist in millas)
            {
                if (hist.tipoOperacion.Equals(Model.TipoOperacion.ACREDITACION))
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

        private void armarGrilla()
        {
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
        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String dni = tbDni.Text;

            if(!dni.Equals(""))
            {
                List<Model.ClienteModel> clientesEncontrados = clienteController.buscarClientes(dni);
                if (clientesEncontrados != null && clientesEncontrados.Count > 0)
                {
                    if(clientesEncontrados.Count == 1){

                        clienteEncontrado = clientesEncontrados[0];
                        List<Model.HistorialMillasModel> millas = millasController.buscarMillas(clienteEncontrado.clienteId);
                        dgvHistorialMillas.DataSource = millas;
                        armarGrilla();

                        double millasTotales = 0;
                        foreach (Model.HistorialMillasModel hist in millas)
                        {
                            if (hist.tipoOperacion.Equals(Model.TipoOperacion.ACREDITACION))
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
                        new Consulta_Millas.SeleccionClienteDuplicado(clientesEncontrados, this).Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes registrados con ese dni");
                }
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

        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
