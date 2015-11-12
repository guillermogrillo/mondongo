using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AerolineaFrba.Controller
{
    class CompraController
    {
        private Dao.CompraDao _compraDao = null;
        private Dao.ClienteDao _clienteDao = null;
        private Dao.ViajeDao _viajeDao = null;

        public CompraController()
        {
            _compraDao = new Dao.CompraDao();
            _clienteDao = new Dao.ClienteDao();
            _viajeDao = new Dao.ViajeDao();
        }

        public void registrarCompra(Model.CompraModel compraModel)
        {
            int idPagador = _clienteDao.guardarPagador(compraModel.pagador);
            int pnr = _compraDao.buscarPnr();
            int idPaquete = 0;
            foreach (Model.ClienteModel cliente in compraModel.clientes)
            {
                _compraDao.guardarButacasVendidas(compraModel.vueloElegido.idViaje, cliente.butaca.tipo.ToString(), cliente.butaca.numero);
                int idCliente = _clienteDao.guardarCliente(cliente);                
                int idPasaje = 0;                
                if(compraModel.cantidadPax>0)
                {
                    idPasaje = _compraDao.guardarPasaje(idCliente, idPagador, pnr, compraModel, cliente);
                }
            }

            if (compraModel.cantidadPax > 0)
            {
                int cantidadButacasVentanilla = compraModel.butacasSeleccionadas["Ventanilla"].Count;
                int cantidadButacasPasillo = compraModel.butacasSeleccionadas["Pasillo"].Count;
                _viajeDao.descontarButacas(compraModel.vueloElegido.idViaje, cantidadButacasVentanilla, cantidadButacasPasillo);
            }

            if (compraModel.cantidadKg > 0)
            {
                idPaquete = _compraDao.guardarPaquete(pnr, idPagador, compraModel);
                _viajeDao.descontarKg(compraModel.vueloElegido.idViaje, compraModel.cantidadKg);
            }
        }

    }
}
