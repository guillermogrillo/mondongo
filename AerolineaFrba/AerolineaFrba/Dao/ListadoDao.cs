using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    class ListadoDao
    {

        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");

        public List<Model.ListadoDestinoModel> listarDestinosMasVendidos(int año, int semestre)
        {
            List<Model.ListadoDestinoModel> destinos = new List<Model.ListadoDestinoModel>();
            Model.ListadoDestinoModel destino = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                String query =  "select top 5 c.nombre, count(c.nombre) as cantidad, (case when month(ve.venta_fecha_compra) between 1 and 6 then 1 else 2 end) as semestre "+
                                "from mondongo.pasajes p  "+
                                "inner join mondongo.ventas ve on p.pasaje_venta_pnr = ve.venta_pnr  "+
                                "inner join mondongo.viajes vi on vi.viaje_id = ve.venta_viaje_id  "+
                                "inner join mondongo.rutas r on vi.viaje_ruta_id = r.id_ruta  "+
                                "inner join mondongo.ciudades c on c.id_ciudad = r.id_ciudad_destino  "+
                                "group by c.nombre, (case when month(ve.venta_fecha_compra) between 1 and 6 then 1 else 2 end),year(ve.venta_Fecha_compra)  "+
                                "having (case when month(ve.venta_fecha_compra) between 1 and 6 then 1 else 2 end) = @semestre and year(ve.venta_Fecha_compra) = @año " +
                                "order by count(c.nombre) desc";                
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@año", año);
                    command.Parameters.AddWithValue("@semestre", semestre);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var destinoNombre = reader.GetString(0);
                        var destinoCantidad = reader.GetInt32(1);
                        destino = new Model.ListadoDestinoModel(destinoNombre, destinoCantidad);
                        destinos.Add(destino);                        
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
            return destinos;
        }


        public List<Model.ListadoDestinoModel> listarDestinosConAeronavesMasVacias(int año, int semestre)
        {
            List<Model.ListadoDestinoModel> destinos = new List<Model.ListadoDestinoModel>();
            Model.ListadoDestinoModel destino = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                String query = "select top 5 dif.nombre, min(dif.diferencia) as diferencia_minima " +
                                "from " +
                                "(select c.nombre, (case when month(vi.fecha_salida) between 1 and 6 then 1 else 2 end) as semestre, (a.cantidad_butacas_ven + a.cantidad_butacas_pas)-(vi.cantidad_butacas_ventanilla_disponibles + vi.cantidad_butacas_pasillo_disponibles) as diferencia " +
                                "from mondongo.viajes vi " +
                                "inner join mondongo.aeronaves a on vi.aeronave_matricula = a.matricula " +
                                "inner join mondongo.rutas r on vi.viaje_ruta_id = r.id_ruta " +
                                "inner join mondongo.ciudades c on c.id_ciudad = r.id_ciudad_destino " +
                                "where (case when month(vi.fecha_salida) between 1 and 6 then 1 else 2 end) = @semestre " +
                                "and year(vi.fecha_salida) = @año) dif " +
                                "group by dif.nombre " +
                                "order by diferencia_minima asc";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@año", año);
                    command.Parameters.AddWithValue("@semestre", semestre);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var destinoNombre = reader.GetString(0);
                        var destinoCantidad = (int)(double)reader.GetDecimal(1);
                        destino = new Model.ListadoDestinoModel(destinoNombre, destinoCantidad);
                        destinos.Add(destino);
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
            return destinos;
        }

        public List<Model.ListadoDestinoModel> listarDestinosConMasPasajesCancelados(int año, int semestre)
        {
            List<Model.ListadoDestinoModel> destinos = new List<Model.ListadoDestinoModel>();
            Model.ListadoDestinoModel destino = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select top 5 c.nombre , count(c.nombre) as cantidad " +
                        "from mondongo.devoluciones d " +
                        "inner join mondongo.ventas ve on ve.venta_pnr = d.venta_pnr " +
                        "inner join mondongo.viajes vi on vi.viaje_id = ve.venta_viaje_id " +
                        "inner join mondongo.rutas r on r.id_ruta = vi.viaje_ruta_id " +
                        "inner join mondongo.ciudades c on c.id_ciudad = r.id_ciudad_destino " +
                        "group by c.nombre, case when month(vi.fecha_salida) between 1 and 6 then 1 else 2 end, year(vi.fecha_salida) " +
                        "having (case when month(vi.fecha_salida) between 1 and 6 then 1 else 2 end) = @semestre  " +
                        "and year(vi.fecha_salida) = @año  " +
                        "order by cantidad desc ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@año", año);
                    command.Parameters.AddWithValue("@semestre", semestre);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var destinoNombre = reader.GetString(0);
                        var destinoCantidad = reader.GetInt32(1);
                        destino = new Model.ListadoDestinoModel(destinoNombre, destinoCantidad);
                        destinos.Add(destino);
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
            return destinos;                       
        }


        public List<Model.ListadoClienteModel> listarClientes(int año, int semestre)
        {

            List<Model.ListadoClienteModel> clientes = new List<Model.ListadoClienteModel>();            
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select top 5 c.cliente_id, suma.cliente_nombre, suma.cliente_apellido, (suma.cantidad - resta.cantidad) as cantidad_total "+
                            "from mondongo.historial_millas hm "+
                            "inner join mondongo.clientes c on hm.id_cliente = c.cliente_id, "+
	                        "    (select		c.cliente_id, c.cliente_nombre, c.cliente_apellido, sum(millas) as cantidad, (case when month(fecha_operacion) between 1 and 6 then 1 else 2 end) as semestre  "+
	                        "    from		mondongo.historial_millas hm "+
	                        "    inner join mondongo.clientes c on hm.id_cliente = c.cliente_id "+
	                        "    group by	c.cliente_id, c.cliente_nombre, c.cliente_apellido, tipo_operacion, (case when month(fecha_operacion) between 1 and 6 then 1 else 2 end),year(fecha_operacion) "+
	                        "    having		tipo_operacion = 1  "+
				            "                and (case when month(fecha_operacion) between 1 and 6 then 1 else 2 end) = @semestre  "+
				            "                and year(fecha_operacion) = @año ) suma, "+
	                        "    (select		c.cliente_id, c.cliente_nombre, c.cliente_apellido, sum(millas) as cantidad, (case when month(fecha_operacion) between 1 and 6 then 1 else 2 end) as semestre  "+
	                        "    from		mondongo.historial_millas hm "+
	                        "    inner join mondongo.clientes c on hm.id_cliente = c.cliente_id "+
	                        "    group by	c.cliente_id, c.cliente_nombre, c.cliente_apellido, tipo_operacion, (case when month(fecha_operacion) between 1 and 6 then 1 else 2 end),year(fecha_operacion) "+
	                        "    having		tipo_operacion =2  "+
                            "                and (case when month(fecha_operacion) between 1 and 6 then 1 else 2 end) = @semestre  " +
                            "                and year(fecha_operacion) = @año ) resta " +
                            "group by c.cliente_id, suma.cliente_nombre, suma.cliente_apellido, suma.cliente_id, suma.cantidad, resta.cliente_id, resta.cantidad "+
                            "having c.cliente_id = suma.cliente_id and c.cliente_id = resta.cliente_id " +
                            "order by cantidad_total desc";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@año", año);
                    command.Parameters.AddWithValue("@semestre", semestre);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var idCliente = (int)(double)reader.GetDecimal(0);
                        var nombreCliente = reader.GetString(1);
                        var apellidoCliente = reader.GetString(2);
                        var cantidad = (double)reader.GetDecimal(3);
                        clientes.Add(new Model.ListadoClienteModel(idCliente, nombreCliente, apellidoCliente, cantidad));
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

            return clientes;
        }

        public List<Model.AeronaveModel> listarAeronaves(int año, int semestre)
        {
            List<Model.AeronaveModel> aeronaves = new List<Model.AeronaveModel>();
            
            Model.AeronaveModel aeronave = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select top 5	aeronave_matricula, "+
                            "sum(datediff(DAY,fecha_reinicio_servicio,fecha_fuera_servicio)) as cantidad_dias " +
	                        "from			MONDONGO.aeronaves_bajas "+
	                        "group by		aeronave_matricula "+
	                        "order by		cantidad_dias desc";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@año", año);
                    command.Parameters.AddWithValue("@semestre", semestre);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var destinoNombre = reader.GetString(0);
                        var destinoCantidad = reader.GetInt32(1);
                        aeronave = new Model.AeronaveModel();
                        aeronaves.Add(aeronave);
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


    }
}
