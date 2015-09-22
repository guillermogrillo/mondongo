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
            int usuarioValido = 0;
            SqlConnection myConnection = new SqlConnection("server=GUILLE\\SQLSERVER2012;" +
                                       "Trusted_Connection=yes;" +
                                       "database=GD2C2015; " +
                                       "connection timeout=30");
            try
            {
                myConnection.Open();                
                SqlCommand command = null;                
                var query = "SELECT COUNT(*) AS VALIDO FROM MONDONGO.USUARIOS WHERE nombre_usuario = @nombreUsuario and contraseña_usuario = @contraseñaUsuario";
                using (command = new SqlCommand(query, myConnection)){
                    command.Parameters.AddWithValue("@nombreUsuario", usuario);
                    command.Parameters.AddWithValue("@contraseñaUsuario", contraseña);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {                      
                        usuarioValido = reader.GetInt32(0);                      
                        Console.WriteLine("{0}", usuarioValido);
                    }
                }                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            catch (InvalidCastException ice)
            {
                MessageBox.Show("ERROR" + ice.Message);
            }

            return (usuarioValido > 0);
        }


    }
}
