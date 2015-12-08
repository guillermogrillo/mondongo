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
                var query = "select r.id_ruta, codigo_ruta, id_ciudad_origen, id_ciudad_destino, rts.id_tipo_servicio, precio_base_kg, precio_base_pasaje, horas_vuelo, estado " +
                            "from mondongo.rutas r, MONDONGO.ruta_tipo_servicio rts " +
                            "where r.id_ruta=rts.id_ruta "+
                            "   and id_ciudad_origen = @idCiudadOrigen and id_ciudad_destino = @idCiudadDestino ";
                
                if(idTipoServicio!=0)
                    query = query + " and rts.id_tipo_servicio=@idTipoServicio ";

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

        public Model.RutaModel buscarRuta(int codigoRuta, int idCiudadOrigen, int idCiudadDestino, int idTipoServicio)
        {
            List<Model.RutaModel> rutas = new List<Model.RutaModel>();
            Model.RutaModel ruta = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select r.id_ruta, codigo_ruta, id_ciudad_origen, id_ciudad_destino, rts.id_tipo_servicio, precio_base_kg, precio_base_pasaje, horas_vuelo, estado " +
                            "from mondongo.rutas r, MONDONGO.ruta_tipo_servicio rts " +
                            "where r.id_ruta=rts.id_ruta " +
                            "   and id_ciudad_origen = @idCiudadOrigen and id_ciudad_destino = @idCiudadDestino and codigo_ruta=@codigoRuta ";

                if (idTipoServicio != 0)
                    query = query + " and rts.id_tipo_servicio=@idTipoServicio ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idCiudadOrigen", idCiudadOrigen);
                    command.Parameters.AddWithValue("@idCiudadDestino", idCiudadDestino);
                    command.Parameters.AddWithValue("@codigoRuta", codigoRuta);
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

            if (rutas.Count > 0)
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
                var query = "select r.id_ruta, codigo_ruta, id_ciudad_origen, id_ciudad_destino, id_tipo_servicio, precio_base_kg, precio_base_pasaje, horas_vuelo, estado, " +
                            "(select nombre from MONDONGO.ciudades where id_ciudad=id_ciudad_origen) as ciudadOrigen, "+
	                        "(select nombre from MONDONGO.ciudades where id_ciudad=id_ciudad_destino) as ciudadDestino, "+
                            "(select tipo_servicio from MONDONGO.tipos_servicio ts where ts.id_tipo_servicio=rts.id_tipo_servicio) "+
                            "from mondongo.rutas r, MONDONGO.ruta_tipo_servicio rts " +
                            "where estado = 0 and r.id_ruta=rts.id_ruta " +
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

        public int guardarRuta(Model.RutaModel ruta)
        {
            SqlConnection myConnection = null;
            int idRuta = 0;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "insert into mondongo.rutas (codigo_ruta, id_ciudad_origen, id_ciudad_destino, " +
                            "                            precio_base_kg, precio_base_pasaje, horas_vuelo) "+
                            "OUTPUT INSERTED.ID_RUTA "+
                            "values(@codigoRuta, @idOrigen, @idDestino, @precioKg, @precioPas, @horasVuelo) ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@codigoRuta", ruta.codigoRuta);
                    command.Parameters.AddWithValue("@idOrigen", ruta.ciudadOrigen);
                    command.Parameters.AddWithValue("@idDestino", ruta.ciudadDestino);
                    command.Parameters.AddWithValue("@precioKg", ruta.precioBaseKg);
                    command.Parameters.AddWithValue("@precioPas", ruta.precioBasePasaje);
                    command.Parameters.AddWithValue("@horasVuelo", ruta.horasVuelo);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        idRuta = (int)(double)reader.GetDecimal(0);
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
            return idRuta;
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
                            "set precio_base_kg = @precioKg, "+
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
        public void eliminarRutaTipoServicio(int rutaId)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "delete mondongo.ruta_tipo_servicio " +
                            "where id_ruta = @idRuta ";

                using (command = new SqlCommand(query, myConnection))
                {
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
        public void guardarRutaTipoServicio(int rutaId, int tipoServicioId)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "insert into mondongo.ruta_tipo_servicio " +
                            "values(@idRuta, @idTipoServicio) ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idRuta", rutaId);
                    command.Parameters.AddWithValue("@idTipoServicio", tipoServicioId);
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

        public Model.RutaModel buscarRutaPorCodigo(int codigoRuta)
        {
            Model.RutaModel ruta = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select r.codigo_ruta " +
                            "from mondongo.rutas r "+
                            "where r.codigo_ruta = @codRuta ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@codRuta", codigoRuta);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ruta = new Model.RutaModel(); ;
                        ruta.codigoRuta = (int)(double)reader.GetDecimal(0);
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
            return ruta;
        }

        public int cantRutasTipoServicio(int rutaId)
        {
            int cant = 0;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select count(*) from mondongo.ruta_tipo_servicio rts " +
                            "where rts.id_ruta = @idRuta ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idRuta", rutaId);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cant = reader.GetInt32(0);
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
            return cant;
        }

        public List<Model.RutaModel> buscarRutasPorOrigenYDestino(int origen, int destino)
        {
            List<Model.RutaModel> rutasEncontradas = new List<Model.RutaModel>();
            Model.RutaModel ruta = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select		r.id_ruta,  " +
			                "r.codigo_ruta,  "+
			                "r.id_ciudad_origen,  "+
			                "r.id_ciudad_destino,  "+
			                "rts.id_tipo_servicio,  "+
			                "r.precio_base_pasaje,  "+
			                "r.precio_base_kg,  "+
			                "r.horas_vuelo,  "+
			                "r.estado "+
                            "from		mondongo.rutas r "+
                            "inner join	mondongo.ruta_tipo_servicio rts on r.id_ruta = rts.id_ruta "+
                            "where		r.id_ciudad_origen = @idCiudadOrigen "+
                            "and			r.id_ciudad_destino = @idCiudadDestino ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idCiudadOrigen", origen);
                    command.Parameters.AddWithValue("@idCiudadDestino", destino);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ruta = generarRuta(reader);
                        rutasEncontradas.Add(ruta);  
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
            return rutasEncontradas;
        }
    }
}
