using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Controller
{
    public class ProductosController
    {

        private Dao.ProductosDao productosDao = null;


        public ProductosController()
        {
            productosDao = new Dao.ProductosDao();
        }

        public List<Model.ProductoModel> buscarTodosLosProductos()
        {
            return productosDao.buscarTodosLosProductos();
        }
    }
}
