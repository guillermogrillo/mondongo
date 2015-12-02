using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Controller
{
    class RutaController
    {

        private Dao.RutaDao _rutaDao = null;

        public RutaController()
        {
            _rutaDao = new Dao.RutaDao();
        }

        public Model.RutaModel buscarRuta(int idCiudadOrigen, int idCiudadDestino, int idTipoServicio)
        {
            return _rutaDao.buscarRuta(idCiudadOrigen, idCiudadDestino, idTipoServicio);
        }

        public List<Model.RutaModel> buscarTodasLasRutas()
        {
            return _rutaDao.buscarTodasLasRutas();
        }        

        public void guardarRuta(Model.RutaModel ruta)
        {
            _rutaDao.guardarRuta(ruta);
        }

        public void editarRuta(Model.RutaModel ruta)
        {
            _rutaDao.editarRuta(ruta);
        }

        public void eliminarRuta(int rutaId)
        {
            _rutaDao.eliminarRuta(rutaId);
        }        

    }
}
