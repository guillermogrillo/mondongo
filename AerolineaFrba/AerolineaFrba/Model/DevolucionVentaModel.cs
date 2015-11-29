using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class DevolucionVentaModel
    {

        public int pnr { get; set; }
        public DateTime fechaCompra { get; set; }
        public DateTime fechaSalida { get; set; }
        public String tipoDePago { get; set; }

        public DevolucionVentaModel(int pnr, DateTime fechaCompra, DateTime fechaSalida, String tipoDePago)
        {
            this.pnr = pnr;
            this.fechaCompra = fechaCompra;
            this.fechaSalida = fechaSalida;
            this.tipoDePago = tipoDePago;
        }

        public DevolucionVentaModel()
        {

        }



    }
}
