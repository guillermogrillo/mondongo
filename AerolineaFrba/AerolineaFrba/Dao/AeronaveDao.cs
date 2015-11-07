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
                            "id_tipo_servicio, id_fabricante " +
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
                    command.Parameters.AddWithValue("@estado", 2);
                }

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        internal void fueraServicioAeronave(string matricula)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "UPDATE MONDONGO.AERONAVES " +
                            "SET baja_fuera_servicio=1, " +
                            "   fecha_fuera_servicio=@fechaFueraServicio, " +
                            "   fecha_reinicio_servicio=@fechaReinicio " +
                            "WHERE matricula=@matricula";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaFueraServicio", DateTime.Now);
                    command.Parameters.AddWithValue("@fechaReinicio", DateTime.Now);
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

            return a;
        }
    }
}
