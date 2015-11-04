using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class ClienteModel
    {
        public String dni { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String calle { get; set; }
        public int numero { get; set; }
        public int piso { get; set; }
        public String departamento { get; set; }
        public String telefono { get; set; }
        public String mail { get; set; }
        public Model.ButacaModel butaca { get; set; }
    }
}
