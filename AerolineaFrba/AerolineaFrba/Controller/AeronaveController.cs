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
        private Dao.ViajeDao _viajeDao = null;

        public AeronaveController()
        {
            _dao = new Dao.AeronaveDao();
            _viajeDao = new Dao.ViajeDao();
        }

        public List<Model.AeronaveModel> buscarAeronaves()
        {
            return _dao.buscarAeronaves();
        }

        public String guardarAeronave(Model.AeronaveModel aeronave)
        {
            Model.AeronaveModel a = _dao.buscarAeronavePorMatricula(aeronave.matricula);
            if (a != null)
                return "Matricula existente";
            
            _dao.guardarAeronave(aeronave);
            _dao.generarButacas(aeronave);
            return "OK";
        }

        public String actualizarAeronave(Model.AeronaveModel aeronave)
        {
            _dao.actualizarAeronave(aeronave);
            _dao.generarButacas(aeronave);
            return "OK";
        }

        public Boolean chequearViajesAsignados(string matricula, DateTime fechaDesde, DateTime fechaHasta)
        {
            return _dao.tieneViajesAsignados(matricula, fechaDesde, fechaHasta);
        }
        
        public void fueraServicioAeronave(string matricula, DateTime fechaDesde, DateTime fechaHasta)
        {
            _viajeDao.cancelarViajesAeronave(matricula, fechaDesde, fechaHasta);
            _dao.grabarBajaAeronave(matricula,fechaDesde,fechaHasta,"FS");
        }

        public void bajaAeronave(string matricula, DateTime fechaDesde)
        {
            //_dao.bajaAeronave(matricula, fechaDesde);
            _dao.grabarBajaDefinitivaAeronave(matricula, fechaDesde, "BD");
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
