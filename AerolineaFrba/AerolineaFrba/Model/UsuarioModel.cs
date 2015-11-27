using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class UsuarioModel
    {

        public int _idUsuario {get;set;}
        public String _nombreUsuario { get; set; }
        public int _intentosFallidos { get; set; }
        public int _bloqueado { get; set; }        

        public UsuarioModel(int idUsuario, String nombreUsuario, int intentosFallidos, int bloqueado)
        {
            _idUsuario = idUsuario;
            _nombreUsuario = nombreUsuario;
            _intentosFallidos = intentosFallidos;
            _bloqueado = bloqueado;            
        }



    }
}
