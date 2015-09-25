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

        public CompraController()
        {
            _compraDao = new Dao.CompraDao();           
        }

        public void buscarViajes(String ciudadOrigen, String ciudadDestino, String fechaViaje, String cantidadPasajeros)
        {            
            _compraDao.buscarViajes(ciudadOrigen,ciudadDestino,fechaViaje,cantidadPasajeros);
        }


    }
}
