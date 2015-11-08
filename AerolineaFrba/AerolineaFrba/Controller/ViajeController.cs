using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AerolineaFrba.Controller
{
    class ViajeController
    {
        private Dao.ViajeDao viajeDao = null;

        public ViajeController()
        {
            viajeDao = new Dao.ViajeDao();
        }

        public List<Model.ViajeModel> buscarViajes(int idRuta, DateTime fechaViaje, int cantidadPax, int kg)
        {
            return viajeDao.buscarViajes(idRuta, fechaViaje, cantidadPax, kg);
        }

        public List<Model.ViajeModel> buscarViajes(int idRuta, String matricula, DateTime fechaSalida)
        {
            return viajeDao.buscarViajes(idRuta, matricula, fechaSalida);
        }

        public Boolean actualizarViaje(Model.ViajeModel viaje)
        {
            return viajeDao.actualizarViaje(viaje);
        }
    }
}
