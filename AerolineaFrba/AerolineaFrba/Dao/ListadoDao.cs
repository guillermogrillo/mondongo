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
                String query = "select top 5 a.matricula, sum(libres.cantidad) as sin_vender " +
                                "from  " +
                                "(select bv.viaje_id, count(bv.butaca_id) as cantidad " +
                                "from mondongo.butacas_viaje bv " +
                                "inner join mondongo.butacas b on b.butaca_id = bv.butaca_id " +
                                "where bv.estado = 'L' " +
                                "group by bv.viaje_id,bv.estado) libres " +
                                "inner join mondongo.viajes v on v.viaje_id = libres.viaje_id " +
                                "inner join mondongo.aeronaves a on a.matricula = v.aeronave_matricula " +
                                "where (case when month(v.fecha_salida) between 1 and 6 then 1 else 2 end) = @semestre " +
                                "and year(v.fecha_salida) = @año " +
                                "group by a.matricula " +
                                "order by sin_vender desc";
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
                var query = "select top 5 c.nombre as destino, count(*) as cantidad "+
                            "from mondongo.devoluciones d " +
                            "inner join mondongo.pasajes p on p.pasaje_id = d.id_pasaje "+
                            "inner join mondongo.ventas ve on ve.venta_pnr = p.pasaje_venta_pnr "+
                            "inner join mondongo.viajes vi on vi.viaje_id = ve.venta_viaje_id "+
                            "inner join mondongo.rutas r on r.id_ruta = vi.viaje_ruta_id "+
                            "inner join mondongo.ciudades c on c.id_ciudad = r.id_ciudad_destino "+
                            "where (case when month(d.fecha_devolucion) between 1 and 6 then 1 else 2 end) = @semestre "+
                            "and year(d.fecha_devolucion) = @año  "+
                            "group by c.nombre "+
                            "order by cantidad desc";
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
                var query = "select top 5 resultado.cliente_id, resultado.cliente_nombre, resultado.cliente_apellido, resultado.cantidad "+ 
                            "from ( " +
                            "select	isnull(suma.cliente_id, resta.cliente_id) as cliente_id,  "+
		                    "isnull(suma.cliente_nombre,resta.cliente_nombre) as cliente_nombre,  "+
		                    "isnull(suma.cliente_apellido,resta.cliente_apellido) as cliente_apellido, "+
		                    "isnull(suma.cantidad,0) - isnull(resta.cantidad,0) as cantidad "+
                            "from (select		c.cliente_id, c.cliente_nombre, c.cliente_apellido, sum(millas) as cantidad, (case when month(fecha_operacion) between 1 and 6 then 1 else 2 end) as semestre   "+
	                        "from		mondongo.historial_millas hm  "+
	                        "inner join mondongo.clientes c on hm.id_cliente = c.cliente_id  "+
	                        "group by	c.cliente_id, c.cliente_nombre, c.cliente_apellido, tipo_operacion, (case when month(fecha_operacion) between 1 and 6 then 1 else 2 end),year(fecha_operacion)  "+
	                        "having		tipo_operacion = 1   "+
                            "and (case when month(fecha_operacion) between 1 and 6 then 1 else 2 end) = @semestre   " +
                            "and year(fecha_operacion) = @año ) suma " +
                            "full outer join "+
	                        "(select		c.cliente_id, c.cliente_nombre, c.cliente_apellido, sum(millas) as cantidad, (case when month(fecha_operacion) between 1 and 6 then 1 else 2 end) as semestre   "+
	                        "from		mondongo.historial_millas hm  "+
	                        "inner join mondongo.clientes c on hm.id_cliente = c.cliente_id  "+
	                        "group by	c.cliente_id, c.cliente_nombre, c.cliente_apellido, tipo_operacion, (case when month(fecha_operacion) between 1 and 6 then 1 else 2 end),year(fecha_operacion)  "+
	                        "having		tipo_operacion =2   "+
                            "and (case when month(fecha_operacion) between 1 and 6 then 1 else 2 end) = @semestre   " +
                            "and year(fecha_operacion) = @año ) resta  " +
                            "on suma.cliente_id = resta.cliente_id "+
                            ") resultado "+
                            "order by resultado.cantidad desc";
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

        public List<Model.ListadoAeronavesModel> listarAeronaves(int año, int semestre)
        {
            List<Model.ListadoAeronavesModel> aeronaves = new List<Model.ListadoAeronavesModel>();

            Model.ListadoAeronavesModel aeronave = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select top 5 bajas.aeronave_matricula,sum(bajas.dias_baja) as suma_dias " +
                            "from( "+
                            "select ab.aeronave_matricula, DATEDIFF(DAY,ab.fecha_fuera_servicio,ab.fecha_reinicio_servicio) as dias_baja "+
                            "from mondongo.aeronaves_bajas ab "+
                            "where (case when month(ab.fecha_fuera_servicio) between 1 and 6 then 1 else 2 end) = @semestre  "+
                            "and year(ab.fecha_fuera_servicio) = @año  "+
                            ") bajas "+
                            "group by bajas.aeronave_matricula "+
                            "order by suma_dias desc";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@año", año);
                    command.Parameters.AddWithValue("@semestre", semestre);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var matricula = reader.GetString(0);
                        var cantidadDias = reader.GetInt32(1);
                        aeronave = new Model.ListadoAeronavesModel(matricula, cantidadDias);
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
