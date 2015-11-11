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

        public List<Model.AeronaveModel> buscarAeronaves()
        {

            List<Model.AeronaveModel> aeronaves = new List<Model.AeronaveModel>();
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "SELECT matricula, modelo, capacidad_kg, cantidad_butacas_pas, cantidad_butacas_ven, " +
                            "   id_tipo_servicio, id_fabricante, estado " +
                            "FROM MONDONGO.AERONAVES ";
                command = new SqlCommand(query, myConnection);
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
        }

        internal void guardarAeronave(Model.AeronaveModel aeronave)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "INSERT INTO MONDONGO.aeronaves (matricula, modelo, capacidad_kg, id_fabricante, id_tipo_servicio, cantidad_butacas_ven, cantidad_butacas_pas, fecha_alta, estado)  " +
                            "VALUES(@matricula, @modelo, @capacidadKg, @idFabricante, @idTipoServicio, @butacasVen, @butacasPas, @fechaAlta, @estado) ";

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
                    command.Parameters.AddWithValue("@estado", Model.AeronaveEstado.ACTIVA);
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        internal void eliminarAeronave(String matricula)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "UPDATE MONDONGO.AERONAVES " +
                            "   SET fecha_baja_definitiva=@fecha_baja, "+
                            "       estado=@estado "+
                            "WHERE matricula=@matricula";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fecha_baja", DateTime.Now);
                    command.Parameters.AddWithValue("@estado", Model.AeronaveEstado.ELIMINADA);
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        public void fueraServicioAeronave(string matricula, DateTime fechaDesde, DateTime fechaReinicio)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "UPDATE MONDONGO.AERONAVES " +
                            "SET fecha_fuera_servicio=@fechaFueraServicio, " +
                            "   fecha_reinicio_servicio=@fechaReinicio, " +
                            "   estado=@estado " +
                            "WHERE matricula=@matricula";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaFueraServicio", fechaDesde);
                    command.Parameters.AddWithValue("@fechaReinicio", fechaReinicio);
                    command.Parameters.AddWithValue("@estado", Model.AeronaveEstado.FUERA_SERVICIO);
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        public void bajaAeronave(string matricula, DateTime fechaBaja)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "UPDATE MONDONGO.AERONAVES " +
                            "SET fecha_baja_definitiva=@fechaBaja, " +
                            "   estado=@estado " +
                            "WHERE matricula=@matricula";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaBaja", fechaBaja);
                    command.Parameters.AddWithValue("@estado", Model.AeronaveEstado.ELIMINADA);
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
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
            a.estado = (int)(double)reader.GetDecimal(7);

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
                var query = "select count(*) "+
                            "from MONDONGO.viajes v "+
                            "where v.aeronave_matricula=@matricula "+
                            "    and v.fecha_salida >= @fechaDesde " +
	                        "    and v.fecha_salida <= @fechaReinicio ";

                command = new SqlCommand(query, myConnection);

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    command.Parameters.AddWithValue("@fechaReinicio", fechaReinicio);
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
                var query = "select pasaje_butaca_tipo, max(pasajes)  " +
                            "from ( "+
                            "    select pasaje_viaje_id,pasaje_butaca_tipo, count(*) as pasajes " +
	                        "    from mondongo.pasajes pas, mondongo.viajes v "+
	                        "    where v.fecha_salida between @fechaDesde and @fechaHasta "+
		                    "        and v.viaje_id = pas.pasaje_viaje_id "+
		                    "        and v.aeronave_matricula=@matricula "+
                            "    group by pasaje_viaje_id,pasaje_butaca_tipo " +
                            ") asd "+
                            "group by pasaje_butaca_tipo "+
                            "order by pasaje_butaca_tipo";

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
                            "    select paquete_viaje_id, count(*) as paquetes " +
                            "    from mondongo.paquetes pas, mondongo.viajes v " +
                            "    where v.fecha_salida between @fechaDesde and @fechaHasta " +
                            "        and v.viaje_id = pas.paquete_viaje_id " +
                            "        and v.aeronave_matricula=@matricula " +
                            "    group by paquete_viaje_id " +
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
            return 100;
        }
    }
}
