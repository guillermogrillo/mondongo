﻿using System;
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
                        Model.Estado rolHabilitado = (Model.Estado)reader.GetInt32(2);                                                
                        rol = new Model.RolModel(rolId,rolNombre,rolHabilitado);
                        roles.Add(rol);

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
            return roles;
        }

        public Boolean agregarNuevoRol(String nombreDelRol)
        {
            Boolean agregado = false;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "INSERT INTO MONDONGO.ROLES(rol_nombre)" +
                            "VALUES(@nombreDelRol) ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@nombreDelRol", nombreDelRol);
                }

                var cantidadInsertada = command.ExecuteNonQuery();

                agregado = Convert.ToBoolean(cantidadInsertada);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
            return agregado;
        }

        public Boolean modificarRol(Model.RolModel rolModel)
        {
            Boolean modificado = false;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "UPDATE MONDONGO.ROLES " +
                            "SET rol_habilitado = @rolEstado, rol_nombre = @rolNombre "+
                            "WHERE rol_id = @rolId ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@rolId", rolModel._rolId);
                    command.Parameters.AddWithValue("@rolEstado", rolModel._rolHabilitado);
                    command.Parameters.AddWithValue("@rolNombre", rolModel._rolNombre);
                }

                var cantidadModificada = command.ExecuteNonQuery();

                modificado = Convert.ToBoolean(cantidadModificada);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }
            return modificado;
        }

        public List<Model.FuncionalidadModel> buscarFuncionalidadesDelRol(int rolId, Boolean faltantes)
        {
            List<Model.FuncionalidadModel> funcionalidades = new List<Model.FuncionalidadModel>();
            Model.FuncionalidadModel funcionalidad = null;
            SqlConnection myConnection = null;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                String query = null;
                if (faltantes)
                {
                    query = "select f.funcionalidad_id, f.funcionalidad_nombre, f.funcionalidad_descripcion "+
                            "from mondongo.funcionalidades f "+
                            "where f.funcionalidad_id not in( " +
                            "select rf.funcionalidad_id from mondongo.roles_funcionalidades rf "+
                            "where rf.rol_id = @rolId) ";
                }
                else
                {

                    query = "select f.funcionalidad_id, f.funcionalidad_nombre, f.funcionalidad_descripcion " +
                            "from mondongo.funcionalidades f " +
                            "join mondongo.roles_funcionalidades rf on rf.funcionalidad_id = f.funcionalidad_id " +
                            "where rf.rol_id = @rolId ";
                }
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
            finally
            {
                myConnection.Close();
            }
            return funcionalidades;
        }

        public Boolean agregarFuncionalidadAlRol(int funcionalidadId, int rolId)
        {
            SqlConnection myConnection = null;
            Boolean agregada = false;
            try
            {
                myConnection = new SqlConnection(stringConexion);
                myConnection.Open();
                SqlCommand command = null;
                var query = "INSERT INTO MONDONGO.ROLES_FUNCIONALIDADES(rol_id,funcionalidad_id) " +
                            "VALUES(@rolId,@funcionalidadId) ";
                using (command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@rolId", rolId);
                    command.Parameters.AddWithValue("@funcionalidadId", funcionalidadId);
                }

                var cantidadAgregada = command.ExecuteNonQuery();

                agregada = Convert.ToBoolean(cantidadAgregada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }

            return agregada;
        }

        public Boolean borrarFuncionalidadDelRol(int funcionalidadId, int rolId)
        {
            SqlConnection myConnection = null;
            Boolean borrado = false;
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

                var cantidadBorrada = command.ExecuteNonQuery();

                borrado = Convert.ToBoolean(cantidadBorrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            finally
            {
                myConnection.Close();
            }

            return borrado;
        }


    }
}
