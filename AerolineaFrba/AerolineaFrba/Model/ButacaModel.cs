using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class ButacaModel
    {
        public String tipo { get; set; }
        public int numero { get; set; }
        public int piso { get; set; }


        public ButacaModel(String _tipo, int _numero, int _piso)
        {
            tipo = _tipo;
            numero = _numero;
            piso = _piso;
        }

    }
}
