using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Controller
{
    class ListadoController
    {

        private Dao.ListadoDao _listadoDao = null;

        public ListadoController()
        {
            _listadoDao = new Dao.ListadoDao();
        }

        public List<Model.ListadoDestinoModel> listarDestinosMasVendidos(int año, int semestre)
        {
            return _listadoDao.listarDestinosMasVendidos(año, semestre);
        }

        public List<Model.ListadoDestinoModel> listarDestinosConMasPasajesCancelados(int año, int semestre)
        {
            return _listadoDao.listarDestinosConMasPasajesCancelados(año, semestre);
        }

        public List<Model.ListadoDestinoModel> listarDestinosConAeronavesMasVacias(int año, int semestre)
        {
            return _listadoDao.listarDestinosConAeronavesMasVacias(año, semestre);
        }

        public List<Model.ListadoClienteModel> listarClientes(int año, int semestre)
        {
            return _listadoDao.listarClientes(año, semestre);
        }

        public List<Model.ListadoAeronavesModel> listarAeronaves(int año, int semestre)
        {
            return _listadoDao.listarAeronaves(año, semestre);
        }
        
    }
}
