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
    public partial class BusquedaVuelos : Form
    {

        private Boolean _esAdmin { get; set; }
        public Model.CiudadModel ciudadOrigen = null;
        public Model.CiudadModel ciudadDestino = null;
        Controller.RutaController rutaController = null;

        public BusquedaVuelos(Boolean esAdmin)
        {
            InitializeComponent();
            _esAdmin = esAdmin;
            dpFechaViaje.Format = DateTimePickerFormat.Custom;
            dpFechaViaje.CustomFormat = "dd/MM/yyyy";
            rutaController = new Controller.RutaController();
        }


        public Model.CiudadModel setCiudadOrigen()
        {
            return ciudadOrigen;
        }

        public void setCiudadOrigen(Model.CiudadModel ciudadModel)
        {
            ciudadOrigen = ciudadModel;
            tbCiudadOrigen.Text = ciudadOrigen.nombre;
        }

        public Model.CiudadModel getCiudadDestino()
        {
            return ciudadDestino;
        }

        public void setCiudadDestino(Model.CiudadModel ciudadModel)
        {
            ciudadDestino = ciudadModel;
            tbCiudadDestino.Text = ciudadDestino.nombre;
        }  
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu.Menu(_esAdmin).Show();
        }

        private void tbCantidadPasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }     
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                lblError.Text = "";
                Model.RutaModel ruta = rutaController.buscarRuta(ciudadOrigen.ciudadId, ciudadDestino.ciudadId);
                if (ruta != null)
                {
                    MessageBox.Show("Ruta ok");
                }
                else
                {
                    MessageBox.Show("No existen vuelos disponibles entre las ciudades seleccionadas", "Búsqueda de viajes",MessageBoxButtons.OK);            
                }
               
            }
            else
            {
                lblError.Text = "Debe ingresar todos los campos";
            }
            
        }

        private Boolean validarCampos()
        {
            Boolean retValue = false;
            if(tbCiudadOrigen.Text != "" && tbCiudadDestino.Text != "" && !dpFechaViaje.Value.Equals("") && tbCantidadPasajeros.Text != "")
            {
                retValue = true;
            }
            return retValue;
        }

        private void btnBuscarCiudadDesde_Click(object sender, EventArgs e)
        {
            Abm_Ciudad.BuscadorCiudades busquedaCiudad = new Abm_Ciudad.BuscadorCiudades(this,0);
            this.Hide();
            busquedaCiudad.Show();
        }

        private void btnCiudadHasta_Click(object sender, EventArgs e)
        {
            Abm_Ciudad.BuscadorCiudades busquedaCiudad = new Abm_Ciudad.BuscadorCiudades(this, 1);
            this.Hide();
            busquedaCiudad.Show();
        }

        private void BusquedaVuelos_Load(object sender, EventArgs e)
        {
            this.dpFechaViaje.Value = DateTime.Now;
        }
    }
}
