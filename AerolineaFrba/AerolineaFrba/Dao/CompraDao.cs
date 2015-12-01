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
                var query = "insert into mondongo.pasajes(pasaje_venta_pnr, pasaje_pasajero_id, pasaje_monto, butaca_id, estado) " +
                            "values (@pnr, @pasajeroId, @monto, (select butaca_id from mondongo.butacas where aeronave_matricula = @aeronaveMatricula and butaca_nro = @butacaNumero and butaca_tipo = @butacaTipo), @estado) ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@pnr", pnr);
                    command.Parameters.AddWithValue("@pasajeroId", idPasajero);                                        
                    command.Parameters.AddWithValue("@monto", compraModel.ruta.precioBasePasaje);                                        
                    command.Parameters.AddWithValue("@butacaTipo", cliente.butaca.tipo.ToString());
                    command.Parameters.AddWithValue("@butacaNumero", cliente.butaca.numero);
                    command.Parameters.AddWithValue("@aeronaveMatricula", compraModel.vueloElegido.aeronaveMatricula);  
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

        public List<Model.DevolucionVentaModel> buscarVentasParaDevolucion(int idPagador)
        {
            List<Model.DevolucionVentaModel> ventas = new List<Model.DevolucionVentaModel>();
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select ve.venta_pnr,ve.venta_fecha_compra,vi.fecha_salida,tp.descripcion "+
                            "from mondongo.ventas ve "+
                            "inner join mondongo.viajes vi on vi.viaje_id = ve.venta_viaje_id "+
                            "inner join mondongo.tipos_pago tp on tp.tipo_pago_id = ve.venta_tipo_pago_id "+                            
                            "where ve.venta_id_pagador = @idPagador " +
                            "and vi.fecha_salida > @fechaSistema "+
                            "and ve.venta_estado = 0 "+
                            "order by vi.fecha_salida asc";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idPagador", idPagador);
                    command.Parameters.AddWithValue("@fechaSistema", fechaSistema);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ventaPnr = (int)(double)reader.GetDecimal(0);
                        var ventaFechaCompra = reader.GetDateTime(1);
                        var viajeFechaSalida = reader.GetDateTime(2);
                        var formaDePago = reader.GetString(3);

                        ventas.Add(new Model.DevolucionVentaModel(ventaPnr, ventaFechaCompra, viajeFechaSalida, formaDePago));
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
                var query = "select p.pasaje_id, p.pasaje_venta_pnr, p.pasaje_pasajero_id, p.pasaje_monto, b.butaca_tipo, b.butaca_nro, p.estado "+
                            "from mondongo.pasajes p "+
                            "inner join mondongo.butacas b on p.butaca_id = b.butaca_id "+
                            "where p.pasaje_venta_pnr = @pnr";
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
                            "where paquete_venta_pnr = @pnr "+
                            "and estado = 0";
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
                    command.Parameters.AddWithValue("@fechaDevolucion", fechaSistema);
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
                    command.Parameters.AddWithValue("@fechaDevolucion", fechaSistema);
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


        public void registrarDevolucionDeCompra(int pnr)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "update MONDONGO.ventas "+
	                        "set venta_estado = 1 "+
	                        "where venta_pnr = @ventaPnr";

                using (command = new SqlCommand(query, myConnection))
                {                    
                    command.Parameters.AddWithValue("@ventaPnr", pnr);
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

        public List<Model.DevolucionPasajeModel> buscarPasajesDevolucion(int pnr)
        {
            List<Model.DevolucionPasajeModel> pasajesDevolucion = new List<Model.DevolucionPasajeModel>();

            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select p.pasaje_id, c.cliente_nombre, c.cliente_apellido, c.cliente_dni, b.butaca_nro, b.butaca_tipo "+
                            "from mondongo.pasajes p "+
                            "inner join mondongo.clientes c on c.cliente_id = p.pasaje_pasajero_id "+
                            "inner join mondongo.butacas b on b.butaca_id = p.butaca_id "+
                            "where p.pasaje_venta_pnr = @pnr "+
                            "and p.estado = 0";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@pnr", pnr);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = (int)(double)reader.GetDecimal(0);
                        var nombre = reader.GetString(1);
                        var apellido = reader.GetString(2);
                        var dni = (int)(double)reader.GetDecimal(3);
                        var butacaNro = (int)(double)reader.GetDecimal(4);
                        var butacaTipo = reader.GetString(5);                        
                        pasajesDevolucion.Add(new Model.DevolucionPasajeModel(id,nombre,apellido,dni,butacaNro,butacaTipo));
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

            return pasajesDevolucion;
        }



        public void registrarDevolucionDeEncomienda(int paqueteId)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "update MONDONGO.paquetes " +
                            "set estado = 1 " +
                            "where paquete_id = @paqueteId";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@paqueteId", paqueteId);
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

        public void registrarDevolucionPasaje(int pasajeId)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "update MONDONGO.pasajes " +
                            "set estado = 1 " +
                            "where pasaje_id = @pasajeId";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@pasajeId", pasajeId);
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
