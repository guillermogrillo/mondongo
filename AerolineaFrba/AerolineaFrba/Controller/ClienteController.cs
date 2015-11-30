using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Controller
{
    public class ClienteController
    {
        private Dao.ClienteDao clienteDao = null;

        public ClienteController()
        {
            clienteDao = new Dao.ClienteDao();
        }


        public List<Model.ClienteModel> buscarClientes(String dni)
        {
            return clienteDao.buscarClientes(dni);
        }

        public List<Model.PagadorModel> buscarPagadores(String dni)
        {
            List<Model.ClienteModel> clientes = clienteDao.buscarClientes(dni);
            List<Model.PagadorModel> pagadores = new List<Model.PagadorModel>();
            Model.PagadorModel pagador = null;
            foreach (Model.ClienteModel cliente in clientes)
            {
                pagador = new Model.PagadorModel();
                pagador.nombre = cliente.nombre;
                pagador.apellido = cliente.apellido;
                pagador.clienteId = cliente.clienteId;
                pagador.dni = cliente.dni;
                pagador.fechaNacimiento = cliente.fechaNacimiento;
                pagador.direccion = cliente.direccion;
                pagador.mail = cliente.mail;
                pagador.telefono = cliente.telefono;
                pagadores.Add(pagador);
            }
            return pagadores;
        }

        public bool clienteTieneOtrosVuelos(int clienteDni, String clienteNombre, String clienteApellido, DateTime fechaSalidaPasaje, DateTime fechaLlegadaEstimadaPasaje)
        {
            return clienteDao.clienteTieneOtrosVuelos(clienteDni, clienteNombre, clienteApellido, fechaSalidaPasaje, fechaLlegadaEstimadaPasaje);
        }
    }
}
