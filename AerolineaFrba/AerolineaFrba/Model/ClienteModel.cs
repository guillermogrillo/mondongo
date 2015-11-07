using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class ClienteModel
    {
        public int clienteId { get; set; }
        public int dni { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String direccion { get; set; }
        public int telefono { get; set; }
        public String mail { get; set; }
        public Model.ButacaModel butaca { get; set; }

        public ClienteModel(int _clienteId, int _clienteDni, String _clienteNombre,
            String _clienteApellido, DateTime _clienteFechaNacimiento, String _direccion,
            int _clienteTelefono, String _clienteMail)
        {
            clienteId = _clienteId;
            dni = _clienteDni;
            nombre = _clienteNombre;
            apellido = _clienteApellido;
            fechaNacimiento = _clienteFechaNacimiento;
            direccion = _direccion;            
            telefono = _clienteTelefono;
            mail = _clienteMail;
        }

        public ClienteModel(int _clienteId, int _clienteDni, String _clienteNombre,
            String _clienteApellido, DateTime _clienteFechaNacimiento, String _direccion,
            int _clienteTelefono, String _clienteMail, String _tipoButaca, int _numeroButaca, int _pisoButaca)
        {
            clienteId = _clienteId;
            dni = _clienteDni;
            nombre = _clienteNombre;
            apellido = _clienteApellido;
            fechaNacimiento = _clienteFechaNacimiento;
            direccion = _direccion;
            telefono = _clienteTelefono;
            mail = _clienteMail;
            butaca = new Model.ButacaModel(_tipoButaca, _numeroButaca, _pisoButaca);
        }

        public ClienteModel()
        {
        }
    }
}
