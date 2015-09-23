using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    class UsuarioModel
    {

        private int _idUsuario {get;set;}
        private String _nombreUsuario { get; set; }
        private int _intentosFallidos { get; set; }
        private int _bloqueado { get; set; }
        private int _idRol { get; set; }

        public UsuarioModel(int idUsuario, String nombreUsuario, int intentosFallidos, int bloqueado, int idRol)
        {
            _idUsuario = idUsuario;
            _nombreUsuario = nombreUsuario;
            _intentosFallidos = intentosFallidos;
            _bloqueado = bloqueado;
            _idRol = idRol;
        }



    }
}
