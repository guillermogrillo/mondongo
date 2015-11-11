using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    class ClienteDao
    {
        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");

        public Boolean guardar(Model.ClienteModel cliente)
        {
            return true;
        }

        public Boolean modificar(Model.ClienteModel cliente)
        {
            return true;
        }

        public Boolean borrar(Model.ClienteModel cliente)
        {
            return true;
        }

        public List<Model.ClienteModel> buscarClientes(String dni)
        {
            List<Model.ClienteModel> clientesEncontrados = new List<Model.ClienteModel>();
            Model.ClienteModel cliente = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "SELECT cliente_id, cliente_dni, cliente_nombre, cliente_apellido, " +
                            "cliente_fecha_nacimiento, cliente_direccion, cliente_telefono,cliente_mail " +
                            "FROM MONDONGO.CLIENTES "+
                            "WHERE cliente_dni = @dni";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@dni", dni);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var id = (int)(double)reader.GetDecimal(0);
                        var clidni = (int)(double)reader.GetDecimal(1);
                        var nombre = reader.GetString(2);
                        var apellido = reader.GetString(3);
                        var fnac = reader.GetDateTime(4);
                        var direccion = reader.GetString(5);
                        var telefono = (int)(double)reader.GetDecimal(6);
                        var mail = reader.GetString(7);
                      

                        cliente = new Model.ClienteModel(id, clidni, nombre, apellido, fnac, direccion, telefono, mail);
                        clientesEncontrados.Add(cliente);                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            return clientesEncontrados;
        }

    }
}
