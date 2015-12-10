using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Controller
{
    class ButacaController
    {

        private Dao.ButacaDao butacaDao = null;

        public ButacaController() 
        {
            butacaDao = new Dao.ButacaDao();
        }

        public List<Model.ButacaModel> buscarButacas(String aeronaveMatricula)
        {
            return butacaDao.buscarButacas(aeronaveMatricula);
        }

        public void guardarButacasViaje(int idViaje, List<Model.ButacaModel> butacas)
        {
            butacaDao.guardarButacasViaje(idViaje, butacas);
        }

        public void borrarButacasViaje(int viajeId)
        {
            butacaDao.borrarButacasViaje(viajeId);
        }
    }
}
