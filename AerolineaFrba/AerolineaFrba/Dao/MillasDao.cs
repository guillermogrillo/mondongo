using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    class MillasDao
    {

        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");

        public List<Model.HistorialMillasModel> buscarMillas(String dni)
        {
            List<Model.HistorialMillasModel> millas = new List<Model.HistorialMillasModel>();            
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select hm.id_historial, hm.id_cliente, hm.millas, hm.fecha_operacion, hm.tipo_operacion, hm.descripcion " +
                            "from mondongo.historial_millas hm "+
                            "inner join mondongo.clientes c on hm.id_cliente = c.cliente_id "+
                            "where c.cliente_dni = @dni "+
                            "and DATEDIFF(DAY,fecha_operacion, @fechaSistema) < 365 and DATEDIFF(DAY,fecha_operacion, @fechaSistema) > 0";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@fechaSistema", DateTime.Today);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var idHistorial = (int)(double)reader.GetDecimal(0);
                        var idCliente = (int)(double)reader.GetDecimal(1);
                        var cantMillas = (double)reader.GetDecimal(2);
                        var fechaOperacion = reader.GetDateTime(3);
                        var tipoOperacion = reader.GetInt32(4);
                        var descripcion = reader.GetString(5);
                        millas.Add(new Model.HistorialMillasModel(idHistorial, idCliente, cantMillas, fechaOperacion, (Model.TipoOperacion)tipoOperacion, descripcion));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            return millas;
        }


    }
}
