using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    class FabricanteDao
    {
        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");

        public List<Model.FabricanteModel> buscarFabricantes()
        {

            List<Model.FabricanteModel> fabricantes = new List<Model.FabricanteModel>();
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "SELECT id_fabricante, nombre FROM MONDONGO.FABRICANTES ";
                command = new SqlCommand(query, myConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Model.FabricanteModel fab = new Model.FabricanteModel();
                        fab.fabricanteId = (int)(double)reader.GetDecimal(0);
                        fab.nombre = reader.GetString(1);

                        fabricantes.Add(fab);
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
            return fabricantes;
        }
    }
}
