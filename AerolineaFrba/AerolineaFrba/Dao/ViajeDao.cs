using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    class ViajeDao
    {
        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");


        public List<Model.ViajeModel> buscarViajes(int idRuta, DateTime fechaViaje, int cantidadPax, int kg)
        {
            List<Model.ViajeModel> viajes = new List<Model.ViajeModel>();
            Model.ViajeModel viaje = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select	v.viaje_id, CONVERT(VARCHAR(10),v.fecha_salida,101), CONVERT(VARCHAR(5),v.fecha_salida,108), c1.nombre, c2.nombre, " +
                            "ts.tipo_servicio, v.cantidad_butacas_pasillo_disponibles + v.cantidad_butacas_ventanilla_disponibles as cantidad_butacas, " +
                            "v.cantidad_kg_disponibles " +
                            "from	mondongo.viajes v " +
                            "join mondongo.rutas r on r.id_ruta = v.viaje_ruta_id " +
                            "join mondongo.ciudades c1 on c1.id_ciudad = r.id_ciudad_origen " +
                            "join mondongo.ciudades c2 on c2.id_ciudad = r.id_ciudad_destino " +
                            "join mondongo.tipos_servicio ts on ts.id_tipo_servicio = r.id_tipo_servicio " +
                            "where	r.id_ruta = @idRuta " +
                            "and (v.cantidad_butacas_pasillo_disponibles + v.cantidad_butacas_ventanilla_disponibles) > @cantidadPax " +
                            "and cantidad_kg_disponibles > @kg " +
                            "and fecha_salida > @fechaViaje " +
                            "order by v.fecha_salida asc";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idRuta", idRuta);                    
                    command.Parameters.AddWithValue("@fechaViaje", fechaViaje);
                    command.Parameters.AddWithValue("@cantidadPax", cantidadPax);
                    command.Parameters.AddWithValue("@kg", kg);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var idViaje = (int)(double)reader.GetDecimal(0);
                        var fechaSalida = reader.GetString(1);
                        var horaSalida = reader.GetString(2);
                        var ciudadOrigen = reader.GetString(3);
                        var ciudadDestino = reader.GetString(4);
                        var tipoServicio = reader.GetString(5);
                        var cantidadButacas = (int)(double)reader.GetDecimal(6);                        
                        var cantidadKgDisponibles = (int)(double)reader.GetDecimal(7);

                        viaje = new Model.ViajeModel(idViaje, fechaSalida, horaSalida, ciudadOrigen, ciudadDestino, tipoServicio, cantidadButacas, cantidadKgDisponibles);
                        viajes.Add(viaje);                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }


            return viajes;
        }
    }
}
