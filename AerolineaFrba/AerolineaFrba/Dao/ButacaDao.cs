using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    public class ButacaDao
    {

        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");
        DateTime fechaSistema = Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings.Get("fechaSistema"));


        public List<Model.ButacaModel> buscarButacas(String aeronaveMatricula)
        {
            List<Model.ButacaModel> butacas = new List<Model.ButacaModel>();

            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select butaca_id, butaca_tipo, butaca_nro "+
                            "from MONDONGO.butacas "+
                            "where aeronave_matricula = @aeronaveMatricula";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@aeronaveMatricula", aeronaveMatricula);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var id = (int)(double)reader.GetDecimal(0);

                        butacas.Add(new Model.ButacaModel(id));
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


            return butacas;
        }


        public void guardarButacasViaje(int idViaje, List<Model.ButacaModel> butacas)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "insert into mondongo.butacas_viaje(viaje_id, butaca_id, estado) "+
                            "values(@viajeId, @butacaId, @estado)";

                foreach (Model.ButacaModel butaca in butacas)
                {
                    using (command = new SqlCommand(query, myConnection))
                    {
                        command.Parameters.AddWithValue("@viajeId", idViaje);
                        command.Parameters.AddWithValue("@butacaId", butaca.id);
                        command.Parameters.AddWithValue("@estado", "L");
                    }
                    command.ExecuteNonQuery();
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
        }
    }
}
