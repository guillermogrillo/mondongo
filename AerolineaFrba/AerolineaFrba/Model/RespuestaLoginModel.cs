using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class RespuestaLoginModel
    {
        public LoginRespuesta codigoRespuesta { get; set; }
        public Model.UsuarioModel usuario { get; set; }


        public RespuestaLoginModel(Model.LoginRespuesta codigoRespuesta, Model.UsuarioModel usuario)
        {
            this.codigoRespuesta = codigoRespuesta;
            this.usuario = usuario;
        }

    }

    public enum LoginRespuesta
    {
        OK = 0,
        NO_ENCONTRADO = 1,
        BLOQUEADO = 2,
        CONTRASEÑA_INCORRECTA = 3
    }
}
