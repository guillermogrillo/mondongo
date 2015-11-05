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

        public Model.RutaModel buscarRuta(int idCiudadOrigen, int idCiudadDestino)
        {
            return _rutaDao.buscarRuta(idCiudadOrigen, idCiudadDestino);
        }


    }
}
