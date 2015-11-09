using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class PagadorModel : ClienteModel
    {

        public int formaPago { get; set; }
        public int tipoTarjeta { get; set; }
        public String numeroTarjeta { get; set; }
        public int codigoSeguridad { get; set; }

        public PagadorModel(int _formaPago, int _tipoTarjeta, String _numeroTarjeta, int _codigoSeguridad) : base()
        {
            
            formaPago = _formaPago;
            tipoTarjeta = _tipoTarjeta;
            numeroTarjeta = _numeroTarjeta;
            codigoSeguridad = _codigoSeguridad;
        }
        public PagadorModel()
        {

        }

    }
}
