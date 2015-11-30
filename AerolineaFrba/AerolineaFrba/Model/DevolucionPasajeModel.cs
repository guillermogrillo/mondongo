using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class DevolucionPasajeModel
    {
        public int pasajeId { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public int dni { get; set; }
        public int nroButaca { get; set; }
        public String tipoButaca { get; set; }


        public DevolucionPasajeModel()
        {

        }

        public DevolucionPasajeModel(int pasajeId, String nombre, String apellido, int dni, int nroButaca, String tipoButaca)
        {
            this.pasajeId = pasajeId;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.nroButaca = nroButaca;
            this.tipoButaca = tipoButaca;
        }

    }
}
