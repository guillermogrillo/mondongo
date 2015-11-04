using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class CompraModel
    {
        public Model.RutaModel ruta { get; set; }
        public DateTime fechaSalida { get; set; }
        public int cantidadPax { get; set; }
        public int cantidadKg { get; set; }
        public List<Model.ViajeModel> vuelos { get; set; }
        public Model.ViajeModel vueloElegido { get; set; }
        public List<Model.ClienteModel> clientes { get; set; }
        public Model.PagadorModel pagador { get; set; }
        
    }
}
