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
                String query = "select top 5 c.nombre, count(c.nombre) as cantidad, (case when month(ve.venta_fecha_compra) between 1 and 6 then 1 else 2 end) as semestre " +
                                "from mondongo.pasajes p " +
                                "inner join mondongo.ventas ve on p.pasaje_venta_pnr = ve.venta_pnr " +
                                "inner join mondongo.viajes vi on vi.viaje_id = ve.venta_viaje_id " +
                                "inner join mondongo.rutas r on vi.viaje_ruta_id = r.id_ruta " +
                                "inner join mondongo.ciudades c on c.id_ciudad = r.id_ciudad_destino " +
                                "group by c.nombre, (case when month(ve.venta_fecha_compra) between 1 and 6 then 1 else 2 end),year(ve.venta_Fecha_compra) " +
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
                String query =  "select top 5 c.nombre, count(c.id_ciudad) as cantidad_cancelaciones, (case when month(ve.venta_fecha_compra) between 1 and 6 then 1 else 2 end) as semestre "+
                                "from mondongo.pasajes p "+
                                "inner join mondongo.ventas ve on p.pasaje_venta_pnr = ve.venta_pnr " +
                                "inner join mondongo.viajes vi on vi.viaje_id = ve.venta_viaje_id "+
                                "inner join mondongo.rutas r on vi.viaje_ruta_id = r.id_ruta "+
                                "inner join mondongo.ciudades c on c.id_ciudad = r.id_ciudad_destino "+
                                "where p.estado = 1 "+
                                "group by c.nombre, (case when month(ve.venta_fecha_compra) between 1 and 6 then 1 else 2 end),year(ve.venta_Fecha_compra) "+
                                "having (case when month(ve.venta_fecha_compra) between 1 and 6 then 1 else 2 end) = @semestre and year(ve.venta_Fecha_compra) = @año "+
                                "order by cantidad_cancelaciones desc";

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
            return destinos;
        }


        public List<Model.ClienteModel> listarClientes(int año, int semestre)
        {
            List<Model.ClienteModel> clientes = new List<Model.ClienteModel>();

            return clientes;
        }

        public List<Model.AeronaveModel> listarAeronaves(int año, int semestre)
        {
            List<Model.AeronaveModel> aeronaves = new List<Model.AeronaveModel>();

            return aeronaves;
        }


    }
}
