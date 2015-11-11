using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Controller
{
    public class AeronaveController
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
            //Busca viajes entre la fecha de sistema y el año 8000. (porque no acepta null)
            Boolean tieneViajesAsignados = _dao.tieneViajesAsignados(matricula, DateTime.Now, DateTime.Now.AddYears(6000));
            if (tieneViajesAsignados)
                return "La aeronave tiene viajes asignados";

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

        public Boolean chequearViajesAsignados(string matricula, DateTime fechaDesde, DateTime fechaHasta)
        {
            return _dao.tieneViajesAsignados(matricula, fechaDesde, fechaHasta);
        }
        
        public void fueraServicioAeronave(string matricula, DateTime fechaDesde, DateTime fechaHasta)
        {
            _dao.fueraServicioAeronave(matricula, fechaDesde, fechaHasta);
        }

        public void bajaAeronave(string matricula, DateTime fechaDesde)
        {
            _dao.bajaAeronave(matricula, fechaDesde);
        }

        public String buscarAeronaveReemplazo(Model.AeronaveModel aeronave, DateTime fechaDesde, DateTime fechaHasta)
        {
            String matriculaNueva = _dao.buscarAeronaveReemplazo(aeronave, fechaDesde, fechaHasta);
            if (matriculaNueva == null)
                return "Atencion: No hay aeronaves disponibles para suplantar";

            return matriculaNueva;
        }
    }
}
