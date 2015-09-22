using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Service
{
    class LoginService
    {

        private Dao.LoginDao loginDao = null;

        public LoginService()
        {
            loginDao = new Dao.LoginDao();
        }

        public Boolean autenticar(String usuario, String contraseñaEncriptada)
        {
            return loginDao.autenticar(usuario, contraseñaEncriptada);
        }


    }
}
