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
    public partial class NuevoPasajero : Form
    {

        Model.CompraModel compraModel = null;
        Controller.ClienteController clienteController = null;
        Controller.ViajeController viajeController = null;
        Model.ClienteModel clientePantalla = null;
        Dictionary<String, List<int>> butacasDisponibles = null;
        DateTime fechaSistema = Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings.Get("fechaSistema"));

        public NuevoPasajero(Model.CompraModel _compraModel)
        {
            InitializeComponent();
            compraModel = _compraModel;
            clienteController = new Controller.ClienteController();
            viajeController = new Controller.ViajeController();
            clientePantalla = new Model.ClienteModel();
            dpFNac.Format = DateTimePickerFormat.Custom;
            dpFNac.CustomFormat = "dd/MM/yyyy";
        }

        private void NuevoPasajero_Load(object sender, EventArgs e)
        {
            gbDatosPersonales.Enabled = false;
            gbButaca.Enabled = false;
            btnSiguiente.Enabled = false;
            butacasDisponibles = filtrarButacasNoDisponibles();          
            cbTipoButaca.DataSource = Enum.GetValues(typeof(Model.TipoButaca));            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new Compra.Pasajeros(compraModel).Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if(!tbDni.Text.Equals("")){
                gbDatosPersonales.Enabled = true;
                gbButaca.Enabled = true;
                btnSiguiente.Enabled = true;
                List<Model.ClienteModel> clientesEncontrados = clienteController.buscarClientes(tbDni.Text);
                if(clientesEncontrados.Count == 1){
                    clientePantalla = clientesEncontrados[0];
                    tbNombre.Text = clientePantalla.nombre;
                    tbApellido.Text = clientePantalla.apellido;
                    dpFNac.Value = clientePantalla.fechaNacimiento;
                    tbMail.Text = clientePantalla.mail;
                    tbTelefono.Text = clientePantalla.telefono.ToString();
                    tbDireccion.Text = clientePantalla.direccion;               
                }
            }else{
                MessageBox.Show("Ingrese el Dni");
            }
        }

        private void tbDni_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tbDni_TextChanged(object sender, EventArgs e)
        {
            limpiarPantalla();                          
            gbButaca.Enabled = false;
            gbDatosPersonales.Enabled = false;
            
        }

        private void limpiarPantalla()
        {
            tbNombre.Text = null;
            tbApellido.Text = null;
            dpFNac.Value = fechaSistema;
            tbMail.Text = null;
            tbTelefono.Text = null;
            tbDireccion.Text = null;
            epNombre.SetError(tbNombre, "");
            epApellido.SetError(tbApellido, "");
            epMail.SetError(tbMail, "");
            epTelefono.SetError(tbTelefono, "");
            epDireccion.SetError(tbDireccion, "");
            btnSiguiente.Enabled = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (validarTodosLosCampos())
            {
                Boolean existeEnLaLista = compraModel.clientes.Any(cliente => cliente.dni == clientePantalla.dni);
                if (existeEnLaLista)
                {
                    MessageBox.Show("El cliente ya ha sido agregado al viaje");
                }
                else
                {
                    clientePantalla.dni = Convert.ToInt32(tbDni.Text);
                    clientePantalla.nombre = tbNombre.Text;
                    clientePantalla.apellido = tbApellido.Text;
                    clientePantalla.fechaNacimiento = dpFNac.Value;
                    clientePantalla.direccion = tbDireccion.Text;                    
                    clientePantalla.mail = tbMail.Text;
                    clientePantalla.telefono = Convert.ToInt32(tbTelefono.Text);

                    String tipoDeButaca = cbTipoButaca.Text;
                    int numeroDeButaca = Convert.ToInt32(cbNumeroButaca.SelectedValue);
                    clientePantalla.butaca = new Model.ButacaModel((Model.TipoButaca)cbTipoButaca.SelectedValue, numeroDeButaca);

                    compraModel.butacasSeleccionadas[cbTipoButaca.Text].Add(numeroDeButaca);
                    
                    
                   
                    compraModel.clientes.Add(clientePantalla);
                    this.Close();
                    new Compra.Pasajeros(compraModel).Show();
                }
            }
        }

        private Dictionary<String, List<int>> filtrarButacasNoDisponibles()
        {
            Dictionary<String,List<int>> butacasDisponibles = viajeController.buscarButacasDisponibles(compraModel.vueloElegido);
            Dictionary<String, List<int>> butacasAsignadas = compraModel.butacasSeleccionadas;
            

            foreach (KeyValuePair<String, List<int>> entry in butacasAsignadas)
            {
                IEnumerable<int> butacasFiltradas = butacasDisponibles[entry.Key].Except(entry.Value);
                butacasDisponibles[entry.Key] = butacasFiltradas.ToList();
            }

            return butacasDisponibles;
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
                if(!IsValidEmail(tbMail.Text))
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

        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private Boolean validarTodosLosCampos()
        {
            return validarNombre() && validarApellido() && validarEmail() && validarTelefono() && validarDireccion();

        }

        private void cbTipoButaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tipoDeButaca = cbTipoButaca.Text;
            cbNumeroButaca.DataSource = butacasDisponibles[tipoDeButaca];
        }

        
   

    }
}
