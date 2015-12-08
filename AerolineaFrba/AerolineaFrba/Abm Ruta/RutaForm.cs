using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Abm_Ruta
{
    public partial class RutaForm : Form
    {
        private Dao.TipoServicioDao _tipoServicioDao;
        private Controller.CiudadController _ciudadController;
        private Controller.RutaController _controller;

        private Boolean isEdit;
        private int rutaId;
        
        public RutaForm()
        {
            isEdit = false;
            _tipoServicioDao = new Dao.TipoServicioDao();
            _ciudadController = new Controller.CiudadController();
            _controller = new Controller.RutaController();
            InitializeComponent();
            habilitarCombos(true);
            init();
        }
        public RutaForm(Model.RutaModel ruta)
        {
            isEdit = true;
            _tipoServicioDao = new Dao.TipoServicioDao();
            _ciudadController = new Controller.CiudadController();
            _controller = new Controller.RutaController();
            InitializeComponent();
            habilitarCombos(false);
            init();
            cargarRuta(ruta);
            rutaId = ruta.idRuta;
        }

        private void habilitarCombos(Boolean enabled)
        {
            cbOrigen.Enabled = enabled;
            cbDestino.Enabled = enabled;
            tbCodigoRuta.Enabled = enabled;
            cbTipoServicio.Enabled = enabled;
        }

        private void cargarRuta(Model.RutaModel ruta)
        {
            tbCodigoRuta.Text = ruta.codigoRuta.ToString();
            tbHorasVuelo.Text = ruta.horasVuelo.ToString();
            tbPasajePrecio.Text = ruta.precioBasePasaje.ToString();
            tbPrecioKg.Text = ruta.precioBaseKg.ToString();
            cbTipoServicio.SelectedItem = getTipoServicio(ruta.tipoServicio);
            cbOrigen.SelectedIndex = getCiudad(ruta.ciudadOrigen);
            cbDestino.SelectedIndex = getCiudad(ruta.ciudadDestino);
        }

        private void init()
        {
            cbTipoServicio.DataSource = _tipoServicioDao.buscarTiposServicio();
            
            List<Model.CiudadModel> ciudadesOrig = _ciudadController.buscarTodasLasCiudades();
            List<Model.CiudadModel> ciudadesDest = _ciudadController.buscarTodasLasCiudades();
            cbOrigen.DataSource = ciudadesOrig;
            cbDestino.DataSource = ciudadesDest;
        }

        private object getTipoServicio(int ts_id)
        {
            foreach (Model.TipoServicioModel tipoServicio in (List<Model.TipoServicioModel>)cbTipoServicio.DataSource)
            {
                if (tipoServicio.id == ts_id)
                    return tipoServicio;
            }
            return null;
        }
        private int getCiudad(int ciu_id)
        {
            int i = 0;
            foreach (Model.CiudadModel ciudad in (List<Model.CiudadModel>)cbOrigen.DataSource)
            {
                if (ciudad.ciudadId == ciu_id)
                    return i;
                i++;
            }
            return 0;
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            new Abm_Ruta.AbmRuta().Show();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            lbError.Text = "";

            if (!validarCamposObligatorios())
            {
                lbError.Text = "Debe ingresar todos los campos";
            }
            else
            {
                if (Convert.ToInt32(tbHorasVuelo.Text) == 0 || Convert.ToInt32(tbPasajePrecio.Text) == 0 || Convert.ToInt32(tbPrecioKg.Text) == 0)
                {
                    lbError.Text = "Los precios y las horas de vuelo no pueden ser cero.";
                    return;
                }

                Model.RutaModel ruta = armarRuta();

                if (ruta.horasVuelo > 24)
                {
                    lbError.Text = "Las horas de vuelo no pueden superar las 24 horas";
                    return;
                }

                if (isEdit)
                {
                    _controller.editarRuta(ruta);
                }
                else
                {
                    List<Model.RutaModel> rutasOrigDest = _controller.buscarRutasPorOrigenYDestino(ruta.ciudadOrigen, ruta.ciudadDestino);
                    if (rutasOrigDest.Count > 0)
                    {
                        List<Model.RutaModel> rutasEncontradas = buscarCodigoRuta(rutasOrigDest, ruta.codigoRuta);
                        if (rutasEncontradas != null && rutasEncontradas.Count > 0)
                        {

                            Boolean valTS = buscarTipoServicio(rutasEncontradas, ruta.tipoServicio);

                            if (valTS)
                            {
                                lbError.Text = "La ruta seleccionada ya tiene ese tipo de servicio asignado";
                            }
                            else
                            {
                                int idCiudadOrigen = (cbOrigen.SelectedValue as Model.CiudadModel).ciudadId;
                                int idCiudadDestino = (cbDestino.SelectedValue as Model.CiudadModel).ciudadId;
                                if (idCiudadOrigen != idCiudadDestino)
                                {
                                    _controller.guardarRuta(ruta);
                                    this.Close();
                                }
                                else
                                {
                                    lbError.Text = "No se puede crear una ruta con igual ciudad origen y destino";
                                }

                            }
                        }
                        else
                        {
                            lbError.Text = "Se encontró otra ruta con mismo Origen y Destino pero distinto Codigo Ruta";
                        }
                    }
                    else
                    {
                        Model.RutaModel rutaEncontrada = _controller.buscarRutaPorCodigo(ruta.codigoRuta);
                        if (rutaEncontrada != null)
                        {
                            lbError.Text = "Ya existe otra ruta con ese mismo código y distinto Origen y Destino";
                        }
                        else
                        {
                            int idCiudadOrigen = (cbOrigen.SelectedValue as Model.CiudadModel).ciudadId;
                            int idCiudadDestino = (cbDestino.SelectedValue as Model.CiudadModel).ciudadId;
                            if (idCiudadOrigen != idCiudadDestino)
                            {
                                _controller.guardarRuta(ruta);
                                this.Close();
                            }
                            else
                            {
                                lbError.Text = "No se puede crear una ruta con igual ciudad origen y destino";
                            }
                        }
                    }
                } 
            }

                       
        }

        private Boolean validarCamposObligatorios()
        {
            Boolean codigoRutaLleno = !String.IsNullOrWhiteSpace(tbCodigoRuta.Text);
            Boolean horasVueloLleno = !String.IsNullOrWhiteSpace(tbHorasVuelo.Text);
            Boolean precioPasajeLleno = !String.IsNullOrWhiteSpace(tbPasajePrecio.Text);
            Boolean precioKgLleno = !String.IsNullOrWhiteSpace(tbPrecioKg.Text);

            return codigoRutaLleno && horasVueloLleno && precioPasajeLleno && precioKgLleno;
        }

        private Boolean buscarTipoServicio(List<Model.RutaModel> rutasEncontradas, int tipoServicio)
        {
            Boolean retVal = false;
            foreach (Model.RutaModel ruta in rutasEncontradas)
            {
                if (ruta.tipoServicio == tipoServicio)
                {
                    retVal = true;
                    break;
                }
            }
            return retVal;
        }

        private List<Model.RutaModel> buscarCodigoRuta(List<Model.RutaModel> rutasOrigDest, int codigoRuta)
        {            
            List<Model.RutaModel> rutasEncontradas = new List<Model.RutaModel>();
            foreach(Model.RutaModel ruta in rutasOrigDest){
                if (ruta.codigoRuta == codigoRuta)
                {
                    rutasEncontradas.Add(ruta);                    
                }
            }

            return rutasEncontradas;
        }

        private Model.RutaModel armarRuta()
        {
            Model.RutaModel ruta = new Model.RutaModel();

            ruta.codigoRuta = Convert.ToInt32(tbCodigoRuta.Text);
            ruta.horasVuelo = Convert.ToDouble(tbHorasVuelo.Text);
            ruta.precioBasePasaje = Convert.ToDouble(tbPasajePrecio.Text);
            ruta.precioBaseKg = Convert.ToDouble(tbPrecioKg.Text);
            ruta.tipoServicio = Convert.ToInt32(((Model.TipoServicioModel)cbTipoServicio.SelectedItem).id);
            ruta.ciudadOrigen = Convert.ToInt32(((Model.CiudadModel)cbOrigen.SelectedItem).ciudadId);
            ruta.ciudadDestino = Convert.ToInt32(((Model.CiudadModel)cbDestino.SelectedItem).ciudadId);

            if (isEdit)
                ruta.idRuta = rutaId;

            return ruta;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*private void horasVuelo_onKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        */
    }
}
