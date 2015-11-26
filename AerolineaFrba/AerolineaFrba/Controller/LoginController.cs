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

        public Model.RespuestaLoginModel buscarUsuario(String nombreUsuario, String contraseña)
        {
            String contraseñaEncriptada = encriptarPassword(contraseña);

            Model.UsuarioModel usuario = _loginDao.buscarUsuario(nombreUsuario);

            if (usuario != null)
            {
                if (Convert.ToBoolean(usuario._bloqueado))
                {
                    return new Model.RespuestaLoginModel(Model.LoginRespuesta.BLOQUEADO, usuario);
                }
                else
                {
                    if (_loginDao.autenticar(nombreUsuario, contraseñaEncriptada))
                    {
                        return new Model.RespuestaLoginModel(Model.LoginRespuesta.OK, usuario);
                    }
                    else
                    {
                        usuario._intentosFallidos++;
                        if(usuario._intentosFallidos == 3)
                        {
                            usuario._bloqueado = 1;                            
                        }
                        _loginDao.actualizarUsuario(usuario);
                        return new Model.RespuestaLoginModel(Model.LoginRespuesta.CONTRASEÑA_INCORRECTA, usuario);
                    }
                }
            }
            else
            {
                return new Model.RespuestaLoginModel(Model.LoginRespuesta.NO_ENCONTRADO, usuario);
            }



            
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
