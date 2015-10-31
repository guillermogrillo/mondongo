using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    class RolModel
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

    enum Estado
    {
        Deshabilitado = 0,
        Habilitado = 1,
        Borrado = 2
    }
}
