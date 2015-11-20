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
                    command.Parameters.AddWithValue("@fechaCompra", DateTime.Now);
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
           
        }

    }
}
