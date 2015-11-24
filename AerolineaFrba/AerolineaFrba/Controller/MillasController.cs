using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Controller
{
    class MillasController
    {

        private Dao.MillasDao millasDao = null;


        public MillasController()
        {
            millasDao = new Dao.MillasDao();
        }


        public List<Model.HistorialMillasModel> buscarMillas(String dni)
        {
            return millasDao.buscarMillas(dni);
        }

    }
}
