using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    class CiudadDao
    {

        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");

        public List<Model.CiudadModel> buscarTodasLasCiudades()
        {
            string query = "select id_ciudad, nombre from " +
                                    "mondongo.ciudades order by nombre asc";            
            SqlConnection myConnection = null;
            List<Model.CiudadModel> ciudades = new List<Model.CiudadModel>();
            Model.CiudadModel ciudad = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                command = new SqlCommand(query, myConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var ciudadId = (int)(double)reader.GetDecimal(0);
                        var ciudadNombre = reader.GetString(1);

                        ciudad = new Model.CiudadModel(ciudadId, ciudadNombre);
                        ciudades.Add(ciudad);

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
            return ciudades;
        }


        public List<Model.CiudadModel> buscarCiudades(String nombreCiudad)
        {
            string query = "select id_ciudad, nombre from " +
                                    "mondongo.ciudades "+
                                    "where nombre like @nombreCiudad " +
                                    "order by nombre asc ";
            SqlConnection myConnection = null;
            List<Model.CiudadModel> ciudades = new List<Model.CiudadModel>();
            Model.CiudadModel ciudad = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@nombreCiudad", "%"+nombreCiudad+"%");
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var ciudadId = (int)(double)reader.GetDecimal(0);
                        var ciudadNombre = reader.GetString(1);

                        ciudad = new Model.CiudadModel(ciudadId, ciudadNombre);
                        ciudades.Add(ciudad);

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
            return ciudades;
        }
    }
}
