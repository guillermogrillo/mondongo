using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class PasajeModel
    {
        public int pasajeId { get; set; }
        public int pasajePnr { get; set; }
        public int pasajeCliente { get; set; }
        public double pasajeMonto { get; set; }
        public String pasajeTipoButaca { get; set; }
        public int pasajeNroButaca { get; set; }
        public int estado { get; set; }

        public PasajeModel(int pasajeId, int pasajePnr, int pasajeCliente, double pasajeMonto, String pasajeTipoButaca, int pasajeNroButaca, int estado)
        {
            this.pasajeId = pasajeId;
            this.pasajePnr = pasajePnr;
            this.pasajeCliente = pasajeCliente;
            this.pasajeMonto = pasajeMonto;
            this.pasajeTipoButaca = pasajeTipoButaca;
            this.pasajeNroButaca = pasajeNroButaca;
            this.estado = estado;
        }
    }
}
