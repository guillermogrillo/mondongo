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

        public Model.RutaModel buscarRuta(int idCiudadOrigen, int idCiudadDestino, int idTipoServicio)
        {
            List<Model.RutaModel> rutas = new List<Model.RutaModel>();
            Model.RutaModel ruta = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select id_ruta, codigo_ruta, id_ciudad_origen, id_ciudad_destino, id_tipo_servicio, precio_base_kg, precio_base_pasaje, horas_vuelo, estado " +
                            "from mondongo.rutas "+
                            "where id_ciudad_origen = @idCiudadOrigen and id_ciudad_destino = @idCiudadDestino ";
                
                if(idTipoServicio!=0)
                    query = query + " and id_tipo_servicio=@idTipoServicio ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idCiudadOrigen", idCiudadOrigen);
                    command.Parameters.AddWithValue("@idCiudadDestino", idCiudadDestino);
                    if (idTipoServicio != 0) command.Parameters.AddWithValue("@idTipoServicio", idTipoServicio);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ruta = generarRuta(reader);

                        rutas.Add(ruta);
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

            if(rutas.Count>0)
            {
                return rutas[0];
            }
            else
            {
                return null;
            }    
        }

        public List<Model.RutaModel> buscarTodasLasRutas()
        {
            List<Model.RutaModel> rutas = new List<Model.RutaModel>();
            Model.RutaModel ruta = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select id_ruta, codigo_ruta, id_ciudad_origen, id_ciudad_destino, id_tipo_servicio, precio_base_kg, precio_base_pasaje, horas_vuelo, estado, " +
                            "(select nombre from MONDONGO.ciudades where id_ciudad=id_ciudad_origen) as ciudadOrigen, "+
	                        "(select nombre from MONDONGO.ciudades where id_ciudad=id_ciudad_destino) as ciudadDestino, "+
                            "(select tipo_servicio from MONDONGO.tipos_servicio ts where ts.id_tipo_servicio=r.id_tipo_servicio) "+
                            "from mondongo.rutas r "+
                            "where estado = 0 "+
                            "order by ciudadOrigen,ciudadDestino ";
                
                command = new SqlCommand(query, myConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ruta = generarRuta(reader);

                        ruta.nombreCiudadOrigen = reader.GetString(9);
                        ruta.nombreCiudadDestino = reader.GetString(10);
                        ruta.nombreTipoServicio = reader.GetString(11);

                        rutas.Add(ruta);
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
            return rutas;
        }

        private Model.RutaModel generarRuta(SqlDataReader reader)
        {
            var idRuta = (int)(double)reader.GetDecimal(0);
            var codigoRuta = (int)(double)reader.GetDecimal(1);
            var ciudadOrigen = (int)(double)reader.GetDecimal(2);
            var ciudadDestino = (int)(double)reader.GetDecimal(3);
            var tipoServicio = (int)(double)reader.GetDecimal(4);
            var precioBaseKg = (double)reader.GetDecimal(5);
            var precioBasePasaje = (double)reader.GetDecimal(6);
            var horasVuelo = (int)(double)reader.GetDecimal(7);
            var estado = (int)(double)reader.GetDecimal(8);
            
            return new Model.RutaModel(idRuta, codigoRuta, ciudadOrigen, ciudadDestino, tipoServicio, precioBasePasaje, precioBaseKg, horasVuelo, estado);
        }

        public void guardarRuta(Model.RutaModel ruta)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "insert into mondongo.rutas (codigo_ruta, id_ciudad_origen, id_ciudad_destino, id_tipo_servicio, " +
                            "                            precio_base_kg, precio_base_pasaje, horas_vuelo) "+
                            "values(@codigoRuta, @idOrigen, @idDestino, @idTipoServicio, @precioKg, @precioPas, @horasVuelo) ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@codigoRuta", ruta.codigoRuta);
                    command.Parameters.AddWithValue("@idOrigen", ruta.ciudadOrigen);
                    command.Parameters.AddWithValue("@idDestino", ruta.ciudadDestino);
                    command.Parameters.AddWithValue("@idTipoServicio", ruta.tipoServicio);
                    command.Parameters.AddWithValue("@precioKg", ruta.precioBaseKg);
                    command.Parameters.AddWithValue("@precioPas", ruta.precioBasePasaje);
                    command.Parameters.AddWithValue("@horasVuelo", ruta.horasVuelo);
                }

                command.ExecuteNonQuery();
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

        public void editarRuta(Model.RutaModel ruta)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "update mondongo.rutas " +
                            "set codigo_ruta = @codigoRuta, "+
                            "   id_ciudad_origen = @idOrigen, "+
                            "   id_ciudad_destino = @idDestino, "+
                            "   id_tipo_servicio = @idTipoServicio, "+
                            "   precio_base_kg = @precioKg, "+
                            "   precio_base_pasaje = @precioPas, "+
                            "   horas_vuelo = @horasVuelo "+
                            "where id_ruta = @idRuta ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@codigoRuta", ruta.codigoRuta);
                    command.Parameters.AddWithValue("@idOrigen", ruta.ciudadOrigen);
                    command.Parameters.AddWithValue("@idDestino", ruta.ciudadDestino);
                    command.Parameters.AddWithValue("@idTipoServicio", ruta.tipoServicio);
                    command.Parameters.AddWithValue("@precioKg", ruta.precioBaseKg);
                    command.Parameters.AddWithValue("@precioPas", ruta.precioBasePasaje);
                    command.Parameters.AddWithValue("@horasVuelo", ruta.horasVuelo);
                    command.Parameters.AddWithValue("@idRuta", ruta.idRuta);
                }

                command.ExecuteNonQuery();
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

        public void eliminarRuta(int rutaId)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "update mondongo.rutas " +
                            "set estado = @estado " +
                            "where id_ruta = @idRuta ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@estado", Model.RutaModel.RutaEstado.ELIMINADA);
                    command.Parameters.AddWithValue("@idRuta", rutaId);
                }

                command.ExecuteNonQuery();
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
