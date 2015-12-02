using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class ListadoAeronavesModel
    {
        public string nombre { get; set; }
        public int cantidad { get; set; }

        public ListadoAeronavesModel()
        {

        }

        public ListadoAeronavesModel(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }
    }
}
