using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Controller
{
    class RolController
    {

        private Dao.RolDao _rolDao = null;

        public RolController()
        {
            _rolDao = new Dao.RolDao();
        }

        public List<Model.RolModel> buscarTodosLosRoles()
        {
            return _rolDao.buscarTodosLosRoles();
        }

        public Boolean agregarNuevoRol(String nombreDelRol)
        {
            return _rolDao.agregarNuevoRol(nombreDelRol);
        }

        public Boolean modificarRol(Model.RolModel rolModel)
        {
            return _rolDao.modificarRol(rolModel);
        }

        public List<Model.FuncionalidadModel> buscarFuncionalidadesDelRol(int rolId, Boolean faltantes)
        {
            return _rolDao.buscarFuncionalidadesDelRol(rolId, faltantes);
        }

        public Boolean agregarFuncionalidadAlRol(int funcionalidadId, int rolId)
        {
            return _rolDao.agregarFuncionalidadAlRol(funcionalidadId, rolId);
        }

        public Boolean borrarFuncionalidadDelRol(int funcionalidadId, int rolId)
        {
            return _rolDao.borrarFuncionalidadDelRol(funcionalidadId, rolId);
        }

    }
}
