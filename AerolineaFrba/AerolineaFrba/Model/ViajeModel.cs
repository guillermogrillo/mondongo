using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    class ViajeModel
    {
        public int viajeId { get; set; }
        public int rutaId { get; set; }
        public int aeronaveMatricula { get; set; }
        public DateTime fechaSalida { get; set; }
        public DateTime fechaLlegadaEstimada { get; set; }
        public DateTime fechaLlegada { get; set; }
    }
}
