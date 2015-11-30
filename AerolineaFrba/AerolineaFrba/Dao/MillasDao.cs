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
        DateTime fechaSistema = Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings.Get("fechaSistema"));

        public List<Model.HistorialMillasModel> buscarMillas(int clienteId)
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
                            "where c.cliente_id = @clienteId " +
                            "and DATEDIFF(DAY,fecha_operacion, @fechaSistema) <= 365 and DATEDIFF(DAY,fecha_operacion, @fechaSistema) >= 0";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@clienteId", clienteId);
                    command.Parameters.AddWithValue("@fechaSistema", fechaSistema);
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
            finally
            {
                myConnection.Close();
            }
            return millas;
        }


        public Boolean registroMillas(Model.HistorialMillasModel historialMillas)
        {
            Boolean agregado = false;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "insert into mondongo.historial_millas (id_cliente,millas,fecha_operacion, tipo_operacion, descripcion) "+
                            "values (@idCliente, @millas, @fechaOperacion, @tipoOperacion, @descripcion)";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idCliente", historialMillas.idCliente);
                    command.Parameters.AddWithValue("@millas", historialMillas.millas);
                    command.Parameters.AddWithValue("@fechaOperacion", historialMillas.fechaOperacion);
                    command.Parameters.AddWithValue("@tipoOperacion", historialMillas.tipoOperacion);
                    command.Parameters.AddWithValue("@descripcion", historialMillas.descripcion);
                }

                var cantidadInsertada = command.ExecuteNonQuery();

                agregado = Convert.ToBoolean(cantidadInsertada);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
            return agregado;
        }

        public int buscarUltimoRegistroMillas()
        {
            int idHistorial = 0;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select max(id_historial) from mondongo.historial_millas";
                command = new SqlCommand(query, myConnection);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        idHistorial = (int)(double)reader.GetDecimal(0);                                                
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
            return idHistorial;
        }


        public Boolean registrarCanje(int idProducto, int idHistorial, int cantidad)
        {
            Boolean agregado = false;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "insert into mondongo.canje_millas(id_producto, id_historial, cantidad, fecha_canje) "+
                            "values (@idProducto, @idHistorial, @cantidad, @fechaCanje)";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@idHistorial", idHistorial);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@fechaCanje", fechaSistema);                    
                }

                var cantidadInsertada = command.ExecuteNonQuery();

                agregado = Convert.ToBoolean(cantidadInsertada);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
            return agregado;            
        }

    }
}
