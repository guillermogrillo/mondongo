using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class ViajeRegistroLlegadaModel
    {
        public int viajeId { get; set; }
        public DateTime fechaSalida { get; set; }
        public DateTime fechaLlegadaEstimada { get; set; }
        public DateTime fechaLlegada { get; set; }

        public ViajeRegistroLlegadaModel()
        {

        }

        public ViajeRegistroLlegadaModel(int viajeId, DateTime fechaSalida, DateTime fechaLlegadaEstimada)
        {
            this.viajeId = viajeId;
            this.fechaLlegadaEstimada = fechaLlegadaEstimada;
            this.fechaSalida = fechaSalida;
        }

    }
}
