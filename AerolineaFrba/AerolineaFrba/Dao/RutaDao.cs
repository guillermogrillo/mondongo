using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    class RutaDao
    {

        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");

        public Model.RutaModel buscarRuta(int idCiudadOrigen, int idCiudadDestino)
        {
            List<Model.RutaModel> rutas = new List<Model.RutaModel>();
            Model.RutaModel ruta = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select id_ruta, codigo_ruta, id_ciudad_origen, id_ciudad_destino, id_tipo_servicio, precio_base_kg, precio_base_pasaje, horas_vuelo " +
                            "from mondongo.rutas "+
                            "where id_ciudad_origen = @idCiudadOrigen and id_ciudad_destino = @idCiudadDestino ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idCiudadOrigen", idCiudadOrigen);
                    command.Parameters.AddWithValue("@idCiudadDestino", idCiudadDestino);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var idRuta = (int)(double)reader.GetDecimal(0);
                        var codigoRuta = (int)(double)reader.GetDecimal(1);
                        var ciudadOrigen = (int)(double)reader.GetDecimal(2);                        
                        var ciudadDestino = (int)(double)reader.GetDecimal(3);
                        var tipoServicio = (int)(double)reader.GetDecimal(4);
                        var precioBasePasaje = (double)reader.GetDecimal(5);
                        var precioBaseKg = (double)reader.GetDecimal(6);
                        var horasVuelo = (int)(double)reader.GetDecimal(7);

                        ruta = new Model.RutaModel(idRuta,codigoRuta,ciudadOrigen,ciudadDestino,tipoServicio,precioBasePasaje,precioBaseKg,horasVuelo);
                        rutas.Add(ruta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }

            if(rutas.Count>0)
            {
                return rutas[0];
            }
            else
            {
                return null;
            }

            
        }



    }
}
