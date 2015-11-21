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
            if(tbAño.Text.Equals("") || tbSemestre.Text.Equals("")){
                MessageBox.Show("Debe ingresar año y semestre");
            }
            else
            {
                int año = Convert.ToInt32(tbAño.Text);
                int semestre = Convert.ToInt32(tbSemestre.Text);

                if (rbDestinosMasComprados.Checked)
                {
                    dgvListado.DataSource = listadoController.listarDestinosMasVendidos(año, semestre);
                }
                else if (rbDestinosAeronavesVacias.Checked)
                {
                    dgvListado.DataSource = listadoController.listarDestinosConAeronavesMasVacias(año, semestre);
                }
                else if (rbDestinosPasajesCancelados.Checked)
                {
                    dgvListado.DataSource = listadoController.listarDestinosConMasPasajesCancelados(año, semestre);
                }
                else if (rbClientesPuntosAcumulados.Checked)
                {
                    dgvListado.DataSource = listadoController.listarClientes(año, semestre);
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
    }
}
