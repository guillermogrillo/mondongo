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

        public int buscarPnr()
        {
            SqlConnection myConnection = null;
            var pnr = 0;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select next value for mondongo.sq_pnr";
                command = new SqlCommand(query, myConnection);                      
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pnr = reader.GetInt32(0);
                    }
                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }

            return pnr;
        }

        public int guardarPasaje(int idPasajero, int idPagador, int pnr, Model.CompraModel compraModel, Model.ClienteModel cliente)
        {
            SqlConnection myConnection = null;
            int pasajeId = 0;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "INSERT INTO MONDONGO.PASAJES(pasaje_pnr, pasaje_pasajero_id, pasaje_pagador_id, pasaje_viaje_id, pasaje_monto, pasaje_fecha_compra, pasaje_tipo_pago_id, pasaje_butaca_tipo, pasaje_butaca_numero, estado) "+
                            "VALUES (@pnr,@idPasajero,@idPagador,@idViaje,@monto,@fechaCompra,@tipoPago, @butacaTipo, @butacaNumero, @estado)";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@pnr", pnr);
                    command.Parameters.AddWithValue("@idPasajero", idPasajero);
                    command.Parameters.AddWithValue("@idPagador", idPagador);
                    command.Parameters.AddWithValue("@idViaje", compraModel.vueloElegido.idViaje);
                    command.Parameters.AddWithValue("@monto", compraModel.ruta.precioBasePasaje);
                    command.Parameters.AddWithValue("@fechaCompra",DateTime.Now);
                    command.Parameters.AddWithValue("@tipoPago", compraModel.pagador.formaPago);
                    command.Parameters.AddWithValue("@butacaTipo", cliente.butaca.tipo);
                    command.Parameters.AddWithValue("@butacaNumero", cliente.butaca.numero);
                    command.Parameters.AddWithValue("@estado", 0);
                }
                command.ExecuteNonQuery();
                
                query = "SELECT MAX(pasaje_id) from mondongo.pasajes";
                command = new SqlCommand(query, myConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pasajeId = (int)(double)reader.GetDecimal(0);
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            return pasajeId;
        }

        public int guardarPaquete(int pnr, int pagadorId, Model.CompraModel compraModel)
        {
            SqlConnection myConnection = null;
            int paqueteId = 0;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "INSERT INTO MONDONGO.PAQUETES(paquete_pnr,paquete_kg,paquete_monto,paquete_viaje_id,paquete_pagador_id,paquete_fecha_compra,paquete_tipo_pago_id,estado) " +
                            "VALUES(@pnr,@kg,@monto,@idViaje,@idPagador,@fechaCompra,@tipoPago,@estado)";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@pnr", pnr);
                    command.Parameters.AddWithValue("@kg", compraModel.cantidadKg);
                    command.Parameters.AddWithValue("@monto", compraModel.ruta.precioBaseKg);
                    command.Parameters.AddWithValue("@idViaje", compraModel.vueloElegido.idViaje);
                    command.Parameters.AddWithValue("@idPagador", pagadorId);
                    command.Parameters.AddWithValue("@fechaCompra", DateTime.Now);
                    command.Parameters.AddWithValue("@tipoPago", compraModel.pagador.formaPago);
                    command.Parameters.AddWithValue("@estado", 0);
                }
                command.ExecuteNonQuery();

                
                query = "SELECT MAX(paquete_id) from mondongo.paquetes";
                command = new SqlCommand(query, myConnection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        paqueteId = (int)(double)reader.GetDecimal(0);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            return paqueteId;
        }

        public void guardarButacasVendidas(int viajeId, String butacaTipo, int butacaNro)
        {            
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "INSERT INTO MONDONGO.BUTACAS_VENDIDAS(butaca_nro, butaca_tipo, butaca_viaje_id)" +
                            "VALUES(@butacaNro,@butacaTipo,@viajeId) ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@butacaNro", butacaNro);
                    command.Parameters.AddWithValue("@butacaTipo", butacaTipo);
                    command.Parameters.AddWithValue("@viajeId", viajeId);
                }

                command.ExecuteNonQuery();
                      

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }            
        }
    }
}
