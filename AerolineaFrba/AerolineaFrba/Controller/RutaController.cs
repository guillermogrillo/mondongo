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
        public Model.RutaModel buscarRuta(int codigoRuta, int idCiudadOrigen, int idCiudadDestino, int idTipoServicio)
        {
            return _rutaDao.buscarRuta(codigoRuta, idCiudadOrigen, idCiudadDestino, idTipoServicio);
        }

        public Model.RutaModel buscarRutaPorCodigo(int codigoRuta)
        {
            return _rutaDao.buscarRutaPorCodigo(codigoRuta);
        }

        public List<Model.RutaModel> buscarTodasLasRutas()
        {
            return _rutaDao.buscarTodasLasRutas();
        }        

        public void guardarRuta(Model.RutaModel ruta)
        {
            int rutaId = _rutaDao.guardarRuta(ruta);
            _rutaDao.guardarRutaTipoServicio(rutaId, ruta.tipoServicio);
        }

        public void editarRuta(Model.RutaModel ruta)
        {
            _rutaDao.editarRuta(ruta);
        }

        public void eliminarRuta(int rutaId)
        {
            _rutaDao.eliminarRutaTipoServicio(rutaId);
            int cant = _rutaDao.cantRutasTipoServicio(rutaId);
            if(cant==0)
                _rutaDao.eliminarRuta(rutaId);
        }


        public List<Model.RutaModel> buscarRutasPorOrigenYDestino(int origen, int destino)
        {
            return _rutaDao.buscarRutasPorOrigenYDestino(origen,destino);
        }
    }
}
