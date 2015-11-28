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
        DateTime fechaSistema = Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings.Get("fechaSistema"));


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
                var query = "select	v.viaje_id,v.fecha_salida, v.fecha_llegada, v.fecha_llegada_estimada, c1.nombre, c2.nombre, " +
                            "ts.tipo_servicio,v.aeronave_matricula, v.cantidad_butacas_pasillo_disponibles as cantidad_butacas_pasillo, v.cantidad_butacas_ventanilla_disponibles as cantidad_butacas_ventanilla, " +
                            "v.cantidad_kg_disponibles " +
                            "from	mondongo.viajes v " +
                            "join mondongo.rutas r on r.id_ruta = v.viaje_ruta_id " +
                            "join mondongo.ciudades c1 on c1.id_ciudad = r.id_ciudad_origen " +
                            "join mondongo.ciudades c2 on c2.id_ciudad = r.id_ciudad_destino " +
                            "join mondongo.tipos_servicio ts on ts.id_tipo_servicio = r.id_tipo_servicio " +
                            "where	r.id_ruta = @idRuta " +
                            "and (v.cantidad_butacas_pasillo_disponibles + v.cantidad_butacas_ventanilla_disponibles) > @cantidadPax " +
                            "and cantidad_kg_disponibles > @kg " +
                            "and Convert(date, fecha_salida) = @fechaViaje " +
                            "and Convert(date, fecha_salida) > @fechaSistema "+
                            "order by v.fecha_salida asc";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idRuta", idRuta);                    
                    command.Parameters.AddWithValue("@fechaViaje", fechaViaje.Date);
                    command.Parameters.AddWithValue("@cantidadPax", cantidadPax);
                    command.Parameters.AddWithValue("@kg", kg);
                    command.Parameters.AddWithValue("@fechaSistema", fechaSistema);                    
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var idViaje = (int)(double)reader.GetDecimal(0);
                        var fechaSalida = reader.GetDateTime(1);                        
                        var fechaLlegadaEstimada = reader.GetDateTime(2);                        
                        var ciudadOrigen = reader.GetString(3);
                        var ciudadDestino = reader.GetString(4);
                        var tipoServicio = reader.GetString(5);
                        var aeronaveMatricula = reader.GetString(6);
                        var cantidadButacasPasillo = (int)(double)reader.GetDecimal(7);
                        var cantidadButacasVentanilla = (int)(double)reader.GetDecimal(8);
                        var cantidadKgDisponibles = (int)(double)reader.GetDecimal(9);

                        viaje = new Model.ViajeModel(idViaje, fechaSalida, fechaLlegadaEstimada, ciudadOrigen, ciudadDestino, tipoServicio, aeronaveMatricula, cantidadButacasPasillo, cantidadButacasVentanilla, cantidadKgDisponibles);                        
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

        public void actualizarAeronaveViajes(String matriculaVieja, String matriculaNueva, DateTime fechaDesde, DateTime fechaHasta)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "update mondongo.viajes "+
                            "set aeronave_matricula=@matriculaNueva "+
                            "where aeronave_matricula=@matriculaVieja "+
                            "  and fecha_salida between @fechaDesde and @fechaHasta ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matriculaNueva", matriculaNueva);
                    command.Parameters.AddWithValue("@matriculaVieja", matriculaVieja);
                    command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    command.Parameters.AddWithValue("@fechaHasta", fechaHasta);
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        public void cancelarViajesAeronave(String matricula, DateTime fechaDesde, DateTime fechaHasta)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "update mondongo.viajes " +
                            "set estado = 1 " +
                            "where aeronave_matricula=@matricula "+
                            "   and fecha_salida between @fechaDesde and @fechaHasta ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    command.Parameters.AddWithValue("@fechaHasta", fechaHasta);
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        public List<Model.ViajeModel> buscarViajes(int idRuta, String matricula, DateTime fechaSalidaFiltro)
        {
            List<Model.ViajeModel> viajes = new List<Model.ViajeModel>();
            Model.ViajeModel viaje = null;
            SqlConnection myConnection = null;

            string fechaSalidaFormateado = fechaSalidaFiltro.ToString("dd/MM/yyyy");
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select	v.viaje_id, v.fecha_salida, v.fecha_llegada_estimada, c1.nombre, c2.nombre, " +
                            "ts.tipo_servicio,v.aeronave_matricula, v.cantidad_butacas_pasillo_disponibles as cantidad_butacas_pasillo, v.cantidad_butacas_ventanilla_disponibles as cantidad_butacas_ventanilla, " +
                            "v.cantidad_kg_disponibles " +
                            "from	mondongo.viajes v " +
                            "join mondongo.rutas r on r.id_ruta = v.viaje_ruta_id " +
                            "join mondongo.ciudades c1 on c1.id_ciudad = r.id_ciudad_origen " +
                            "join mondongo.ciudades c2 on c2.id_ciudad = r.id_ciudad_destino " +
                            "join mondongo.tipos_servicio ts on ts.id_tipo_servicio = r.id_tipo_servicio " +
                            "where	r.id_ruta = @idRuta " +
                            "and v.aeronave_matricula = @matricula "+
                            "and CONVERT(VARCHAR(10),v.fecha_salida,103) = @fechaSalida " +
                            "and v.estado = 0 "+
                            "order by v.fecha_salida asc";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idRuta", idRuta);
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaSalida", fechaSalidaFormateado);                    
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var idViaje = (int)(double)reader.GetDecimal(0);
                        var fechaSalida = reader.GetDateTime(1);                        
                        var fechaLlegadaEstimada = reader.GetDateTime(2);
                        var ciudadOrigen = reader.GetString(3);
                        var ciudadDestino = reader.GetString(4);
                        var tipoServicio = reader.GetString(5);
                        var aeronaveMatricula = reader.GetString(6);
                        var cantidadButacasPasillo = (int)(double)reader.GetDecimal(7);
                        var cantidadButacasVentanilla = (int)(double)reader.GetDecimal(8);
                        var cantidadKgDisponibles = (int)(double)reader.GetDecimal(9);

                        viaje = new Model.ViajeModel(idViaje, fechaSalida, fechaLlegadaEstimada, ciudadOrigen, ciudadDestino, tipoServicio, aeronaveMatricula, cantidadButacasPasillo, cantidadButacasVentanilla, cantidadKgDisponibles);
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


        public Boolean actualizarViaje(Model.ViajeModel viaje)
        {
            Boolean modificado = false;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "UPDATE MONDONGO.VIAJES " +
                            "SET fecha_llegada = @fechaLlegada, estado = 2 "+
                            "WHERE viaje_id = @idViaje";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@fechaLlegada", viaje.fechaHoraLlegada);
                    command.Parameters.AddWithValue("@idViaje", viaje.idViaje);
                }

                var cantidadModificada = command.ExecuteNonQuery();

                modificado = Convert.ToBoolean(cantidadModificada);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            return modificado;
        }

        public Dictionary<String,List<int>> buscarButacasDisponibles(Model.ViajeModel viajeModel)
        {
            Dictionary<String, List<int>> mapaButacasDisponibles = new Dictionary<string,List<int>>();
            int cantidadButacasVentanilla = 0;
            int cantidadButacasPasillo = 0;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select aeronaves.cantidad_butacas_pas,aeronaves.cantidad_butacas_ven " +
                            "from mondongo.aeronaves "+
                            "where matricula = @matricula ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", viajeModel.aeronaveMatricula);                    
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cantidadButacasPasillo = (int)(double)reader.GetDecimal(0);
                        cantidadButacasVentanilla = (int)(double)reader.GetDecimal(1);                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }

            List<int> butacasPasillo = cargarListaButacas(cantidadButacasPasillo);
            List<int> butacasVentanilla = cargarListaButacas(cantidadButacasVentanilla);

            List<int> butacasPasilloADescontar = buscarButacasVendidas(viajeModel.idViaje, "Pasillo");
            List<int> butacasVentanillaADescontar = buscarButacasVendidas(viajeModel.idViaje, "Ventanilla");

            List<int> butacasPasilloFinales = butacasPasillo.Except(butacasPasilloADescontar).ToList();
            List<int> butacasVentanillaFinales = butacasVentanilla.Except(butacasVentanillaADescontar).ToList();

            mapaButacasDisponibles.Add("Pasillo", butacasPasilloFinales);
            mapaButacasDisponibles.Add("Ventanilla", butacasVentanillaFinales);

            return mapaButacasDisponibles;
        }

        private List<int> buscarButacasVendidas(int idViaje, string tipoButaca)
        {
            List<int> butacasVendidas = new List<int>();
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select p.pasaje_butaca_numero " +
                            "from mondongo.pasajes p " +
                            "inner join mondongo.ventas ve on p.pasaje_venta_pnr = ve.venta_pnr " +
                            "where ve.venta_viaje_id = @idViaje " +
                            "and p.pasaje_butaca_tipo = @tipoButaca";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@idViaje", idViaje);
                    command.Parameters.AddWithValue("@tipoButaca", tipoButaca);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var numeroButaca = (int)(double)reader.GetDecimal(0);
                        butacasVendidas.Add(numeroButaca);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }

            return butacasVendidas;
        }



        private List<int> cargarListaButacas(int cantidad)
        {
            List<int> butacas = new List<int>();
            for (int i = 0; i < cantidad; i++)
            {
                butacas.Add(i);
            }
            return butacas;
        }


        public Boolean descontarButacas(int viajeId, int cantidadVentanilla, int cantidadPasillo)
        {
            Boolean modificado = false;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "UPDATE MONDONGO.VIAJES " +
                            "SET cantidad_butacas_ventanilla_disponibles = cantidad_butacas_ventanilla_disponibles - @cantidadVentanilla, " +
                            "cantidad_butacas_pasillo_disponibles = cantidad_butacas_pasillo_disponibles - @cantidadPasillo " +
                            "WHERE viaje_id = @viajeId ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@cantidadVentanilla", cantidadVentanilla);
                    command.Parameters.AddWithValue("@cantidadPasillo", cantidadPasillo);
                    command.Parameters.AddWithValue("@viajeId", viajeId);
                }

                var cantidadModificada = command.ExecuteNonQuery();

                modificado = Convert.ToBoolean(cantidadModificada);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            return modificado;
        }


        public Boolean descontarKg(int viajeId, int kg)
        {
            Boolean modificado = false;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "UPDATE MONDONGO.VIAJES " +
                            "SET cantidad_kg_disponibles = cantidad_kg_disponibles - @kg " +                            
                            "WHERE viaje_id = @viajeId ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@kg", kg);                   
                    command.Parameters.AddWithValue("@viajeId", viajeId);
                }

                var cantidadModificada = command.ExecuteNonQuery();

                modificado = Convert.ToBoolean(cantidadModificada);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            return modificado;
        }

        public Boolean guardarViaje(Model.ViajeModel viaje, Model.RutaModel ruta, Model.AeronaveModel aeronave)
        {
            Boolean guardado = false;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "insert into mondongo.viajes (viaje_ruta_id, aeronave_matricula, fecha_salida, fecha_llegada_estimada, cantidad_butacas_ventanilla_disponibles, cantidad_butacas_pasillo_disponibles, cantidad_kg_disponibles) "+
                            "values (@rutaId, @aeronaveMatricula, @fechaSalida, @fechaLlegadaEstimada, @cantidadVentanilla, @cantidadPasillo, @cantidadKg)";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@rutaId", ruta.idRuta);
                    command.Parameters.AddWithValue("@aeronaveMatricula", viaje.aeronaveMatricula);
                    command.Parameters.AddWithValue("@fechaSalida", viaje.fechaHoraSalida);
                    command.Parameters.AddWithValue("@fechaLlegadaEstimada", viaje.fechaHoraLlegadaEstimada);
                    command.Parameters.AddWithValue("@cantidadVentanilla", aeronave.cantButacasVen);
                    command.Parameters.AddWithValue("@cantidadPasillo", aeronave.cantButacasPas);
                    command.Parameters.AddWithValue("@cantidadKg", aeronave.capacidadKg);
                }

                var cantidadModificada = command.ExecuteNonQuery();

                guardado = Convert.ToBoolean(cantidadModificada);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            return guardado;

        }

        public List<Model.PasajeModel> pasajesParaDevolucion(string matricula, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Model.PasajeModel> pasajes = new List<Model.PasajeModel>();
            Model.PasajeModel pasaje = null;
            SqlConnection myConnection = null;

            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select	p.pasaje_venta_pnr, p.pasaje_id " +
                            "from	mondongo.viajes v, MONDONGO.ventas vta, MONDONGO.pasajes p "+
                            "where	v.aeronave_matricula = @matricula "+
	                        "    and v.viaje_id=vta.venta_viaje_id "+
	                        "    and vta.venta_pnr = p.pasaje_venta_pnr "+
                            "    and v.fecha_salida between @fechaDesde and @fechaHasta " +
	                        "    and v.estado = 0 ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    command.Parameters.AddWithValue("@fechaHasta", fechaHasta);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pnr = (int)(double)reader.GetDecimal(0);
                        var pasajeId = (int)(double)reader.GetDecimal(1);

                        pasaje = new Model.PasajeModel();
                        pasaje.pasajePnr = pnr;
                        pasaje.pasajeId = pasajeId;

                        pasajes.Add(pasaje);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }

            return pasajes;
        }

        public List<Model.PaqueteModel> paquetesParaDevolucion(string matricula, DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Model.PaqueteModel> paquetes = new List<Model.PaqueteModel>();
            Model.PaqueteModel paquete = null;
            SqlConnection myConnection = null;

            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select	p.paquete_venta_pnr, p.paquete_id " +
                            "from	mondongo.viajes v, MONDONGO.ventas vta, MONDONGO.paquetes p " +
                            "where	v.aeronave_matricula = @matricula " +
                            "    and v.viaje_id=vta.venta_viaje_id " +
                            "    and vta.venta_pnr = p.paquete_venta_pnr " +
                            "    and v.fecha_salida between @fechaDesde and @fechaHasta " +
                            "    and v.estado = 0 ";

                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);
                    command.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                    command.Parameters.AddWithValue("@fechaHasta", fechaHasta);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pnr = (int)(double)reader.GetDecimal(0);
                        var pasajeId = (int)(double)reader.GetDecimal(1);

                        paquete = new Model.PaqueteModel();
                        paquete.paquetePnr = pnr;
                        paquete.paqueteId = pasajeId;

                        paquetes.Add(paquete);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }

            return paquetes;
        }
    }
}
