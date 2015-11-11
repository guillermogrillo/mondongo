using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class BeneficioTarjetaCredito
    {
        public int id { get; set; }
        public String descripcion { get; set; }
        public int cuotas { get; set; }

        public BeneficioTarjetaCredito(int id, String descripcion, int cuotas)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.cuotas = cuotas;
        }
    }
}
