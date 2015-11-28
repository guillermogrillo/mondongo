using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class VentaModel
    {
        public int ventaPnr { get; set; }
        public DateTime ventaFecha  { get; set; }
        public int ventaViajeId { get; set; }
        public int ventaClientePagador { get; set; }
        public int ventaTipoPago { get; set; }
        public int ventaEstado { get; set; }

        public List<Model.PasajeModel> ventaPasajes { get; set; }
        public Model.PaqueteModel ventaPaquete { get; set; }


        public VentaModel(int ventaPnr, DateTime ventaFecha, int ventaViajeId, int ventaClientePagador, int ventaTipoPago, int ventaEstado)
        {
            this.ventaPnr = ventaPnr;
            this.ventaFecha = ventaFecha;
            this.ventaViajeId = ventaViajeId;
            this.ventaClientePagador = ventaClientePagador;
            this.ventaTipoPago = ventaTipoPago;
            this.ventaEstado = ventaEstado;
        }        

    }
}
