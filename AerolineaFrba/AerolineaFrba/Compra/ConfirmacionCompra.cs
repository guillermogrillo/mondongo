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

        public ConfirmacionCompra(Model.CompraModel compraModel)
        {
            InitializeComponent();
            this.compraModel = compraModel;
            this.compraController = new Controller.CompraController();
            gbTarjeta.Visible = false;
        }

        private void ConfirmacionCompra_Load(object sender, EventArgs e)
        {
            tbCiudadOrigen.Text = compraModel.vueloElegido.ciudadOrigen;
            tbFechaSalida.Text = compraModel.vueloElegido.fechaSalida;
            tbHoraSalida.Text = compraModel.vueloElegido.horaSalida;
            tbCiudadDestino.Text = compraModel.vueloElegido.ciudadDestino;
            tbFechaLlegada.Text = compraModel.vueloElegido.fechaLlegadaEstimada;
            tbHoraLlegadaEstimado.Text = compraModel.vueloElegido.horaLlegadaEstimada;
            tbKg.Text = compraModel.cantidadKg.ToString();
            tbPrecioEncomienda.Text = (compraModel.cantidadKg * compraModel.ruta.precioBaseKg).ToString();
            dgvPasajeros.DataSource = compraModel.clientes;
            tbPrecioPasajes.Text = (compraModel.cantidadPax * compraModel.ruta.precioBasePasaje).ToString();
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
            new Menu.Menu().Show();
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            registrarCompra(compraModel);           
            this.Close();
            new Menu.Menu().Show();
        }

        private void registrarCompra(Model.CompraModel compraModel)
        {
            compraController.registrarCompra(compraModel);
        }
    }
}
