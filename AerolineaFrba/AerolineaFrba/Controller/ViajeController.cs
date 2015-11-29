using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AerolineaFrba.Controller
{
    public class ViajeController
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

        public Dictionary<String, List<int>> buscarButacasDisponibles(Model.ViajeModel viajeModel)
        {
            return viajeDao.buscarButacasDisponibles(viajeModel);
        }

        public Boolean descontarButacas(int viajeId, int cantidadVentanilla, int cantidadPasillo)
        {
            return viajeDao.descontarButacas(viajeId, cantidadVentanilla, cantidadPasillo);
        }

        public Boolean descontarKg(int viajeId, int kg)
        {
            return viajeDao.descontarKg(viajeId, kg);
        }

        public Boolean sumarKg(Model.PaqueteModel paquete)
        {
            return viajeDao.sumarKg(paquete);
        }

        public Boolean guardarViaje(Model.ViajeModel viaje, Model.RutaModel ruta, Model.AeronaveModel aeronave)
        {
            return viajeDao.guardarViaje(viaje,ruta,aeronave);
        }

        public List<Model.PasajeModel> pasajesParaDevolucion(String matricula, DateTime fechaDesde, DateTime fechaHasta)
        {
            return viajeDao.pasajesParaDevolucion(matricula, fechaDesde, fechaHasta);
        }

        public List<Model.PaqueteModel> paquetesParaDevolucion(String matricula, DateTime fechaDesde, DateTime fechaHasta)
        {
            return viajeDao.paquetesParaDevolucion(matricula, fechaDesde, fechaHasta);
        }
    }
}
