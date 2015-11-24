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
        public String fechaLlegada { get; set; }
        public String horaLlegada { get; set; }
        public String fechaLlegadaEstimada { get; set; }
        public String horaLlegadaEstimada { get; set; }        
        public String ciudadOrigen { get; set; }
        public String ciudadDestino { get; set; }
        public String tipoServicio { get; set; }
        public String aeronaveMatricula { get; set; }
        public int cantidadButacas { get; set; }
        public int cantidadKgDisponibles { get; set; }
        public int rutaId { get; set; }
        public int cantidadButacasVentanilla {get;set;}
        public int cantidadButacasPasillo {get;set;}
        public DateTime fechaHoraSalida { get; set; }
        public DateTime fechaHoraLlegadaEstimada { get; set; }


        public ViajeModel(int _idViaje, DateTime _fechaSalida, DateTime _fechaLlegada, DateTime _fechaLlegadaEstimada, String _ciudadOrigen, String _ciudadDestino, String _tipoServicio,String _aeronaveMatricula, int _cantidadButacas, int _cantidadKgDisponibles)
        {
            idViaje = _idViaje;
            fechaSalida = _fechaSalida.ToString("dd'/'MM'/'yyyy");
            horaSalida = _fechaSalida.ToString("HH:mm:ss");
            fechaLlegada = _fechaLlegada.ToString("dd'/'MM'/'yyyy");
            horaLlegada = _fechaLlegada.ToString("HH:mm:ss");
            fechaLlegadaEstimada = _fechaLlegadaEstimada.ToString("dd'/'MM'/'yyyy");
            horaLlegadaEstimada = _fechaLlegadaEstimada.ToString("HH:mm:ss");
            ciudadOrigen = _ciudadOrigen;
            ciudadDestino = _ciudadDestino;
            tipoServicio = _tipoServicio;
            aeronaveMatricula = _aeronaveMatricula;
            cantidadButacas = _cantidadButacas;
            cantidadKgDisponibles = _cantidadKgDisponibles;
        }
        
        public ViajeModel(int rutaId, String matricula, DateTime fechaSalida, DateTime fechaLlegadaEstimada, int cantidadButacasPasillo, int cantidadButacasVentanilla, int cantidadKg)
        {
            this.rutaId = rutaId;
            this.aeronaveMatricula = matricula;
            this.fechaHoraSalida = fechaSalida;
            this.fechaHoraLlegadaEstimada = fechaLlegadaEstimada;
            this.cantidadButacasPasillo = cantidadButacasPasillo;
            this.cantidadButacasVentanilla = cantidadButacasVentanilla;
            this.cantidadKgDisponibles = cantidadKg;
        }

    }
}
