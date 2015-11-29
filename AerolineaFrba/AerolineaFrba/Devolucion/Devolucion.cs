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
        private Controller.ViajeController viajeController = null;
        private Controller.ClienteController clienteController = null;

        private Model.DevolucionVentaModel devolucionVentaSeleccionada = null;
        private Model.DevolucionPasajeModel devolucionPasajeSeleccionado = null;
        Model.PaqueteModel paqueteDeLaVenta = null;

        private Model.ClienteModel cliente = null;

        public Devolucion()
        {
            InitializeComponent();
            compraController = new Controller.CompraController();
            viajeController = new Controller.ViajeController();
            clienteController = new Controller.ClienteController();
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

            gbPasajeros.Visible = false;
            gbPaquete.Visible = false;

            lblTextoCantidadKg.Visible = false;
            lblCantKg.Visible = false;
            lblTextoMonto.Visible = false;
            lblMonto.Visible = false;
        }

        public void setClientePantalla(Model.ClienteModel cliente)
        {
            this.cliente = cliente;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String dniPagador = tbDniPagador.Text;


            List<Model.ClienteModel> clientesEncontrados = clienteController.buscarClientes(dniPagador);

            if(clientesEncontrados.Count == 1)
            {
                
                cliente = clientesEncontrados[0];

                List<Model.DevolucionVentaModel> comprasRealizadas = compraController.buscarVentasParaDevolucion(cliente.clienteId);

                if (comprasRealizadas.Count > 0)
                {
                    dgvVentas.DataSource = comprasRealizadas;
                    dgvVentas.AutoGenerateColumns = true;
                    dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    armarGrillaVentas();
                }
                else
                {
                    MessageBox.Show("No se encontraron compras realizadas que puedan ser canceladas");
                }
            }
            else if (clientesEncontrados.Count == 0)
            {
                MessageBox.Show("No se encontró un cliente con el dni ingresado");
            }
            else
            {
                new SeleccionClienteDuplicado(clientesEncontrados, this).Show();
                this.Hide();
            }
            

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
                gbPasajeros.Visible = true;
                dgvPasajeros.DataSource = pasajesDeLaVenta;
                dgvPasajeros.AutoGenerateColumns = true;
                dgvPasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;                
                armarGrillaPasajeros();
            }
            paqueteDeLaVenta = compraController.buscarPaquetes(devolucionVentaSeleccionada.pnr);
            if (paqueteDeLaVenta != null)
            {
                gbPaquete.Visible = true;
                lblTextoCantidadKg.Visible = true;
                lblTextoMonto.Visible = true;
                lblCantKg.Visible = true;
                lblMonto.Visible = true;

                lblCantKg.Text = paqueteDeLaVenta.paqueteKg.ToString();
                lblMonto.Text = paqueteDeLaVenta.paqueteMonto.ToString();
            }

            if (paqueteDeLaVenta == null && pasajesDeLaVenta.Count == 0)
            {
                MessageBox.Show("La venta no tiene pasajes/encomiendas activos");                
                gbPasajeros.Visible = false;
                gbPaquete.Visible = false;                              
            }
        }

        private void armarGrillaPasajeros()
        {

            dgvPasajeros.Columns[0].Visible = false;

            dgvPasajeros.Columns[1].HeaderText = "Nombre";
            dgvPasajeros.Columns[1].ReadOnly = true;
            dgvPasajeros.Columns[1].Width = 125;

            dgvPasajeros.Columns[2].HeaderText = "Apellido";
            dgvPasajeros.Columns[2].ReadOnly = true;
            dgvPasajeros.Columns[2].Width = 125;

            dgvPasajeros.Columns[3].HeaderText = "DNI";
            dgvPasajeros.Columns[3].ReadOnly = true;
            dgvPasajeros.Columns[3].Width = 80;

            dgvPasajeros.Columns[4].HeaderText = "Nro. de Butaca";
            dgvPasajeros.Columns[4].ReadOnly = true;
            dgvPasajeros.Columns[4].Width = 80;

            dgvPasajeros.Columns[5].HeaderText = "Tipo de Butaca";
            dgvPasajeros.Columns[5].ReadOnly = true;
            dgvPasajeros.Columns[5].Width = 80;

        }

        private void dgvVentas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            devolucionVentaSeleccionada = (Model.DevolucionVentaModel)dgvVentas.CurrentRow.DataBoundItem;
            btnDetalle.Enabled = true;
            btnCancelarVenta.Enabled = true;
        }

        private void flpPasajeros_VisibleChanged(object sender, EventArgs e)
        {
            if(flpDevolucion.Visible){
                btnCancelarPasaje.Enabled = false;                
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
                compraController.cargarDevolucionPasaje(devolucionVentaSeleccionada.pnr, devolucionPasajeSeleccionado.pasajeId, "Devolución de pasaje por pedido del Cliente");
                MessageBox.Show("Pasaje devuelto con éxito.");

                List<Model.DevolucionPasajeModel> pasajesDeLaVenta = compraController.buscarPasajesDevolucion(devolucionVentaSeleccionada.pnr);
                
                gbPasajeros.Visible = (pasajesDeLaVenta.Count > 0);                    
               
                dgvPasajeros.DataSource = pasajesDeLaVenta;
                dgvPasajeros.AutoGenerateColumns = true;
                dgvPasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                armarGrillaPasajeros();

            }
            
        }

        private void btnCancelarPaquete_Click(object sender, EventArgs e)
        {
            if (paqueteDeLaVenta != null)
            {
                compraController.registrarDevolucionDeEncomienda(devolucionVentaSeleccionada.pnr,paqueteDeLaVenta.paqueteId);                
                viajeController.sumarKg(paqueteDeLaVenta);
                compraController.cargarDevolucionPaquete(devolucionVentaSeleccionada.pnr, paqueteDeLaVenta.paqueteId, "Devolución de paquete por pedido del Cliente");
                gbPaquete.Visible = false;
                MessageBox.Show("Paquete devuelto con éxito.");
            }
            
        }
     
    }
}
