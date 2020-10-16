using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoPAV.DataAccessLayer
{
    public class DataManager
    {   

        //Definimos los atributos de la clase DataManager
        private SqlConnection dbConnection;
        private static DataManager instance;

        public DataManager()
        {
            dbConnection = new SqlConnection();

            var connection = "Data Source=.\\SQLEXPRESS;Initial Catalog=BugTrackerGrupo9;Integrated Security=True";
            dbConnection.ConnectionString = connection;
        }

        public static DataManager GetInstance()
        {
            //Verifica si existe una instacia de DataManager y en caso de no existir la crea
            if (instance == null)
                instance = new DataManager();
            //Abre la conexion
            instance.Open();

            return instance;
        }

        public void Open()
        {
            //Verifica si hay una conexion abierta y abre una si no la hay
            if (dbConnection.State != ConnectionState.Open)
                dbConnection.Open();
        }


        public void Close()
        {
            //Verifica si la conexion ha sido cerrada y la cierra
            if (dbConnection.State != ConnectionState.Closed)
                dbConnection.Close();
        }
        
        public DataTable ConsultaSQL(string stringQuery, Dictionary<string, object> param = null)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = stringQuery;

                if(param != null)
                {
                    foreach (var item in param)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                tabla.Load(cmd.ExecuteReader());
                return tabla;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                this.Close();
            }

        }

        public int EjecutarSql(string stringQuery)
        {
            //creamos un SqlCommand para realizar una consulta y una transaccion instanciada como null

            int afectadas = 0;
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;
            try
            {
                //Comenzamos la transaccion

                t = dbConnection.BeginTransaction();
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = stringQuery;
                cmd.Transaction = t;

                afectadas = cmd.ExecuteNonQuery();

                //Realizamos un commit de la transaccion

                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                throw ex;
            }
            finally
            {
                this.Close();
            }
            return afectadas;

        }

        public int EjecutarSQL(string strSql, Dictionary<string, object> prs = null)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”

            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rtdo;
        }

        public int EjecutarSqlParametros(string stringQuery, Dictionary<string, object> param = null)
        {
            //creamos un SqlCommand para realizar una consulta y una transaccion instanciada como null

            int afectadas = 0;
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;
            try
            {
                //Comenzamos la transaccion

                t = dbConnection.BeginTransaction();
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = stringQuery;
                cmd.Transaction = t;

                if (param != null)
                {
                    foreach (var item in param)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                afectadas = cmd.ExecuteNonQuery();

                //Realizamos un commit de la transaccion

                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                throw ex;
            }
            finally
            {
                this.Close();
            }
            return afectadas;

        }
    }
}
