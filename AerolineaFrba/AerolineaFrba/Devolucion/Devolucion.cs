using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Devolucion
{
    public partial class Devolucion : Form
    {

        private Controller.CompraController compraController = null;

        private Model.DevolucionVentaModel devolucionVentaSeleccionada = null;
        private Model.DevolucionPasajeModel devolucionPasajeSeleccionado = null;
        Model.PaqueteModel paqueteDeLaVenta = null;

        public Devolucion()
        {
            InitializeComponent();
            compraController = new Controller.CompraController();
        }

        private void tbDniPagador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            btnDetalle.Enabled = false;
            btnCancelarVenta.Enabled = false;
            flpPaquetes.Visible = false;
            flpPasajeros.Visible = false;

            lblTextoCantidadKg.Visible = false;
            lblCantKg.Visible = false;
            lblTextoMonto.Visible = false;
            lblMonto.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String dniPagador = tbDniPagador.Text;

            List<Model.DevolucionVentaModel> comprasRealizadas = compraController.buscarVentas(dniPagador);
            dgvVentas.DataSource = comprasRealizadas;
            dgvVentas.AutoGenerateColumns = true;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            armarGrillaVentas();

        }

        private void armarGrillaVentas()
        {            

            dgvVentas.Columns[0].HeaderText = "PNR";
            dgvVentas.Columns[0].ReadOnly = true;
            dgvVentas.Columns[0].Width = 100;

            dgvVentas.Columns[1].HeaderText = "Fecha de Compra";
            dgvVentas.Columns[1].ReadOnly = true;
            dgvVentas.Columns[1].Width = 150;

            dgvVentas.Columns[2].HeaderText = "Fecha de Salida";
            dgvVentas.Columns[2].ReadOnly = true;
            dgvVentas.Columns[2].Width = 150;
            
            dgvVentas.Columns[3].HeaderText = "Forma de Pago";
            dgvVentas.Columns[3].ReadOnly = true;
            dgvVentas.Columns[3].Width = 100;
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Esta seguro de cancelar la compra cuyo PNR es " + devolucionVentaSeleccionada.pnr + "?",
                                                    "Atencion",
                                                    MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.Yes)
            {
                compraController.registrarDevolucionDeCompra(devolucionVentaSeleccionada.pnr);
                this.Close();
                new AerolineasFRBA().Show();
            }            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new AerolineasFRBA().Show();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            List<Model.DevolucionPasajeModel> pasajesDeLaVenta = compraController.buscarPasajesDevolucion(devolucionVentaSeleccionada.pnr);
            if (pasajesDeLaVenta.Count > 0)
            {
                flpPasajeros.Visible = true;
                dgvPasajeros.DataSource = pasajesDeLaVenta;
                dgvPasajeros.AutoGenerateColumns = true;
                dgvPasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;                
                armarGrillaPasajeros();
            }
            paqueteDeLaVenta = compraController.buscarPaquetes(devolucionVentaSeleccionada.pnr);
            if (paqueteDeLaVenta != null)
            {
                flpPaquetes.Visible = true;
                lblTextoCantidadKg.Visible = true;
                lblTextoMonto.Visible = true;
                lblCantKg.Visible = true;
                lblMonto.Visible = true;

                lblCantKg.Text = paqueteDeLaVenta.paqueteKg.ToString();
                lblMonto.Text = paqueteDeLaVenta.paqueteMonto.ToString();
            }
        }

        private void armarGrillaPasajeros()
        {
            
        }

        private void dgvVentas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            devolucionVentaSeleccionada = (Model.DevolucionVentaModel)dgvVentas.CurrentRow.DataBoundItem;
            btnDetalle.Enabled = true;
            btnCancelarVenta.Enabled = true;
        }

        private void flpPasajeros_VisibleChanged(object sender, EventArgs e)
        {
            if(flpPasajeros.Visible){
                btnCancelarPasaje.Enabled = false;                
            }
        }

        private void flpPaquetes_VisibleChanged(object sender, EventArgs e)
        {
            if(flpPaquetes.Visible){
                lblTextoCantidadKg.Visible = false;
                lblCantKg.Visible = false;
                lblTextoMonto.Visible = false;
                lblMonto.Visible = false;
            }            
        }

        private void dgvPasajeros_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            devolucionPasajeSeleccionado = (Model.DevolucionPasajeModel)dgvPasajeros.CurrentRow.DataBoundItem;
            btnCancelarPasaje.Enabled = true;
        }

        private void btnCancelarPasaje_Click(object sender, EventArgs e)
        {
            if (devolucionPasajeSeleccionado != null)
            {
                compraController.registrarDevolucionPasaje(devolucionVentaSeleccionada.pnr,devolucionPasajeSeleccionado.pasajeId);
            }
            
        }

        private void btnCancelarPaquete_Click(object sender, EventArgs e)
        {
            if (paqueteDeLaVenta != null)
            {
                compraController.registrarDevolucionDeEncomienda(devolucionVentaSeleccionada.pnr,paqueteDeLaVenta.paqueteId);
            }
            
        }
     
    }
}
