using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class PagadorModel : ClienteModel
    {

        public Model.TipoPagoModel formaPago { get; set; }
        public Model.TarjetaCreditoModel tipoTarjeta { get; set; }
        public Model.BeneficioTarjetaCredito cuotas { get; set; }
        public String numeroTarjeta { get; set; }
        public int codigoSeguridad { get; set; }
        public String vencimiento { get; set; }

        public PagadorModel(Model.TipoPagoModel _formaPago, Model.TarjetaCreditoModel _tipoTarjeta, Model.BeneficioTarjetaCredito _cuotas, String _numeroTarjeta, int _codigoSeguridad, String _vencimiento)
            : base()
        {
            cuotas = _cuotas;
            formaPago = _formaPago;
            tipoTarjeta = _tipoTarjeta;
            numeroTarjeta = _numeroTarjeta;
            codigoSeguridad = _codigoSeguridad;
            vencimiento = _vencimiento;
        }
        public PagadorModel()
        {

        }

    }
}
