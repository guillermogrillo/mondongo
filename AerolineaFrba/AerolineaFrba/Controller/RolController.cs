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


    }
}
