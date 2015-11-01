using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    class CiudadModel
    {
        public int ciudadId { get; set; }
        public String nombre { get; set; }

        public CiudadModel(int _ciudadId, String nombre)
        {
            this.ciudadId = _ciudadId;
            this.nombre = nombre;
        }
    }
}
