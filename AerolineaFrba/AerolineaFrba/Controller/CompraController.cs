using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AerolineaFrba.Controller
{
    public class CompraController
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

        public int registrarCompra(Model.CompraModel compraModel)
        {
            int idPagador = _clienteDao.guardarPagador(compraModel.pagador);
            int pnr = _compraDao.buscarPnr();
            _compraDao.guardarVenta(pnr, idPagador, compraModel);
            if (compraModel.cantidadPax > 0)
            {
                foreach (Model.ClienteModel cliente in compraModel.clientes)
                {                
                    int idCliente = _clienteDao.guardarCliente(cliente);
                    _compraDao.guardarPasaje(pnr, idCliente, compraModel, cliente);
                }                

            }          

            if (compraModel.cantidadKg > 0)
            {
                _compraDao.guardarPaquete(pnr, compraModel);
                _viajeDao.descontarKg(compraModel.vueloElegido.idViaje, compraModel.cantidadKg);
            }

            return pnr;
        }


        public List<Model.VentaModel> buscarVentas(int viajeId)
        {
            return _compraDao.buscarVentas(viajeId);
        }

        public List<Model.DevolucionVentaModel> buscarVentasParaDevolucion(int idPagador)
        {
            return _compraDao.buscarVentasParaDevolucion(idPagador);
        }

        public List<Model.PasajeModel> buscarPasajes(int pnr)
        {
            return _compraDao.buscarPasajes(pnr);
        }

        public Model.PaqueteModel buscarPaquetes(int pnr)
        {
            return _compraDao.buscarPaquetes(pnr);
        }

        public void registrarDevolucionDeCompra(int pnr)
        {
            _compraDao.registrarDevolucionDeCompra(pnr);

            List<Model.PasajeModel> pasajesDeEsaCompra = this.buscarPasajes(pnr);

            foreach (Model.PasajeModel pasaje in pasajesDeEsaCompra)
            {

                this.cargarDevolucionPasaje(pnr, pasaje.pasajeId, "Devolución de pasaje por pedido del cliente");

            }

            Model.PaqueteModel paqueteDeLaCompra = this.buscarPaquetes(pnr);

            if(paqueteDeLaCompra != null){

                this.cargarDevolucionPaquete(pnr, paqueteDeLaCompra.paqueteId, "Devolución de paquete por pedido del Cliente");

            }

        }

        public int cargarDevolucionPasaje(int ventaPnr, int idPasaje, String motivo)
        {
            int codDevolucion = _compraDao.generarCodigoDevolucion();
            _compraDao.cargarDevolucionPasaje(ventaPnr, idPasaje, motivo, codDevolucion);
            return codDevolucion;
        }

        public int cargarDevolucionPaquete(int ventaPnr, int idPasaje, String motivo)
        {
            int codDevolucion = _compraDao.generarCodigoDevolucion();
            _compraDao.cargarDevolucionPaquete(ventaPnr, idPasaje, motivo, codDevolucion);
            return codDevolucion;
        }

        public List<Model.DevolucionPasajeModel> buscarPasajesDevolucion(int pnr)
        {
            return _compraDao.buscarPasajesDevolucion(pnr);
        }

        public void registrarDevolucionDeEncomienda(int pnr, int paqueteId)
        {
            _compraDao.registrarDevolucionDeEncomienda(paqueteId);            
        }

        public void registrarDevolucionPasaje(int pnr,int pasajeId)
        {
            _compraDao.registrarDevolucionPasaje(pasajeId);
        }
    }
}
