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
            finally
            {
                myConnection.Close();
            }
            return clientesEncontrados;
        }

        public int guardarCliente(Model.ClienteModel cliente)
        {
            int idCliente = 0;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                String query;
                List<Model.ClienteModel> clientes = buscarClientes(cliente.dni.ToString());
                if (clientes.Count == 0)
                {
                    query = "INSERT INTO MONDONGO.CLIENTES(cliente_nombre, cliente_apellido, " +
                            "cliente_dni, cliente_direccion, cliente_telefono, cliente_mail, cliente_fecha_nacimiento,rol_id) " +
                            "values(@nombre,@apellido,@dni,@direccion,@telefono,@mail,@fechaNacimiento,@rolId)";
                            using (command = new SqlCommand(query, myConnection))
                            {
                                command.Parameters.AddWithValue("@nombre", cliente.nombre);
                                command.Parameters.AddWithValue("@apellido", cliente.apellido);
                                command.Parameters.AddWithValue("@dni", cliente.dni);
                                command.Parameters.AddWithValue("@direccion", cliente.direccion);
                                command.Parameters.AddWithValue("@telefono", cliente.telefono);
                                command.Parameters.AddWithValue("@mail", cliente.mail);
                                command.Parameters.AddWithValue("@fechaNacimiento", cliente.fechaNacimiento);
                                command.Parameters.AddWithValue("@rolId", 2);
                            }
                }
                else
                {
                    Model.ClienteModel clienteEncontrado = clientes[0];
                    query = "UPDATE MONDONGO.CLIENTES "+
                            "SET cliente_dni = @dni, "+
                            "cliente_nombre = @nombre, "+
                            "cliente_apellido = @apellido, "+
                            "cliente_direccion = @direccion, "+
                            "cliente_telefono = @telefono, "+
                            "cliente_mail = @mail, "+
                            "cliente_fecha_nacimiento = @fechaNacimiento "+
                            "where cliente_id = @id ";
                    using (command = new SqlCommand(query, myConnection))
                    {
                        command.Parameters.AddWithValue("@dni", cliente.dni);
                        command.Parameters.AddWithValue("@nombre", cliente.nombre);
                        command.Parameters.AddWithValue("@apellido", cliente.apellido);
                        command.Parameters.AddWithValue("@direccion", cliente.direccion);
                        command.Parameters.AddWithValue("@telefono", cliente.telefono);
                        command.Parameters.AddWithValue("@mail", cliente.mail);
                        command.Parameters.AddWithValue("@fechaNacimiento", cliente.fechaNacimiento);
                        command.Parameters.AddWithValue("@id", clienteEncontrado.clienteId);
                    }
                }
                var cantidad = command.ExecuteNonQuery();

                if (cantidad > 0)
                {
                    clientes = buscarClientes(cliente.dni.ToString());
                    idCliente = clientes[0].clienteId;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }


            return idCliente;
        }

        public int guardarPagador(Model.PagadorModel pagador)
        {            
            int idPagador = 0; 
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                String query;
                List<Model.ClienteModel> clientes = buscarClientes(pagador.dni.ToString());
                if (clientes.Count == 0)
                {
                    query = "INSERT INTO MONDONGO.CLIENTES(cliente_nombre, cliente_apellido, " +
                            "cliente_dni, cliente_direccion, cliente_telefono, cliente_mail, cliente_fecha_nacimiento,rol_id) " +
                            "values(@nombre, @apellido, @dni, @direccion, @telefono, @mail, @fechaNacimiento, @rolId)";
                            using (command = new SqlCommand(query, myConnection))
                            {
                                command.Parameters.AddWithValue("@nombre", pagador.nombre);
                                command.Parameters.AddWithValue("@apellido", pagador.apellido);
                                command.Parameters.AddWithValue("@dni", pagador.dni);
                                command.Parameters.AddWithValue("@direccion", pagador.direccion);
                                command.Parameters.AddWithValue("@telefono", pagador.telefono);
                                command.Parameters.AddWithValue("@mail", pagador.mail);
                                command.Parameters.AddWithValue("@fechaNacimiento", pagador.fechaNacimiento);
                                command.Parameters.AddWithValue("@rolId", 2);
                            }
                }
                else
                {
                    Model.ClienteModel cliente = clientes[0];
                    query = "UPDATE MONDONGO.CLIENTES "+
                            "SET cliente_dni = @dni, "+
                            "cliente_nombre = @nombre, "+
                            "cliente_apellido = @apellido, "+
                            "cliente_direccion = @direccion, "+
                            "cliente_telefono = @telefono, "+
                            "cliente_mail = @mail, "+
                            "cliente_fecha_nacimiento = @fechaNacimiento "+
                            "where cliente_id = @id ";
                    using (command = new SqlCommand(query, myConnection))
                    {
                        command.Parameters.AddWithValue("@dni", pagador.dni);
                        command.Parameters.AddWithValue("@nombre", pagador.nombre);
                        command.Parameters.AddWithValue("@apellido", pagador.apellido);                        
                        command.Parameters.AddWithValue("@direccion", pagador.direccion);
                        command.Parameters.AddWithValue("@telefono", pagador.telefono);
                        command.Parameters.AddWithValue("@mail", pagador.mail);
                        command.Parameters.AddWithValue("@fechaNacimiento", pagador.fechaNacimiento);
                        command.Parameters.AddWithValue("@id", cliente.clienteId);
                    }
                }                                

                var cantidad = command.ExecuteNonQuery();

                if(cantidad>0){
                    clientes = buscarClientes(pagador.dni.ToString());
                    idPagador = clientes[0].clienteId;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
            return idPagador;
        }

    }
}
