using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Dao
{
    class ListadoDao
    {

        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");

        public List<Model.CiudadModel> listarDestinosConMasPasajesComprados(int año, int semestre)
        {
            List<Model.CiudadModel> destinos = new List<Model.CiudadModel>();

            return destinos;
        }

        public List<Model.CiudadModel> listarDestinosConMasAeronavesVacias(int año, int semestre)
        {
            List<Model.CiudadModel> destinos = new List<Model.CiudadModel>();

            return destinos;
        }

        public List<Model.CiudadModel> listarDestinosConMasPasajesCancelados(int año, int semestre)
        {
            List<Model.CiudadModel> destinos = new List<Model.CiudadModel>();

            return destinos;
        }

        public List<Model.ClienteModel> listarClientesConMasPuntosAcumulados(int año, int semestre)
        {
            List<Model.ClienteModel> clientes = new List<Model.ClienteModel>();

            return clientes;
        }

        public List<Model.AeronaveModel> listarAeronavesConMasDiasFueraDeServicio(int año, int semestre)
        {
            List<Model.AeronaveModel> aeronaves = new List<Model.AeronaveModel>();

            return aeronaves;
        }


    }
}
