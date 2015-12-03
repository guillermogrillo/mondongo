using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    class AeronaveDao
    {
        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");
        DateTime fechaSistema = Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings.Get("fechaSistema"));

        public List<Model.AeronaveModel> buscarAeronaves()
        {

            List<Model.AeronaveModel> aeronaves = new List<Model.AeronaveModel>();
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "SELECT a.matricula, a.modelo, a.capacidad_kg, a.cantidad_butacas_pas, a.cantidad_butacas_ven, " +
                            "   a.id_tipo_servicio, a.id_fabricante "+
                            "FROM MONDONGO.AERONAVES a "+
                            "where a.matricula not in (select aeronave_matricula from MONDONGO.aeronaves_bajas "+
                            "                            where (fecha_fuera_servicio <= @fechaSistma  "+
                            "                                and fecha_reinicio_servicio >= @fechaSistma  " +
	                        "                                and tipo_baja='FS') "+
	                        "                                or "+
                            "                                (fecha_baja_definitiva <= @fechaSistma " +
	                        "                                and tipo_baja='BD') "+
                            " ) ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@fechaSistma", fechaSistema);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        aeronaves.Add(getAeronave(reader));
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
            return aeronaves;
        }

        public void actualizarAeronave(Model.AeronaveModel aeronave)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "UPDATE MONDONGO.aeronaves " +
                            "SET modelo = @modelo, " +
                            "   capacidad_kg = @capacidadKg, " +
                            "   id_fabricante = @idFabricante, " +
                            "   id_tipo_servicio = @idTipoServicio, " +
                            "   cantidad_butacas_ven = @butacasVen, " +
                            "   cantidad_butacas_pas = @butacasPas " +
                            "WHERE matricula = @matricula ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", aeronave.matricula);
                    command.Parameters.AddWithValue("@modelo", aeronave.modelo);
                    command.Parameters.AddWithValue("@capacidadKg", aeronave.capacidadKg);
                    command.Parameters.AddWithValue("@idFabricante", aeronave.idFabricante);
                    command.Parameters.AddWithValue("@idTipoServicio", aeronave.idTipoServicio);
                    command.Parameters.AddWithValue("@butacasVen", aeronave.cantButacasVen);
                    command.Parameters.AddWithValue("@butacasPas", aeronave.cantButacasPas);
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

        internal void guardarAeronave(Model.AeronaveModel aeronave)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "INSERT INTO MONDONGO.aeronaves (matricula, modelo, capacidad_kg, id_fabricante, id_tipo_servicio, cantidad_butacas_ven, cantidad_butacas_pas, fecha_alta)  " +
                            "VALUES(@matricula, @modelo, @capacidadKg, @idFabricante, @idTipoServicio, @butacasVen, @butacasPas, @fechaAlta) ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", aeronave.matricula);
                    command.Parameters.AddWithValue("@modelo", aeronave.modelo);
                    command.Parameters.AddWithValue("@capacidadKg", aeronave.capacidadKg);
                    command.Parameters.AddWithValue("@idFabricante", aeronave.idFabricante);
                    command.Parameters.AddWithValue("@idTipoServicio", aeronave.idTipoServicio);
                    command.Parameters.AddWithValue("@butacasVen", aeronave.cantButacasVen);
                    command.Parameters.AddWithValue("@butacasPas", aeronave.cantButacasPas);
                    command.Parameters.AddWithValue("@fechaAlta", DateTime.Now);
                    //command.Parameters.AddWithValue("@estado", Model.AeronaveEstado.ACTIVA);
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

        public void grabarBajaAeronave(string matricula, DateTime fueraServ, DateTime reinicio, String tipoBaja)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "INSERT INTO MONDONGO.AERONAVES_BAJAS(aeronave_matricula, fecha_proceso, fecha_fuera_servicio, fecha_reinicio_servicio, tipo_baja) " +
                            "VALUES (@matricula, @fechaProceso, @fechaFueraServicio, @fechaReinicioServicio, @tipoBaja) ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaProceso", fechaSistema);
                    command.Parameters.AddWithValue("@fechaFueraServicio", fueraServ);
                    command.Parameters.AddWithValue("@fechaReinicioServicio", reinicio);
                    command.Parameters.AddWithValue("@tipoBaja", tipoBaja);
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
        public void grabarBajaDefinitivaAeronave(string matricula, DateTime baja, String tipoBaja)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "INSERT INTO MONDONGO.AERONAVES_BAJAS(aeronave_matricula, fecha_proceso, fecha_baja_definitiva, tipo_baja) " +
                            "VALUES (@matricula, @fechaProceso, @fechaBajaDefinitiva, @tipoBaja) ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaProceso", fechaSistema);
                    command.Parameters.AddWithValue("@fechaBajaDefinitiva", baja);
                    command.Parameters.AddWithValue("@tipoBaja", tipoBaja);
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
        
        internal Model.AeronaveModel buscarAeronavePorMatricula(string matricula)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "SELECT matricula, modelo, capacidad_kg, cantidad_butacas_pas, cantidad_butacas_ven, " +
                            "   id_tipo_servicio, id_fabricante " +
                            "FROM MONDONGO.AERONAVES " +
                            "WHERE matricula=@matricula ";
                command = new SqlCommand(query, myConnection);

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    return getAeronave(reader);
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
            return null;
        }

        private Model.AeronaveModel getAeronave(SqlDataReader reader)
        {
            if (!reader.HasRows)
                return null;

            Model.AeronaveModel a = new Model.AeronaveModel();
            a.matricula = reader.GetString(0);
            a.modelo = reader.GetString(1);
            a.capacidadKg = (int)(double)reader.GetDecimal(2);
            a.cantButacasPas = (int)(double)reader.GetDecimal(3);
            a.cantButacasVen = (int)(double)reader.GetDecimal(4);
            a.cantidadButacas = (a.cantButacasPas + a.cantButacasVen);
            a.idTipoServicio = (int)(double)reader.GetDecimal(5);
            a.idFabricante = (int)(double)reader.GetDecimal(6);

            return a;
        }

        public Boolean tieneViajesAsignados(string matricula, DateTime fechaDesde, DateTime fechaReinicio)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select count(*) as cantidad_vuelos " +
                            "from MONDONGO.viajes v "+
                            "where v.aeronave_matricula=@matricula "+
                            "and (v.fecha_salida between @fechaDesde and @fechaHasta "+
                            "or v.fecha_llegada_estimada between @fechaDesde and @fechaHasta "+
                            "or (v.fecha_salida > @fechaDesde and v.fecha_llegada_estimada < @fechaHasta))";

                command = new SqlCommand(query, myConnection);

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    command.Parameters.AddWithValue("@fechaHasta", fechaReinicio);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    return reader.GetInt32(0) > 0;
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
            return true;
        }

        public String buscarAeronaveReemplazo(Model.AeronaveModel aeronave, DateTime fechaDesde, DateTime fechaHasta)
        {
            SqlConnection myConnection = null;
            try
            {
                int[] cantPasajes = cantidadMaximaPasajes(aeronave.matricula, fechaDesde, fechaHasta);
                int cantPaquetes = cantidadMaximaPaquetes(aeronave.matricula, fechaDesde, fechaHasta);
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select top 1 a.matricula "+
                            "from MONDONGO.aeronaves a "+
                            "where a.id_fabricante=@idFabricante "+
                            "    and a.id_tipo_servicio=@idTipoServicio " +
	                        "    and a.modelo = @modelo "+
                            "    and a.cantidad_butacas_pas >= @cantButacasPas " +
                            "    and a.cantidad_butacas_ven >= @cantButacasVen " +
                            "    and a.capacidad_kg >= @cantPaquetes " +
	                        "    and a.matricula<>@matricula "+
                            "    and a.matricula not in (select distinct aeronave_matricula from mondongo.viajes v where v.fecha_salida between @fechaDesde and @fechaHasta) " +
                            "group by a.matricula ";

                command = new SqlCommand(query, myConnection);

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", aeronave.matricula);
                    command.Parameters.AddWithValue("@idFabricante", aeronave.idFabricante);
                    command.Parameters.AddWithValue("@idTipoServicio", aeronave.idTipoServicio);
                    command.Parameters.AddWithValue("@modelo", aeronave.modelo);
                    command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    command.Parameters.AddWithValue("@fechaHasta", fechaHasta);
                    command.Parameters.AddWithValue("@cantButacasPas", cantPasajes[0]);
                    command.Parameters.AddWithValue("@cantButacasVen", cantPasajes[1]);
                    command.Parameters.AddWithValue("@cantPaquetes", cantPaquetes);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    if(reader.HasRows)
                        return reader.GetString(0);
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
            return null;
        }

        private int[] cantidadMaximaPasajes(string matricula, DateTime fechaDesde, DateTime fechaReinicio)
        {
            SqlConnection myConnection = null;
            int butacasPas = 0;
            int butacasVen = 0;

            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select asd.butaca_tipo, max(pasajes)   " +
                            "from (  "+
                            "    select viaje_id,b.butaca_tipo, count(*) as pasajes  "+
                            "    from mondongo.pasajes pas , mondongo.ventas vta, mondongo.viajes v , mondongo.butacas b "+
                            "where v.fecha_salida between @fechaDesde and @fechaHasta  "+
                            "        and v.viaje_id = vta.venta_viaje_id  "+
                            "        and vta.venta_pnr = pas.pasaje_venta_pnr  "+
                            "        and b.butaca_id = pas.butaca_id "+
                            "and v.aeronave_matricula=@matricula  "+
                            "    group by viaje_id,b.butaca_tipo  "+
                            ") asd "+
                            "group by asd.butaca_tipo "+
                            "order by asd.butaca_tipo";

                command = new SqlCommand(query, myConnection);

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    command.Parameters.AddWithValue("@fechaHasta", fechaReinicio);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    for (int x = 0; x < 2; x++)
                    {
                        reader.Read();
                        if(x==0)
                            butacasPas = reader.GetInt32(1);
                        else
                            butacasVen = reader.GetInt32(1);
                    }
                }
                return new int[2] { butacasPas, butacasVen };
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
            return new int[2]{0,0};
        }

        private int cantidadMaximaPaquetes(string matricula, DateTime fechaDesde, DateTime fechaReinicio)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select max(paquetes) " +
                            "from ( " +
                            "    select viaje_id, count(*) as paquetes " +
                            "    from mondongo.paquetes pas, mondongo.viajes v, MONDONGO.ventas vta " +
                            "    where v.fecha_salida between @fechaDesde and @fechaHasta " +
                            "        and vta.venta_pnr = pas.paquete_venta_pnr "+
		                    "        and vta.venta_viaje_id = v.viaje_id " +
                            "        and v.aeronave_matricula=@matricula " +
                            "    group by viaje_id " +
                            ") asd ";

                command = new SqlCommand(query, myConnection);

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    command.Parameters.AddWithValue("@fechaHasta", fechaReinicio);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    return reader.GetInt32(0);
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
            return 100;
        }
    }
}
