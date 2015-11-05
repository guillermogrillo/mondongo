using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Controller
{
    class AeronaveController
    {
        private Dao.AeronaveDao _dao = null;

        public AeronaveController()
        {
            _dao = new Dao.AeronaveDao();
        }

        public List<Model.AeronaveModel> buscarAeronaves()
        {
            return _dao.buscarAeronaves();
        }

        public String darBajaAeronave(String matricula)
        {
            //Chequear viajes asignados
            _dao.eliminarAeronave(matricula);
            return "OK";
        }

        public String guardarAeronave(Model.AeronaveModel aeronave)
        {
            Model.AeronaveModel a = _dao.buscarAeronavePorMatricula(aeronave.matricula);
            if (a != null)
                return "Matricula existente";
            
            _dao.guardarAeronave(aeronave);
            return "OK";
        }

        public String actualizarAeronave(Model.AeronaveModel aeronave)
        {
            _dao.actualizarAeronave(aeronave);
            return "OK";
        }
        
        public String fueraServicioAeronave(string matricula)
        {
            //Chequear viajes asignados
            _dao.fueraServicioAeronave(matricula);
            return "OK";
        }
    }
}
