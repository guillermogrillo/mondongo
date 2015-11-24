using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class RutaModel
    {
        public int idRuta { get; set; }
        public int codigoRuta { get; set; }
        public int ciudadOrigen { get; set; }
        public int ciudadDestino { get; set; }
        public int tipoServicio { get; set; }
        public Double precioBasePasaje { get; set; }
        public Double precioBaseKg { get; set; }
        public Double horasVuelo { get; set; }
        public int estado { get; set; }

        public String nombreCiudadOrigen { get; set; }
        public String nombreCiudadDestino { get; set; }
        public String nombreTipoServicio { get; set; }

        public RutaModel() { }
        
        public RutaModel(int _idRuta, int _codigoRuta, int _ciudadOrigen, int _ciudadDestino, int _tipoServicio, Double _precioBasePasaje, 
                        Double _precioBaseKg, Double _horasVuelo, int _estado)
        {
            this.idRuta = _idRuta;
            this.codigoRuta = _codigoRuta;
            this.ciudadOrigen = _ciudadOrigen;
            this.ciudadDestino = _ciudadDestino;
            this.tipoServicio = _tipoServicio;
            this.precioBasePasaje = _precioBasePasaje;
            this.precioBaseKg = _precioBaseKg;
            this.horasVuelo = _horasVuelo;
            this.estado = _estado;
        }

        public enum RutaEstado
        {
            ACTIVA = 0,
            ELIMINADA = 1
        }
    }
}
