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
    public partial class ConfirmacionCompra : Form
    {

        private Model.CompraModel compraModel;
        private Controller.CompraController compraController;
        private Controller.TipoServicioController tipoServicioController = null;

        public ConfirmacionCompra(Model.CompraModel compraModel)
        {
            InitializeComponent();
            this.compraModel = compraModel;
            this.compraController = new Controller.CompraController();
            this.tipoServicioController = new Controller.TipoServicioController();
            gbTarjeta.Visible = false;
        }

        private void ConfirmacionCompra_Load(object sender, EventArgs e)
        {
            tbCiudadOrigen.Text = compraModel.vueloElegido.ciudadOrigen;
            tbFechaSalida.Text = compraModel.vueloElegido.fechaHoraSalida.Date.ToString();
            tbHoraSalida.Text = compraModel.vueloElegido.fechaHoraSalida.TimeOfDay.ToString();
            tbCiudadDestino.Text = compraModel.vueloElegido.ciudadDestino;
            tbFechaLlegada.Text = compraModel.vueloElegido.fechaHoraLlegadaEstimada.Date.ToString();
            tbHoraLlegadaEstimado.Text = compraModel.vueloElegido.fechaHoraLlegadaEstimada.TimeOfDay.ToString();
            tbKg.Text = compraModel.cantidadKg.ToString();
            tbPrecioEncomienda.Text = (compraModel.cantidadKg * compraModel.ruta.precioBaseKg).ToString();

            dgvPasajeros.AutoGenerateColumns = true;
            dgvPasajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPasajeros.DataSource = compraModel.clientes;
            dgvPasajeros.Columns[0].Visible = false;

            dgvPasajeros.Columns[1].HeaderText = "DNI";
            dgvPasajeros.Columns[1].ReadOnly = true;
            dgvPasajeros.Columns[1].Width = 100;

            dgvPasajeros.Columns[2].HeaderText = "Nombre";
            dgvPasajeros.Columns[2].ReadOnly = true;
            dgvPasajeros.Columns[2].Width = 140;

            dgvPasajeros.Columns[3].HeaderText = "Apellido";
            dgvPasajeros.Columns[3].ReadOnly = true;
            dgvPasajeros.Columns[3].Width = 140;

            dgvPasajeros.Columns[4].HeaderText = "Fecha Nacimiento";
            dgvPasajeros.Columns[4].ReadOnly = true;
            dgvPasajeros.Columns[4].Width = 75;
            dgvPasajeros.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";            

            dgvPasajeros.Columns[5].HeaderText = "Dirección";
            dgvPasajeros.Columns[5].ReadOnly = true;
            dgvPasajeros.Columns[5].Width = 100;

            dgvPasajeros.Columns[6].HeaderText = "Teléfono";
            dgvPasajeros.Columns[6].ReadOnly = true;
            dgvPasajeros.Columns[6].Width = 70;

            dgvPasajeros.Columns[7].HeaderText = "Mail";
            dgvPasajeros.Columns[7].ReadOnly = true;
            dgvPasajeros.Columns[7].Width = 90;

            dgvPasajeros.Columns[8].Visible = false; 

            tbPrecioPasajes.Text = (compraModel.cantidadPax * (compraModel.ruta.precioBasePasaje) + buscarCostoAdicionalPorTipoServicio()).ToString();
            tbNombrePagador.Text = compraModel.pagador.nombre;
            tbApellidoPagador.Text = compraModel.pagador.apellido;
            tbDniPagador.Text = compraModel.pagador.dni.ToString();
            Model.TipoPagoModel formaDePago = compraModel.pagador.formaPago;
            tbFormaPago.Text = formaDePago.ToString();                        
            Decimal precioTotal = Math.Round((Convert.ToDecimal(tbPrecioEncomienda.Text) + Convert.ToDecimal(tbPrecioPasajes.Text)), 2, MidpointRounding.ToEven);
            tbPrecioTotal.Text = precioTotal.ToString();
            if(compraModel.pagador.formaPago.Equals(Model.TipoPagoModel.Tarjeta))
            {
                gbTarjeta.Visible = true;
                tbTipoTarjeta.Text = compraModel.pagador.tipoTarjeta.descripcion;
                tbNumeroTarjeta.Text = compraModel.pagador.numeroTarjeta;
                int cantCuotas = compraModel.pagador.cuotas.cuotas;
                tbCuotas.Text = cantCuotas.ToString();
                Decimal precioDeCuotas = Math.Round((precioTotal / cantCuotas),2,MidpointRounding.ToEven);
                tbPrecioCuotas.Text = (precioDeCuotas).ToString();
                tbVencimientoTarjeta.Text = compraModel.pagador.vencimiento;
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new Compra.Pagador(compraModel).Show();
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
            new AerolineasFRBA().Show();
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            int pnr = registrarCompra(compraModel);                      

            this.Close();
            new FinalizarCompra(compraModel, pnr).Show();
        }

        private int registrarCompra(Model.CompraModel compraModel)
        {
            return compraController.registrarCompra(compraModel);
        }

        private int buscarCostoAdicionalPorTipoServicio()
        {
            List<Model.TipoServicioModel> TodosLosTiposDeServicio = tipoServicioController.buscarTiposServicio();
            int costoAdicional = 0;
            foreach (Model.TipoServicioModel tipoServicio in TodosLosTiposDeServicio)
            {
                if (tipoServicio.id == compraModel.ruta.tipoServicio)
                {
                    costoAdicional = tipoServicio.costoAdicional;
                    break;
                }
            }
            return costoAdicional;
        }
    }
}
