using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    class TipoServicioDao
    {
        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");

        public List<Model.TipoServicioModel> buscarTiposServicio()
        {

            List<Model.TipoServicioModel> tiposServicio = new List<Model.TipoServicioModel>();
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "SELECT id_tipo_servicio, tipo_servicio FROM MONDONGO.TIPOS_SERVICIO ";
                command = new SqlCommand(query, myConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Model.TipoServicioModel ts = new Model.TipoServicioModel();
                        ts.id = (int)(double)reader.GetDecimal(0);
                        ts.tipoServicio = reader.GetString(1);

                        tiposServicio.Add(ts);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            return tiposServicio;
        }
    }
}
