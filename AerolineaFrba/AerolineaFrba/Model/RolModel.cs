using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class RolModel
    {
        public int _rolId { get; set; }
        public String _rolNombre { get; set; }
        public Estado _rolHabilitado { get; set; }

        public RolModel(int rolId, String rolNombre, Estado rolHabilitado)
        {
            _rolId = rolId;
            _rolNombre = rolNombre;
            _rolHabilitado = rolHabilitado;            
        }


    }

    public enum Estado
    {
        DESHABILITADO = 0,
        HABILITADO = 1,
        BORRADO = 2
    }
}
