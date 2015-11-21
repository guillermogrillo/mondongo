using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class FuncionalidadModel
    {
        public int _funcionalidadId { get; set; }
        public String _funcionalidadNombre { get; set; }
        public String _funcionalidadDescripcion { get; set; }

        public FuncionalidadModel(int funcionalidadId, String funcionalidadNombre, String funcionalidadDescripcion)
        {
            _funcionalidadId = funcionalidadId;
            _funcionalidadNombre = funcionalidadNombre;
            _funcionalidadDescripcion = funcionalidadDescripcion;
        }

    }
}
