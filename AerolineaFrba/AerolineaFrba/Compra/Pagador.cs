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
    public partial class Pagador : Form
    {
        private Model.CompraModel compraModel;
        private Model.PagadorModel pagador;
        Controller.ClienteController clienteController = null;
        Controller.TarjetaCreditoController tarjetaCreditoController = null;
        Model.TarjetaCreditoModel tarjetaSeleccionada = null;

        public Pagador(Model.CompraModel compraModel)
        {
            InitializeComponent();
            this.compraModel = compraModel;
            pagador = new Model.PagadorModel();
            clienteController = new Controller.ClienteController();
            tarjetaCreditoController = new Controller.TarjetaCreditoController();
        }

        private void Pagador_Load(object sender, EventArgs e)
        {
            gbDatosPersonales.Enabled = false;
            gbDatosTarjeta.Enabled = false;
            btnSiguiente.Enabled = false;
            cbTipoPago.DataSource = Enum.GetValues(typeof(Model.TipoPagoModel));
            cbTarjetas.Enabled = false;
            cbCuotas.Enabled = false;
            tbNumeroTarjeta.Enabled = false;
            tbVencimiento.Enabled = false;
            tbCodSeguridad.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new Compra.Pasajeros(compraModel).Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (!tbDni.Text.Equals(""))
            {
                gbDatosPersonales.Enabled = true;
                gbDatosTarjeta.Enabled = true;
                btnSiguiente.Enabled = true;
                pagador = new Model.PagadorModel();
                List<Model.PagadorModel> encontrados = clienteController.buscarPagadores(tbDni.Text);
                if (encontrados.Count == 1)
                {
                    pagador = encontrados[0];
                    tbNombre.Text = pagador.nombre;
                    tbApellido.Text = pagador.apellido;
                    dpFNac.Value = pagador.fechaNacimiento;
                    tbMail.Text = pagador.mail;
                    tbTelefono.Text = pagador.telefono.ToString();
                    tbDireccion.Text = pagador.direccion;
                }
            }else{
                MessageBox.Show("Ingrese el Dni");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(validarTodosLosCampos()){
                pagador.dni = Convert.ToInt32(tbDni.Text);
                pagador.nombre = tbNombre.Text;
                pagador.apellido = tbApellido.Text;
                pagador.fechaNacimiento = dpFNac.Value;
                pagador.mail = tbMail.Text;
                pagador.telefono = Convert.ToInt32(tbTelefono.Text);
                pagador.direccion = tbDireccion.Text;
                var formaDePago = (Model.TipoPagoModel)cbTipoPago.SelectedValue;
                pagador.formaPago = formaDePago;
                if (formaDePago.Equals(Model.TipoPagoModel.Tarjeta))
                {
                    pagador.tipoTarjeta = (Model.TarjetaCreditoModel)cbTarjetas.SelectedValue;
                    pagador.cuotas = (Model.BeneficioTarjetaCredito)cbCuotas.SelectedValue;
                    pagador.numeroTarjeta = tbNumeroTarjeta.Text;
                    pagador.codigoSeguridad = Convert.ToInt32(tbCodSeguridad.Text);
                    pagador.vencimiento = tbVencimiento.Text;
                }
                compraModel.pagador = pagador;
                this.Close();
                new Compra.ConfirmacionCompra(compraModel).Show();
            }            
        }

        private Boolean validarTodosLosCampos()
        {
            return (validarNombre() && validarApellido() && validarEmail() && validarDireccion() && validarTelefono() && validarDatosPago());
        }


        private Boolean validarDatosPago()
        {
            return validarNumeroTarjeta() && validarCodSeguridad() && validarVencimiento();
        }

        private void tbDni_TextChanged(object sender, EventArgs e)
        {
            limpiarPantalla();
            gbDatosTarjeta.Enabled = false;
            gbDatosPersonales.Enabled = false;
        }


        private void limpiarPantalla()
        {
            tbNombre.Text = null;
            tbApellido.Text = null;
            dpFNac.Value = DateTime.Now;
            tbMail.Text = null;
            tbTelefono.Text = null;
            tbDireccion.Text = null;
            tbCodSeguridad.Text = null;
            tbNumeroTarjeta.Text = null;
            tbVencimiento.Text = null;            
            epNombre.SetError(tbNombre, "");
            epApellido.SetError(tbApellido, "");
            epMail.SetError(tbMail, "");
            epTelefono.SetError(tbTelefono, "");
            epDireccion.SetError(tbDireccion, "");
            epCodSeguridad.SetError(tbCodSeguridad, "");
            epNroTarjeta.SetError(tbNumeroTarjeta, "");
            epVencimiento.SetError(tbVencimiento, "");
            btnSiguiente.Enabled = false;
        }
        private Boolean validarNombre()
        {
            Boolean bNombre = true;
            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                epNombre.SetError(tbNombre, "Campo Obligatorio");
                bNombre = false;
            }
            else
            {
                epNombre.SetError(tbNombre, "");
            }

            return bNombre;
        }

        private Boolean validarApellido()
        {
            Boolean bApellido = true;
            if (string.IsNullOrWhiteSpace(tbApellido.Text))
            {
                epApellido.SetError(tbApellido, "Campo Obligatorio");
                bApellido = false;
            }
            else
            {
                epApellido.SetError(tbApellido, "");
            }

            return bApellido;
        }

        private Boolean validarEmail()
        {
            Boolean bEmail = true;
            if (string.IsNullOrWhiteSpace(tbMail.Text))
            {
                epMail.SetError(tbMail, "Campo Obligatorio");
                bEmail = false;
            }
            else
            {
                if (!IsValidEmail(tbMail.Text))
                {
                    epMail.SetError(tbMail, "Formato de mail incorrecto");
                    bEmail = false;
                }
                else
                {
                    epMail.SetError(tbMail, "");
                }
            }

            return bEmail;
        }

        private Boolean validarTelefono()
        {
            Boolean bTelefono = true;
            if (string.IsNullOrWhiteSpace(tbTelefono.Text))
            {
                epTelefono.SetError(tbTelefono, "Campo Obligatorio");
                bTelefono = false;
            }
            else
            {
                epTelefono.SetError(tbTelefono, "");
            }

            return bTelefono;
        }

        private Boolean validarDireccion()
        {
            Boolean bDireccion = true;
            if (string.IsNullOrWhiteSpace(tbDireccion.Text))
            {
                epDireccion.SetError(tbDireccion, "Campo Obligatorio");
                bDireccion = false;
            }
            else
            {
                epDireccion.SetError(tbDireccion, "");
            }

            return bDireccion;
        }

        private Boolean validarNumeroTarjeta()
        {
            Boolean bDireccion = true;
            var formaDePago = (Model.TipoPagoModel)cbTipoPago.SelectedValue;
            if (formaDePago.Equals(Model.TipoPagoModel.Tarjeta))
            {
                if (string.IsNullOrWhiteSpace(tbDireccion.Text))
                {
                    epDireccion.SetError(tbDireccion, "Campo Obligatorio");
                    bDireccion = false;
                }
                else
                {
                    epDireccion.SetError(tbDireccion, "");
                }
            }
            return bDireccion;
        }

        private Boolean validarVencimiento()
        {
            Boolean bVencimiento = true;
            var formaDePago = (Model.TipoPagoModel)cbTipoPago.SelectedValue;
            if (formaDePago.Equals(Model.TipoPagoModel.Tarjeta))
            {
                if (string.IsNullOrWhiteSpace(tbVencimiento.Text))
                {
                    epVencimiento.SetError(tbVencimiento, "Campo Obligatorio");
                    bVencimiento = false;
                }
                else
                {
                    epVencimiento.SetError(tbVencimiento, "");
                }
            }
            return bVencimiento;
        }

        private Boolean validarCodSeguridad()
        {
            Boolean bCodSeguridad = true;
            var formaDePago = (Model.TipoPagoModel)cbTipoPago.SelectedValue;
            if (formaDePago.Equals(Model.TipoPagoModel.Tarjeta))
            {
                if (string.IsNullOrWhiteSpace(tbCodSeguridad.Text))
                {
                    epCodSeguridad.SetError(tbCodSeguridad, "Campo Obligatorio");
                    bCodSeguridad = false;
                }
                else
                {
                    epCodSeguridad.SetError(tbCodSeguridad, "");
                }
            }
            return bCodSeguridad;
        }

        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {
            validarNombre();
        }

        private void tbApellido_Validating(object sender, CancelEventArgs e)
        {
            validarApellido();
        }

        private void tbMail_Validating(object sender, CancelEventArgs e)
        {
            validarEmail();
        }

        private void tbTelefono_Validating(object sender, CancelEventArgs e)
        {
            validarTelefono();
        }

        private void tbDireccion_Validating(object sender, CancelEventArgs e)
        {
            validarDireccion();
        }

        private void tbNumeroTarjeta_Validating(object sender, CancelEventArgs e)
        {
            validarNumeroTarjeta();
        }

        private void tbVencimiento_Validating(object sender, CancelEventArgs e)
        {
            validarVencimiento();
        }

        private void tbCodSeguridad_Validating(object sender, CancelEventArgs e)
        {
            validarCodSeguridad();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCodSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbVencimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbNumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean esTarjeta = cbTipoPago.SelectedItem.Equals(Model.TipoPagoModel.Tarjeta);            
            cbTarjetas.Enabled = esTarjeta;
            cbCuotas.Enabled = esTarjeta;
            tbCodSeguridad.Enabled = esTarjeta;
            tbNumeroTarjeta.Enabled = esTarjeta;
            tbVencimiento.Enabled = esTarjeta;            
            tbCodSeguridad.Text = null;
            tbNumeroTarjeta.Text = null;
            tbVencimiento.Text = null;            
            cbTarjetas.DataSource = tarjetaCreditoController.buscarTodasLasTarjetas();
            cbTarjetas.DisplayMember = "descripcion";
        }

        private void cbTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tarjetaSeleccionada = cbTarjetas.SelectedItem as Model.TarjetaCreditoModel;
            cbCuotas.DataSource = tarjetaCreditoController.buscarBeneficiosDeLaTarjeta(tarjetaSeleccionada.id);
            cbCuotas.DisplayMember = "cuotas";
        }

        private void cbCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

    }
}
