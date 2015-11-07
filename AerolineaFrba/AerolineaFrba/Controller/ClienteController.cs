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
    }
}
