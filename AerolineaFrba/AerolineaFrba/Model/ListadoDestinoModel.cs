using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class ListadoDestinoModel
    {

        public String nombre { get; set; }
        public int cantidad { get; set; }


        public ListadoDestinoModel(String _nombre, int _cantidad)
        {
            nombre = _nombre;
            cantidad = _cantidad;
        }

    }
}
