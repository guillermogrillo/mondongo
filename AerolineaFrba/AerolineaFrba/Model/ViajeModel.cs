using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class ViajeModel
    {
        public int idViaje { get; set; }
        public String fechaSalida { get; set; }
        public String horaSalida { get; set; }
        public String ciudadOrigen { get; set; }
        public String ciudadDestino { get; set; }
        public String tipoServicio { get; set; }
        public int cantidadButacas { get; set; }
        public int cantidadKgDisponibles { get; set; }

        public ViajeModel(int _idViaje, String _fechaSalida, String _horaSalida, String _ciudadOrigen, String _ciudadDestino, String _tipoServicio, int _cantidadButacas, int _cantidadKgDisponibles)
        {
            idViaje = _idViaje;
            fechaSalida = _fechaSalida;
            horaSalida = _horaSalida;
            ciudadOrigen = _ciudadOrigen;
            ciudadDestino = _ciudadDestino;
            tipoServicio = _tipoServicio;
            cantidadButacas = _cantidadButacas;
            cantidadKgDisponibles = _cantidadKgDisponibles;
        }
    }
}
