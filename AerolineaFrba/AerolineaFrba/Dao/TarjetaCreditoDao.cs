using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    class TarjetaCreditoDao
    {

        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");

        public List<Model.TarjetaCreditoModel> buscarTodasLasTarjetas()
        {
            List<Model.TarjetaCreditoModel> tarjetasCredito = new List<Model.TarjetaCreditoModel>();
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "SELECT tarjeta_credito_id, tarjeta_credito_descripcion FROM MONDONGO.TARJETA_CREDITO ";
                command = new SqlCommand(query, myConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Model.TarjetaCreditoModel tc = new Model.TarjetaCreditoModel();
                        tc.id = (int)(double)reader.GetDecimal(0);
                        tc.descripcion = reader.GetString(1);

                        tarjetasCredito.Add(tc);
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
            return tarjetasCredito;
        }


        public List<Model.BeneficioTarjetaCredito> buscarBeneficiosDeLaTarjeta(int idTarjeta)
        {
            List<Model.BeneficioTarjetaCredito> beneficios = new List<Model.BeneficioTarjetaCredito>();
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "SELECT beneficio_id, beneficio_descripcion, beneficio_cantidad_cuotas "+
                            "FROM MONDONGO.BENEFICIOS "+
                            "where beneficio_tarjeta_credito = @idTarjeta";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idTarjeta", idTarjeta);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {                        
                        var id = (int)(double)reader.GetDecimal(0);
                        var descripcion = reader.GetString(1);
                        var cuotas = (int)(double)reader.GetDecimal(2);
                        Model.BeneficioTarjetaCredito b = new Model.BeneficioTarjetaCredito(id,descripcion,cuotas);
                        beneficios.Add(b);
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
            return beneficios;

        }

    }
}
