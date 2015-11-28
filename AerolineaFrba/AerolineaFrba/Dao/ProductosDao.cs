using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    public class ProductosDao
    {

        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");

        public List<Model.ProductoModel> buscarTodosLosProductos()
        {
            List<Model.ProductoModel> productos = new List<Model.ProductoModel>();
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select id_producto, stock, descripcion, costo_millas "+
                            "from mondongo.productos";

                command = new SqlCommand(query, myConnection); 
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var idProducto = (int)(double)reader.GetDecimal(0);
                        var stock = (int)(double)reader.GetDecimal(1);
                        var descripcion = reader.GetString(2);
                        var costoMillas = (int)(double)reader.GetDecimal(3);                        
                        productos.Add(new Model.ProductoModel(idProducto, stock, descripcion, costoMillas));
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
            return productos;
        }



    }
}
