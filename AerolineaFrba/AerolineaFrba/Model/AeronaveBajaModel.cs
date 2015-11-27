using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    class AeronaveBajaModel
    {
        public int id { get; set; }
        public String matricula { get; set; }
        public DateTime fechaProceso { get; set; }
        public DateTime fechaFueraServicio { get; set; }
        public DateTime fechaReinicioServicio { get; set; }
        public DateTime fechaBajaDefinitiva { get; set; }
    }
}
