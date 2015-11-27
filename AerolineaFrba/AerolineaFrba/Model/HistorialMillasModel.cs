using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class HistorialMillasModel
    {

        public int idHistorial { get; set; }
        public int idCliente { get; set; }
        public double millas { get; set; }
        public DateTime fechaOperacion { get; set; }
        public Model.TipoOperacion tipoOperacion { get; set; }
        public String descripcion { get; set; }


        public HistorialMillasModel(int _idHistorial, int _idCliente, double _millas, DateTime _fechaOperacion, Model.TipoOperacion _tipoOperacion, String _descripcion)
        {
            idHistorial = _idHistorial;
            idCliente = _idCliente;
            millas = _millas;
            fechaOperacion = _fechaOperacion;
            tipoOperacion = _tipoOperacion;
            descripcion = _descripcion;
        }

        public HistorialMillasModel(int _idCliente, double _millas, DateTime _fechaOperacion, Model.TipoOperacion _tipoOperacion, String _descripcion)
        {            
            idCliente = _idCliente;
            millas = _millas;
            fechaOperacion = _fechaOperacion;
            tipoOperacion = _tipoOperacion;
            descripcion = _descripcion;
        }
    }
}
