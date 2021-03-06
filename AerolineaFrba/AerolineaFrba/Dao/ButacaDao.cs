﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    public class ButacaDao
    {

        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");
        DateTime fechaSistema = Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings.Get("fechaSistema"));


        public List<Model.ButacaModel> buscarButacas(String aeronaveMatricula)
        {
            List<Model.ButacaModel> butacas = new List<Model.ButacaModel>();

            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select butaca_id, butaca_tipo, butaca_nro "+
                            "from MONDONGO.butacas "+
                            "where aeronave_matricula = @aeronaveMatricula";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@aeronaveMatricula", aeronaveMatricula);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var id = (int)(double)reader.GetDecimal(0);

                        butacas.Add(new Model.ButacaModel(id));
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


            return butacas;
        }


        public void guardarButacasViaje(int idViaje, List<Model.ButacaModel> butacas)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "insert into mondongo.butacas_viaje(viaje_id, butaca_id, estado) "+
                            "values(@viajeId, @butacaId, @estado)";

                foreach (Model.ButacaModel butaca in butacas)
                {
                    using (command = new SqlCommand(query, myConnection))
                    {
                        command.Parameters.AddWithValue("@viajeId", idViaje);
                        command.Parameters.AddWithValue("@butacaId", butaca.id);
                        command.Parameters.AddWithValue("@estado", "L");
                    }
                    command.ExecuteNonQuery();
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
        }

        public void borrarButacasViaje(int viajeId)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "delete from mondongo.butacas_viaje "+
                            "where viaje_id = @viajeId";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@viajeId", viajeId);
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

        public void borrarButacasPorBaja(string matricula, DateTime fechaDesde, Nullable<DateTime> fechaHasta)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "delete from mondongo.butacas_viaje " +
                            "where viaje_id in ( " +
                            "    select viaje_id from MONDONGO.viajes " +
                            "    where aeronave_matricula = @matricula " +
                            "        and fecha_salida > @fechaDesde ";

                if (fechaHasta != null)
                    query = query + " and fecha_salida < @fechaHasta ";
                
                query = query + ")";
                
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    if (fechaHasta != null) command.Parameters.AddWithValue("@fechaHasta", fechaHasta);
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
