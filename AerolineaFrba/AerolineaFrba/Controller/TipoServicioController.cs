using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Controller
{
    class TipoServicioController
    {

        private Dao.TipoServicioDao _tipoServicioDao = null;

        public TipoServicioController()
        {
            _tipoServicioDao = new Dao.TipoServicioDao();
        }

        public List<Model.TipoServicioModel> buscarTiposServicio()
        {
            return _tipoServicioDao.buscarTiposServicio();
        }

    }
}
