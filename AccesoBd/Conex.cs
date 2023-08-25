namespace AccesoBd
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    public class Conex
    {
        private void AgregarParametros(string[] nomParam, object[] vlrParam, SqlCommand cmd)
        {
            for (int i = 0; i < nomParam.Length; i++)
            {
                cmd.Parameters.AddWithValue(nomParam[i], vlrParam[i]);
            }
        }

        private SqlCommand AgregarParametros(SqlCommand Comando, params Object[] Parametros)
        {
            int index = 0;
            SqlCommandBuilder.DeriveParameters(Comando);

            foreach (SqlParameter parameter in Comando.Parameters)
            {
                if (parameter.Direction == ParameterDirection.Input || parameter.Direction == ParameterDirection.InputOutput)
                {
                    parameter.Value = Parametros[index];
                    index++;
                }
            }
            return Comando;
        }

        #region Variables declaradas

        private string strStringConexion;
        private SqlConnection cnn;
        private SqlCommand cmd;

        public string StringConexion
        {
            set
            {
                strStringConexion = value;
            }
        }


        #endregion

        /// <summary>
        /// El contructor instancia un objeto conexion
        /// </summary>
        public Conex(string strCnn)
        {
            strStringConexion = strCnn;
            cnn = new SqlConnection(strStringConexion);
        }

        #region Metodos Publicos

        /// <summary>
        /// Ejecuta un sp y devuelve un dataset lleno
        /// </summary>
        /// <param name="strSQL">El nombre del sp a ejecutar</param>
        /// <param name="NombreParametros">Vector con el nombre de los parametros del sp</param>
        /// <param name="ValoresParametros">Vector con los valores de los parametros del sp</param>
        /// <returns>Dataset de la consulta realizada</returns>
        public DataSet getDataset(string strSQL, params object[] Parametros)
        {
            DataSet ds = new DataSet();
            try
            {
                if (AbrirConexion())
                {
                    cmd = cnn.CreateCommand();
                    cmd.CommandText = strSQL;
                    cmd.CommandTimeout = 99999999;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd = AgregarParametros(cmd, Parametros);
                    //AgregarParametros(NombreParametros, ValoresParametros, cmd);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds;
                }
                else
                {
                    CerrarConexion();
                    return null;
                }
            }
            catch (Exception ex)
            {
                //EscribirError(ex.ToString());
                //return (null);
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Ejecuta un sp y devuelve un dataset lleno
        /// </summary>
        /// <param name="strSQL">El nombre del sp a ejecutar</param>
        /// <returns>Dataset de la consulta realizda</returns>
        public DataSet getDataset(string strSQL)
        {
            DataSet ds = new DataSet();

            try
            {
                cmd = cnn.CreateCommand();
                cmd.CommandText = strSQL;
                cmd.CommandTimeout = 99999999;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                //EscribirError(ex.ToString());
                //return null;
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Ejecuta un sp y devuelve un datatable lleno
        /// </summary>
        /// <param name="strSQL">El nombre del sp a ejecutar</param>
        /// <returns>DataTable de la consulta realizda</returns>
        public DataTable getDataTable(string strSQL)
        {
            DataTable dt = new DataTable();
            try
            {
                if (AbrirConexion())
                {
                    cmd = cnn.CreateCommand();
                    cmd.CommandText = strSQL;
                    cmd.CommandTimeout = 99999999;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    CerrarConexion();
                    return null;
                }
            }
            catch (Exception ex)
            {
                //EscribirError(ex.ToString());
                //return null;
                throw new Exception(ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        /// <summary>
        /// Ejecuta un sp y devuelve un DataTable lleno
        /// </summary>
        /// <param name="strSQL">El nombre del sp a ejecutar</param>
        /// <param name="NombreParametros">Vector con el nombre de los parametros del sp</param>
        /// <param name="ValoresParametros">Vector con los valores de los parametros del sp</param>
        /// <returns>DataTable de la consulta realizada</returns>
        public DataTable getDataTable(string strSQL, params object[] Parametros)
        {
            DataTable dt = new DataTable();

            try
            {
                if (AbrirConexion())
                {
                    cmd = cnn.CreateCommand();
                    cmd.CommandText = strSQL;
                    cmd.CommandTimeout = 99999999;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd = AgregarParametros(cmd, Parametros);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
                else
                {
                    CerrarConexion();
                    return null;
                }
            }
            catch (Exception ex)
            {
                //EscribirError(ex.ToString());
                //return (null);
                throw new Exception(ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        /// <summary>
        /// Ejecuacion de consultas de Update, Insert y Delete, este metodo no devuelve resultados
        /// </summary>
        /// <param name="strSQL">El nombre del sp a ejecutar</param>
        /// <param name="NombreParametros">Vector con el nombre de los parametros del sp</param>
        /// <param name="ValoresParametros">Vector con los valores de los parametros del sp</param>
        /// <returns>retorna si pudo ejecutar la consulta</returns>
        public bool EjecutarSentencia(string strSQL, params object[] Parametros)
        {
            if (AbrirConexion())
            {
                try
                {
                    cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 99999999;
                    cmd.CommandText = strSQL;
                    cmd = AgregarParametros(cmd, Parametros);
                    cmd.ExecuteNonQuery();
                    CerrarConexion();
                    return (true);
                }
                catch (SqlException ex)
                {
                    //EscribirError(ex.ToString());
                    //return (false);
                    throw new Exception(ex.Message);
                }
                finally
                {
                    CerrarConexion();
                }
            }
            else
            {
                CerrarConexion();
                return (false);
            }
        }

        /// <summary>
        /// Ejecuta de consultas de Update, Insert y Delete, este metodo devuelve el nhumerod e filas afectadas
        /// </summary>
        /// <param name="strSQL">El nombre del sp a ejecutar</param>
        /// <param name="NombreParametros">Vector con el nombre de los parametros del sp</param>
        /// <param name="ValoresParametros">Vector con los valores de los parametros del sp</param>
        /// <returns>retorna numero de filas</returns>
        public int EjecutarSentenciaInt(string strSQL, params object[] Parametros)
        {
            int filas = 0;
            if (AbrirConexion())
            {
                try
                {
                    cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 99999999;
                    cmd.CommandText = strSQL;
                    //AgregarParametros(NombreParametros, ValoresParametros, cmd);
                    cmd = AgregarParametros(cmd, Parametros);
                    filas = cmd.ExecuteNonQuery();
                    CerrarConexion();

                }
                catch (SqlException ex)
                {
                    //EscribirError(ex.ToString());
                    throw new Exception(ex.Message);
                }
                finally
                {
                    CerrarConexion();
                }
            }
            else
            {
                CerrarConexion();
            }

            return filas;
        }
        public bool EjecutarDataTableAdjuntos(string strSQL, string[] NombreParametros, DataTable dtTable, int DocID)
        {
            if (AbrirConexion())
            {
                try
                {
                    cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 99999999;
                    //cmd.CommandText = strSQLElimina;
                    cmd.CommandText = strSQL;

                    foreach (DataRow row in dtTable.Rows)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@DocID", DocID);
                        foreach (string param in NombreParametros)
                        {
                            cmd.Parameters.AddWithValue("@" + param, row[param]);

                        }
                        cmd.ExecuteNonQuery();

                        //cmd.Parameters.AddWithValue("@adjunto", row["archivo"]);

                        //string[] NombreParametros;
                        //object[] ValoresParametros;
                        //AgregarParametros(NombreParametros, ValoresParametros, cmd);

                    }

                    //this.setParametros(cmd, getParamertos(NombreParametros, ValoresParametros));                    
                    CerrarConexion();
                    return (true);
                }
                catch (SqlException ex)
                {
                    //EscribirError(ex.ToString());
                    //return (false);
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                CerrarConexion();
                return (false);
            }
        }

        /// <summary>
        /// Ejecuacion de consultas de Update, Insert y Delete, este metodo no devuelve resultados
        /// </summary>
        /// <param name="strSQL">El nombre del sp a ejecutar</param>        
        /// <returns>retorna si pudo ejecuatar la consulta</returns>
        public bool EjecutarSentencia(string strSQL)
        {
            if (AbrirConexion())
            {
                try
                {
                    cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 99999999;
                    cmd.CommandText = strSQL;
                    cmd.ExecuteNonQuery();
                    CerrarConexion();
                    return (true);
                }
                catch (SqlException ex)
                {
                    //EscribirError(ex.ToString());
                    //return false;
                    throw new Exception(ex.Message);
                }
                finally
                {
                    CerrarConexion();
                }
            }
            else
            {
                CerrarConexion();
                return (false);
            }
        }

        /// <summary>
        /// Ejecuacion de consultas de Update, Insert y Delete, este metodo no devuelve resultados
        /// </summary>
        /// <param name="strSQL">El nombre del sp a ejecutar</param>        
        /// <returns>retorna si pudo ejecuatar la consulta</returns>
        public bool EjecutarSentenciaGenerica(string strSQL)
        {
            if (AbrirConexion())
            {
                try
                {
                    cmd = cnn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 99999999;
                    cmd.CommandText = strSQL;
                    cmd.ExecuteNonQuery();
                    CerrarConexion();
                    return (true);
                }
                catch (SqlException ex)
                {
                    //EscribirError(ex.ToString());
                    //return false;
                    throw new Exception(ex.Message);
                }
                finally
                {
                    CerrarConexion();
                }
            }
            else
            {
                CerrarConexion();
                return (false);
            }
        }


        #endregion

        #region Metodos Privados
        /// <summary>
        /// Asigna parametros a un SqlCommand
        /// </summary>
        /// <param name="setCmd">SqlCommand para la asignacion de parametros</param>
        /// <param name="setParameter">Un array de parametros SqlParameter para ser asinados</param>

        /// <summary>
        /// Metodo bool que abre una conexion con la base de datos
        /// </summary>
        /// <returns>retorna si pudo abrir la conexion</returns>
        private bool AbrirConexion()
        {
            if (strStringConexion == null)
            {
                return false;
            }
            else
            {
                try
                {
                    cnn.ConnectionString = strStringConexion;
                    cnn.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    //return false;
                    throw new Exception(ex.Message);
                }
            }
        }
        /// <summary>
        /// Cierra conexiones abiertas y elimina Objetos Instanciados 
        /// </summary>
        private void CerrarConexion()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }

        private string EscribirError(string Error)
        {
           return Error;
        }
        #endregion
    }
}
