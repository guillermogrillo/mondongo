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
        public Model.CiudadModel ciudadOrigen = null;
        public Model.CiudadModel ciudadDestino = null;
        Controller.RutaController rutaController = null;
        Controller.ViajeController viajeController = null;
        public List<Model.ViajeModel> vuelosEncontrados = null;
        public Model.CompraModel compraModel = null;

        public BusquedaVuelos()
        {
            InitializeComponent();
            dpFechaViaje.Format = DateTimePickerFormat.Custom;
            dpFechaViaje.CustomFormat = "dd/MM/yyyy";
            rutaController = new Controller.RutaController();
            viajeController = new Controller.ViajeController();
            tbCantidadPasajeros.Text = Convert.ToString(0);
            tbKg.Text = Convert.ToString(0);
            compraModel = new Model.CompraModel();
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
            this.Close();
            new Menu.Menu().Show();
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
                Model.RutaModel ruta = rutaController.buscarRuta(ciudadOrigen.ciudadId, ciudadDestino.ciudadId, 0);
                if (ruta != null)
                {
                    int cantidadDePasajeros = 0;
                    int kg = 0;
                    if(tbCantidadPasajeros.Text != null && tbCantidadPasajeros.Text != ""){
                        cantidadDePasajeros =   Convert.ToInt32(tbCantidadPasajeros.Text);
                    }
                    if(cbEncomienda.Checked && tbKg != null && tbKg.Text != ""){
                        kg = Convert.ToInt32(tbKg.Text);
                    } 
  
                    if(cantidadDePasajeros == 0 && kg == 0)
                    {
                        MessageBox.Show("Debe ingresar al menos un pasajero o datos de encomienda.", "Búsqueda de viajes", MessageBoxButtons.OK);
                    }
                    else
                    {
                        vuelosEncontrados = viajeController.buscarViajes(ruta.idRuta, dpFechaViaje.Value, cantidadDePasajeros, kg);
                        if (vuelosEncontrados.Count > 0)
                        {
                            this.Close();
                            compraModel.cantidadKg = kg;
                            compraModel.cantidadPax = cantidadDePasajeros;
                            compraModel.ruta = ruta;
                            compraModel.fechaSalida = dpFechaViaje.Value;
                            compraModel.vuelos = vuelosEncontrados;
                            new Compra.VuelosEncontrados(compraModel).Show();
                        }
                        else
                        {
                            MessageBox.Show("No existe ningun vuelo para los parámetros ingresados.", "Búsqueda de viajes",MessageBoxButtons.OK);            
                        }                        
                    }                                     
                }
                else
                {
                    MessageBox.Show("No existe ningun vuelo entre las ciudades pedidas.", "Búsqueda de viajes",MessageBoxButtons.OK);            
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
            tbKg.Enabled = false;
            btnBuscarCiudadDesde.Focus();
        }

        private void cbEncomienda_CheckedChanged(object sender, EventArgs e)
        {
            tbKg.Enabled = cbEncomienda.Checked;
        }

        private void tbKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
