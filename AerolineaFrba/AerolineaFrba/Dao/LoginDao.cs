using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    class LoginDao
    {

        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");

        public Boolean autenticar(String usuario, String contraseña) 
        {            
 
            Model.UsuarioModel usuarioLogin = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();                
                SqlCommand command = null;
                var query = "SELECT usuario_id, usuario_nombre, usuario_intentos_fallidos, usuario_bloqueado " +
                            "FROM MONDONGO.USUARIOS "+
                            "WHERE usuario_nombre = @nombreUsuario "+
                            "and usuario_contraseña = @contraseñaUsuario";
                using (command = new SqlCommand(query, myConnection)){
                    command.Parameters.AddWithValue("@nombreUsuario", usuario);
                    command.Parameters.AddWithValue("@contraseñaUsuario", contraseña);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var idUsuario = (int)(double)reader.GetDecimal(0);
                        var nombreUsuario = reader.GetString(1);
                        var intentosFallidos = reader.GetInt32(2);
                        var bloqueado = reader.GetInt32(3);

                        usuarioLogin = new Model.UsuarioModel(idUsuario, nombreUsuario, intentosFallidos, bloqueado);

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

            return (usuarioLogin != null);
        }

        public Boolean actualizarUsuario(Model.UsuarioModel usuario)
        {
            Boolean modificado = false;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();

                SqlCommand command = null;
                var query = "UPDATE MONDONGO.USUARIOS " +
                            "SET usuario_nombre = @usuarioNombre, usuario_intentos_fallidos = @usuarioIntentosFallidos, usuario_bloqueado = @bloqueado " +
                            "WHERE usuario_id = @usuarioId ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@usuarioId", usuario._idUsuario);
                    command.Parameters.AddWithValue("@usuarioNombre", usuario._nombreUsuario);
                    command.Parameters.AddWithValue("@usuarioIntentosFallidos", usuario._intentosFallidos);
                    command.Parameters.AddWithValue("@bloqueado", usuario._bloqueado);
                }

                var cantidadModificada = command.ExecuteNonQuery();

                modificado = Convert.ToBoolean(cantidadModificada);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
            return modificado;
        }

        public Model.UsuarioModel buscarUsuario(string nombreUsuario)
        {
            Model.UsuarioModel usuarioLogin = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "SELECT usuario_id, usuario_nombre, usuario_intentos_fallidos, usuario_bloqueado " +
                            "FROM MONDONGO.USUARIOS " +
                            "WHERE usuario_nombre = @nombreUsuario ";                            
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);                    
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var idUsuario = (int)(double)reader.GetDecimal(0);
                        var nombre = reader.GetString(1);
                        var intentosFallidos = reader.GetInt32(2);
                        var bloqueado = reader.GetInt32(3);

                        usuarioLogin = new Model.UsuarioModel(idUsuario, nombre, intentosFallidos, bloqueado);

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
            return usuarioLogin;
        }
    }
}
