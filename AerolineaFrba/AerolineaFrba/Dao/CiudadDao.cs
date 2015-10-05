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

        public List<Model.CiudadModel> buscarTodasLasCiudades()
        {
            string queryString = "select nombre from mondongo.ciudades order by nombre asc";
            var stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");
            SqlConnection myConnection = null;
            List<Model.CiudadModel> ciudades = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                command = new SqlCommand(queryString, myConnection);
                SqlDataReader reader = command.ExecuteReader();              
                Model.CiudadModel ciudad = null;
                ciudades = new List<Model.CiudadModel>();
                while (reader.Read())
                {
                    ciudad = new Model.CiudadModel(reader.GetString(0));
                    ciudades.Add(ciudad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }       
            return ciudades;
        }

    }
}
