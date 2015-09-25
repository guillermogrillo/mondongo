using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Controller
{
    class LoginController
    {

        private Dao.LoginDao _loginDao = null;

        public LoginController()
        {
            _loginDao = new Dao.LoginDao();
        }

        public Boolean autenticar(String usuario, String contraseña)
        {
            String contraseñaEncriptada = encriptarPassword(contraseña);
            return _loginDao.autenticar(usuario, contraseñaEncriptada);
        }


        private String encriptarPassword(String contraseña)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(contraseña);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }


    }
}
