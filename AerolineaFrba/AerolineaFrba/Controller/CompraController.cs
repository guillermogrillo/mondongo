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

        public CompraController()
        {
            _compraDao = new Dao.CompraDao();
            _clienteDao = new Dao.ClienteDao();
        }

        public void registrarCompra(Model.CompraModel compraModel)
        {
            int idPagador = _clienteDao.guardarPagador(compraModel.pagador);
            int pnr = _compraDao.buscarPnr();
            foreach (Model.ClienteModel cliente in compraModel.clientes)
            {
                _compraDao.guardarButacasVendidas(compraModel.vueloElegido.idViaje, cliente.butaca.tipo.ToString(), cliente.butaca.numero);
                int idCliente = _clienteDao.guardarCliente(cliente);
                int idPaquete = 0;
                int idPasaje = 0;
                if(compraModel.cantidadKg>0)
                {
                    idPaquete = _compraDao.guardarPaquete(pnr,idPagador,compraModel);
                }

                if(compraModel.cantidadPax>0)
                {
                    idPasaje = _compraDao.guardarPasaje(idCliente, idPagador, pnr, compraModel, cliente);
                }

            }
        }

    }
}
