using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    class CompraDao
    {

        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");
        DateTime fechaSistema = Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings.Get("fechaSistema"));

        public int buscarPnr()
        {
            SqlConnection myConnection = null;
            var pnr = 0;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select max(venta_pnr) + 1 "+
                            "from mondongo.ventas";
                command = new SqlCommand(query, myConnection);                      
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pnr = (int)(double)reader.GetDecimal(0);
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

            return pnr;
        }

        public void guardarVenta(int pnr, int idPagador, Model.CompraModel compraModel)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "insert into mondongo.ventas(venta_pnr, venta_fecha_compra, venta_viaje_id, venta_id_pagador, venta_tipo_pago_id, venta_estado) "+
                            "values (@pnr, @fechaCompra, @viajeId, @idPagador, @tipoPagoId, @estado)";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@pnr", pnr);
                    command.Parameters.AddWithValue("@fechaCompra", fechaSistema);
                    command.Parameters.AddWithValue("@viajeId", compraModel.vueloElegido.idViaje);
                    command.Parameters.AddWithValue("@idPagador", idPagador);
                    command.Parameters.AddWithValue("@tipoPagoId", compraModel.pagador.formaPago);                
                    command.Parameters.AddWithValue("@estado", 0);
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


        public void guardarPasaje(int pnr, int idPasajero, Model.CompraModel compraModel, Model.ClienteModel cliente)
        {
            SqlConnection myConnection = null;           
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "insert into mondongo.pasajes(pasaje_venta_pnr, pasaje_pasajero_id, pasaje_monto, pasaje_butaca_tipo, pasaje_butaca_numero, estado) " +
                            "values (@pnr, @pasajeroId, @monto, @butacaTipo, @butacaNumero, @estado) ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@pnr", pnr);
                    command.Parameters.AddWithValue("@pasajeroId", idPasajero);                                        
                    command.Parameters.AddWithValue("@monto", compraModel.ruta.precioBasePasaje);                                        
                    command.Parameters.AddWithValue("@butacaTipo", cliente.butaca.tipo.ToString());
                    command.Parameters.AddWithValue("@butacaNumero", cliente.butaca.numero);                   
                    command.Parameters.AddWithValue("@estado", 0);
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

        public void guardarPaquete(int pnr, Model.CompraModel compraModel)
        {
            SqlConnection myConnection = null;
            
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "insert into mondongo.paquetes(paquete_venta_pnr, paquete_kg, paquete_monto, estado) "+
                            "values (@pnr, @kg, @monto, @estado)";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@pnr", pnr);
                    command.Parameters.AddWithValue("@kg", compraModel.cantidadKg);
                    command.Parameters.AddWithValue("@monto", compraModel.ruta.precioBaseKg);
                    command.Parameters.AddWithValue("@estado", 0);
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


        public List<Model.VentaModel> buscarVentas(int viajeId)
        {
            List<Model.VentaModel> ventas = new List<Model.VentaModel>();
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select ve.venta_pnr, ve.venta_fecha_compra, ve.venta_viaje_id, ve.venta_id_pagador, ve.venta_tipo_pago_id, ve.venta_estado "+
                            "from mondongo.ventas ve "+
                            "where ve.venta_viaje_id = @viajeId";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@viajeId", viajeId);                    
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var ventaPnr = (int)(double)reader.GetDecimal(0);
                        var ventaFechaCompra = reader.GetDateTime(1);
                        var ventaViajeId = (int)(double)reader.GetDecimal(2);
                        var ventaIdPagador = (int)(double)reader.GetDecimal(3);
                        var ventaTipoPago = (int)(double)reader.GetDecimal(4);
                        var ventaEstado = (int)(double)reader.GetDecimal(5);
                        ventas.Add(new Model.VentaModel(ventaPnr, ventaFechaCompra, ventaViajeId, ventaIdPagador, ventaTipoPago, ventaEstado));
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

            return ventas;
        }

        public List<Model.PasajeModel> buscarPasajes(int pnr)
        {
            List<Model.PasajeModel> pasajes = new List<Model.PasajeModel>();
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select pasaje_id, pasaje_venta_pnr, pasaje_pasajero_id, pasaje_monto, pasaje_butaca_tipo, pasaje_butaca_numero, estado "+
                            "from mondongo.pasajes "+
                            "where pasaje_venta_pnr = @pnr";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@pnr", pnr);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pasajeId = (int)(double)reader.GetDecimal(0);
                        var pasajePnr = (int)(double)reader.GetDecimal(1);
                        var pasajeClienteId = (int)(double)reader.GetDecimal(2);
                        var pasajeMonto = (double)reader.GetDecimal(3);
                        var pasajeButacaTipo = reader.GetString(4);
                        var pasajeNroButaca = (int)(double)reader.GetDecimal(5);
                        var estado = (int)(double)reader.GetDecimal(6);
                        pasajes.Add(new Model.PasajeModel(pasajeId, pasajePnr, pasajeClienteId, pasajeMonto, pasajeButacaTipo, pasajeNroButaca, estado));
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

            return pasajes;
        }


        public Model.PaqueteModel buscarPaquetes(int pnr)
        {
            Model.PaqueteModel paquete = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select paquete_id, paquete_venta_pnr, paquete_kg, paquete_monto, estado "+
                            "from mondongo.paquetes "+
                            "where paquete_venta_pnr = @pnr";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@pnr", pnr);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var paqueteId = (int)(double)reader.GetDecimal(0);
                        var paquetePnr = (int)(double)reader.GetDecimal(1);
                        var paqueteKg = (int)(double)reader.GetDecimal(2);
                        var paqueteMonto = (double)reader.GetDecimal(3);
                        var paqueteEstado = (int)(double)reader.GetDecimal(4);
                        paquete = new Model.PaqueteModel(paqueteId, paquetePnr, paqueteKg, paqueteMonto, paqueteEstado);
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

            return paquete;
        }

        public void cargarDevolucionPasaje(int ventaPnr, int idPasaje, String motivo, int codDevolucion)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "insert into mondongo.devoluciones(cod_devolucion, venta_pnr, fecha_devolucion, id_pasaje, motivo) " +
                            "values(@codDevolucion,@ventaPnr,@fechaDevolucion,@idPasaje,@motivo) ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@codDevolucion", codDevolucion);
                    command.Parameters.AddWithValue("@ventaPnr", ventaPnr);
                    command.Parameters.AddWithValue("@fechaDevolucion", DateTime.Now);
                    command.Parameters.AddWithValue("@idPasaje", idPasaje);
                    command.Parameters.AddWithValue("@motivo", motivo);
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

        public void cargarDevolucionPaquete(int ventaPnr, int idPaquete, String motivo, int codDevolucion)
        {
            Model.PaqueteModel paquete = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "insert into mondongo.devoluciones(cod_devolucion, venta_pnr, fecha_devolucion, id_paquete, motivo) " +
                            "values(@codDevolucion,@ventaPnr,@fechaDevolucion,@idPaquete,@motivo) ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@codDevolucion", codDevolucion);
                    command.Parameters.AddWithValue("@ventaPnr", ventaPnr);
                    command.Parameters.AddWithValue("@fechaDevolucion", DateTime.Now);
                    command.Parameters.AddWithValue("@idPaquete", idPaquete);
                    command.Parameters.AddWithValue("@motivo", motivo);
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

        public int generarCodigoDevolucion()
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select isnull(max(cod_devolucion), 0) " +
                            "from mondongo.devoluciones ";

                command = new SqlCommand(query, myConnection);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int maxDevolucionId = (int)(double)reader.GetDecimal(0);
                        return maxDevolucionId + 1;
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

            return 1;
        }
    }
}
