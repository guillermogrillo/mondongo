using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Controller
{
    class TarjetaCreditoController
    {
        private Dao.TarjetaCreditoDao tarjetaCreditoDao = null;

        public TarjetaCreditoController()
        {
            tarjetaCreditoDao = new Dao.TarjetaCreditoDao();
        }

        public List<Model.BeneficioTarjetaCredito> buscarBeneficiosDeLaTarjeta(int idTarjeta)
        {
            return tarjetaCreditoDao.buscarBeneficiosDeLaTarjeta(idTarjeta);

        }

        public List<Model.TarjetaCreditoModel> buscarTodasLasTarjetas()
        {
            return tarjetaCreditoDao.buscarTodasLasTarjetas();
        }
    }
}
