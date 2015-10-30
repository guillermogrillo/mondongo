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

        public Boolean autenticar(String usuario, String contraseña) 
        {            
            var stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");
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

            return (usuarioLogin != null);
        }


    }
}
