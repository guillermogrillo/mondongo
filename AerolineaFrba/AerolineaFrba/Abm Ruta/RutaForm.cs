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
        
        public RutaForm()
        {
            _tipoServicioDao = new Dao.TipoServicioDao();
            _ciudadController = new Controller.CiudadController();
            InitializeComponent();
        }
        public RutaForm(Model.RutaModel ruta)
        {
            _tipoServicioDao = new Dao.TipoServicioDao();
            _ciudadController = new Controller.CiudadController();
            InitializeComponent();
            cargarRuta(ruta);
        }

        private void cargarRuta(Model.RutaModel ruta)
        {
            tbCodigoRuta.Text = ruta.codigoRuta.ToString();
            tbHorasVuelo.Text = ruta.horasVuelo.ToString();
            tbPasajePrecio.Text = ruta.precioBasePasaje.ToString();
            tbPrecioKg.Text = ruta.precioBaseKg.ToString();
            cbTipoServicio.SelectedItem = getTipoServicio(ruta.tipoServicio);
            cbOrigen.SelectedItem = getCiudad(ruta.ciudadOrigen);
            cbDestino.SelectedItem = getCiudad(ruta.ciudadDestino);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTipoServicio.DataSource = _tipoServicioDao.buscarTiposServicio();
            
            List<Model.CiudadModel> ciudades = _ciudadController.buscarTodasLasCiudades();
            cbOrigen.DataSource = ciudades;
            cbDestino.DataSource = ciudades;
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
        private object getCiudad(int ciu_id)
        {
            foreach (Model.CiudadModel ciudad in (List<Model.CiudadModel>)cbOrigen.DataSource)
            {
                if (ciudad.ciudadId == ciu_id)
                    return ciudad;
            }
            return null;
        }
    }
}
