using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class ProductoModel
    {
        public int idProducto {get;set;}
        public int stock { get; set; }
        public String descripcion {get;set;}
        public int costoMillas{get;set;}

        public ProductoModel(int idProducto, int stock, String descripcion, int costoMillas)
        {
            this.idProducto = idProducto;
            this.stock = stock;
            this.descripcion = descripcion;
            this.costoMillas = costoMillas;
        }
    }
}
