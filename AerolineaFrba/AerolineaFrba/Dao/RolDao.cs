using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Dao
{
    class RolDao
    {
        String stringConexion = System.Configuration.ConfigurationManager.AppSettings.Get("stringConexion");

        public List<Model.RolModel> buscarTodosLosRoles()
        {

            List<Model.RolModel> roles = new List<Model.RolModel>();
            Model.RolModel rol = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "SELECT rol_id, rol_nombre, rol_habilitado " +
                            "FROM MONDONGO.ROLES ";
                command = new SqlCommand(query, myConnection);       
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var rolId = (int)(double)reader.GetDecimal(0);
                        var rolNombre = reader.GetString(1);
                        Boolean rolHabilitado = Convert.ToBoolean(reader.GetInt32(2));                        
                        var funcionalidades = buscarFuncionalidades(rolId);
                        rol = new Model.RolModel(rolId,rolNombre,rolHabilitado,funcionalidades);
                        roles.Add(rol);

                    }
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            return roles;
        }


        public List<Model.FuncionalidadModel> buscarFuncionalidades(int rolId)
        {
            List<Model.FuncionalidadModel> funcionalidades = new List<Model.FuncionalidadModel>();
            Model.FuncionalidadModel funcionalidad = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "select f.funcionalidad_id, f.funcionalidad_nombre, f.funcionalidad_descripcion " +
                            "from mondongo.funcionalidades f " +
                            "join mondongo.roles_funcionalidades rf on rf.funcionalidad_id = f.funcionalidad_id " +
                            "where rf.rol_id = @rolId";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@rolId", rolId);                    
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        var funcionalidadId = (int)(double)reader.GetDecimal(0);
                        var funcionalidadNombre = reader.GetString(1);
                        var funcionalidadDescripcion = reader.GetString(2);
                        funcionalidad = new Model.FuncionalidadModel(funcionalidadId, funcionalidadNombre, funcionalidadDescripcion);
                        funcionalidades.Add(funcionalidad);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            return funcionalidades;
        }


        public void quitarFuncionalidadDelRol(int funcionalidadId, int rolId)
        {
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "delete from mondongo.roles_funcionalidades "+
                            "where rol_id = @rolId and funcionalidad_id=@funcionalidadId";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@rolId", rolId);
                    command.Parameters.AddWithValue("@funcionalidadId", funcionalidadId);
                }
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }


    }
}
