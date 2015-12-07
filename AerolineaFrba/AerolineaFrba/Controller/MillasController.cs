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


        public List<Model.HistorialMillasModel> buscarMillas(int clienteId)
        {
            return millasDao.buscarMillas(clienteId);
        }

        public Boolean registrarMillas(Model.HistorialMillasModel historialMillas)
        {
            return millasDao.registroMillas(historialMillas);
        }

        public int buscarUltimoRegistroMillas()
        {
            return millasDao.buscarUltimoRegistroMillas();
        }

        public Boolean registrarCanje(int idProducto, int idCliente, int cantidad)
        {
            return millasDao.registrarCanje(idProducto, idCliente, cantidad);
        }

    }
}
