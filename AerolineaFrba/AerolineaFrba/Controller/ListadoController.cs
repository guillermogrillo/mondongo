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

        public List<Model.CiudadModel> listarDestinosConMasPasajesComprados(int año, int semestre)
        {
            return _listadoDao.listarDestinosConMasPasajesComprados(año, semestre);
        }

        public List<Model.CiudadModel> listarDestinosConMasAeronavesVacias(int año, int semestre)
        {
            return _listadoDao.listarDestinosConMasAeronavesVacias(año, semestre);
        }

        public List<Model.CiudadModel> listarDestinosConMasPasajesCancelados(int año, int semestre)
        {
            return _listadoDao.listarDestinosConMasPasajesCancelados(año, semestre);
        }

        public List<Model.ClienteModel> listarClientesConMasPuntosAcumulados(int año, int semestre)
        {
            return _listadoDao.listarClientesConMasPuntosAcumulados(año, semestre);
        }

        public List<Model.AeronaveModel> listarAeronavesConMasDiasFueraDeServicio(int año, int semestre)
        {
            return _listadoDao.listarAeronavesConMasDiasFueraDeServicio(año, semestre);
        }
        
    }
}
