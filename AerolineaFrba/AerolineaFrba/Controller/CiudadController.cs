using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Controller
{
    class CiudadController
    {
        private Dao.CiudadDao _ciudadDao = null;

        public CiudadController() 
        {
            _ciudadDao = new Dao.CiudadDao();
        }

        public List<Model.CiudadModel> buscarTodasLasCiudades()
        {
            return _ciudadDao.buscarTodasLasCiudades();
        }

        public List<Model.CiudadModel> buscarCiudades(String nombreCiudad)
        {
            return _ciudadDao.buscarCiudades(nombreCiudad);
        }

    }
}
