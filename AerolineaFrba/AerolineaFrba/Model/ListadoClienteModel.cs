using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class ListadoClienteModel
    {
        public int idCliente { get; set; }
        public String nombreCliente { get; set; }
        public String apellidoCliente { get; set; }
        public double cantidad { get; set; }

        public ListadoClienteModel(int idCliente, String nombreCliente, String apellidoCliente, double cantidad)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.cantidad = cantidad;
        }
    }
}
