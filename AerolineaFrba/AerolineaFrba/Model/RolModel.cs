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
        public Boolean _rolHabilitado { get; set; }
        public List<Model.FuncionalidadModel> _rolFuncionalidades { get; set; }

        public RolModel(int rolId, String rolNombre, Boolean rolHabilitado, List<Model.FuncionalidadModel> rolFuncionalidades)
        {
            _rolId = rolId;
            _rolNombre = rolNombre;
            _rolHabilitado = rolHabilitado;
            _rolFuncionalidades = rolFuncionalidades;
        }


    }
}
