using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using System.Net.NetworkInformation;

namespace EBusiness.DAL
{
    /// <summary>
    /// Summary description for DataAccessManager.
    /// </summary>
    public class DataAccessManager
    {
        #region Private Methods
        /// <summary>
        /// Return Connection String reading from Config file.
        /// </summary>
        /// <returns></returns>
        public string GetConnectionString()
        {
            string connStr = string.Empty;
            string IntailCatelog = string.Empty;
            try
            {
                connStr = ConfigurationManager.ConnectionStrings["EBusinessConnectionString"].ConnectionString;
                //IntailCatelog = connStr.Replace("EBusiness","0019D28DC709");
                //IntailCatelog = connStr.Replace("EBusiness",GetMacAddress());
            }
            catch (Exception ex)
            {
                //Logger.LogException(ex, "ManageXDAL", "DAL", 0);
                throw ex;
            }
            return connStr;
        }
        /// <summary>
        /// Initialize SQLConnection based on the Connection string
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetMasterConnection()
        {
            SqlConnection conn = null;
            string connStr = GetConnectionString();
            connStr = connStr.Replace("EBusiness", "master");
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
            }
            catch (Exception ex)
            {
                //Logger.LogException("DAL", "GetConnection", ex);
                // Logger.LogException(ex, "ManageXDAL", "DAL", 0);
                throw ex;
            }
            return conn;
        }

        /// <summary>
        /// Initialize SQLConnection based on the Connection string
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            SqlConnection conn = null;
            string connStr = GetConnectionString();
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
            }
            catch (Exception ex)
            {
                //Logger.LogException("DAL", "GetConnection", ex);
               // Logger.LogException(ex, "ManageXDAL", "DAL", 0);
                throw ex;
            }
            return conn;
        }
        /// <summary>
        /// Intialize SQL Command based on the SQL Connection
        /// </summary>
        /// <returns></returns>
        /// 

        private SqlCommand GetCommand()
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection conn = GetConnection();
                cmd = new SqlCommand();
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {
                //Logger.LogException("DAL", "GetCommand", ex);
               // Logger.LogException(ex, "ManageXDAL", "DAL", 0);
                throw ex;
            }
            return cmd;
        }
        /// <summary>
        /// Prepares SQlCommand with provioded Command Type, Command Name and the Parameters.
        /// </summary>
        /// <param name="commandType">Type of Command</param>
        /// <param name="commandText">SQL command</param>
        /// <param name="commandParams">Parameters if required to execute the command text</param>
        /// <returns></returns>
        private SqlCommand PrepareCommand(CommandType commandType, string commandText, string[,] commandParams)
        {
            SqlCommand cmd = null;
            try
            {
                cmd = GetCommand();
                cmd.CommandType = commandType;
                cmd.CommandText = commandText;
                try
                {
                    string cmdTimeOut = ConfigurationManager.AppSettings["CommandTimeout"];
                    if (!string.IsNullOrEmpty(cmdTimeOut))
                    {
                        int to = 0;
                        int.TryParse(cmdTimeOut, out to);
                        cmd.CommandTimeout = to;
                    }
                }
                catch (Exception cex)
                {
                    //Logger.LogException("DAL", "PrepareCommand", cex);
                   // Logger.LogException(cex, "ManageXDAL", "MDXDAL", 0);
                    throw cex;

                }
                if (commandParams != null && commandParams.Length > 0)
                {
                    // We suppose its a two dimentional array of parameters
                    int count = commandParams.Length / 2;
                    for (int i = 0; i < count; i++)
                    {
                        string pName = commandParams[i, 0];
                        string pValue = commandParams[i, 1];
                        cmd.Parameters.Add(new SqlParameter(pName, pValue));
                    }
                }
            }
            catch (Exception ex)
            {
                //Logger.LogException("DAL", "PrepareCommand", ex);
               // Logger.LogException(ex, "ManageXDAL", "MDXDAL", 0);
                throw ex;
            }
            return cmd;
        }
        #endregion



        #region Public Methods
        /// <summary>
        /// Overload with out Parameters
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public int ExecuteNonQueryOnMaster(CommandType commandType, string commandText)
        {
            SqlConnection conn = GetMasterConnection();
            if (conn.State != ConnectionState.Open)
                conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = commandText;
            cmd.CommandType = commandType;
            return cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// Overload with out Parameters
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(CommandType commandType, string commandText)
        {
            return ExecuteNonQuery(commandType, commandText, null);
        }
        /// <summary>
        /// Perform Execute Non Query on the Command and parameters provided
        /// </summary>
        /// <param name="commandType">Type of Command</param>
        /// <param name="commandText">SQL command</param>
        /// <param name="commandParams">Parameters if required to execute the command text</param>
        /// <returns></returns>
        public int ExecuteNonQuery(CommandType commandType, string commandText, string[,] commandParams)
        {
            int result = -1;
            SqlCommand cmd = PrepareCommand(commandType, commandText, commandParams);
            try
            {

                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Logger.LogException("DAL", "ExecuteNonQuery", ex);
               // Logger.LogException(ex, "ManageXDAL", "MDXDAL", 0);
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
            return result;
        }

        public SqlCommand GetSQLCommand()
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection conn = GetConnection();
                cmd = new SqlCommand();
                cmd.Connection = conn;
            }
            catch (Exception ex)
            {
                //Logger.LogException("DAL", "GetCommand", ex);
               // Logger.LogException(ex, "ManageXDAL", "DAL", 0);
                throw ex;
            }
            return cmd;
        }

        /// <summary>
        /// ExecuteScalar Overload with out Command Parameters
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public object ExecuteScalar(CommandType commandType, string commandText)
        {
            return ExecuteScalar(commandType, commandText, null);
        }
        /// <summary>
        /// Perform Execute Scalar on the Command and parameters provided
        /// </summary>
        /// <param name="commandType">Type of Command</param>
        /// <param name="commandText">SQL command</param>
        /// <param name="commandParams">Parameters if required to execute the command text</param>
        /// <returns>object</returns>
        public object ExecuteScalar(CommandType commandType, string commandText, string[,] commandParams)
        {
            SqlCommand cmd = PrepareCommand(commandType, commandText, commandParams);
            object result = null;
            try
            {
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //Logger.LogException("DAL", "ExecuteScalar", ex);
               // Logger.LogException(ex, "ManageXDAL", "DAL", 0);
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
            return result;
        }
        /// <summary>
        /// ExecuteReader Overload with out Command Parameters
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public SqlDataReader ExecuteReader(CommandType commandType, string commandText)
        {
            return ExecuteReader(commandType, commandText, null);
        }
        /// <summary>
        /// Perform Execute Reader on the Command and parameters provided
        /// </summary>
        /// <param name="commandType">Type of Command</param>
        /// <param name="commandText">SQL command</param>
        /// <param name="commandParams">Parameters if required to execute the command text</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader ExecuteReader(CommandType commandType, string commandText, string[,] commandParams)
        {
            SqlDataReader result = null;
            try
            {
                SqlCommand cmd = PrepareCommand(commandType, commandText, commandParams);
                result = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                //Logger.LogException("DAL", "ExecuteReader", ex);
               // Logger.LogException(ex, "ManageXDAL", "DAL", 0);
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// GetDataRow Overload with out Command Parameters
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public DataRow GetDataRow(CommandType commandType, string commandText)
        {
            return GetDataRow(commandType, commandText, null);
        }
        /// <summary>
        /// Get Data Row based on the Command and parameters provided
        /// </summary>
        /// <param name="commandType">Type of Command</param>
        /// <param name="commandText">SQL command</param>
        /// <param name="commandParams">Parameters if required to execute the command text</param>
        /// <returns>DataRow</returns>
        public DataRow GetDataRow(CommandType commandType, string commandText, string[,] commandParams)
        {
            SqlCommand cmd = PrepareCommand(commandType, commandText, commandParams);
            DataRow result = null;
            try
            {
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                    result = dt.Rows[0];
            }
            catch (Exception ex)
            {
                //Logger.LogException("DAL", "GetDataRow", ex);
               // Logger.LogException(ex, "ManageXDAL", "DAL", 0);
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
            return result;
        }

        /// <summary>
        /// GetDataTable Overload with out Command Parameters
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public DataTable GetDataTable(CommandType commandType, string commandText, string tableName)
        {
            return GetDataTable(commandType, commandText, null, tableName);
        }
        //adnan

        /// <summary>
        /// GetDataTable Overload with out Command Parameters
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public DataTable GetDataTable(CommandType commandType, string commandText, string[,] commandParams)
        {
            return GetDataTable(commandType, commandText, commandParams,string.Empty);
        }

        /// <summary>
        /// GetDataTable Overload with out Command Parameters
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public DataTable GetDataTable(CommandType commandType, string commandText)
        {
            return GetDataTable(commandType, commandText, null,string.Empty);
        }
        /// <summary>
        /// Get Data Table based on the Command and parameters provided
        /// </summary>
        /// <param name="commandType">Type of Command</param>
        /// <param name="commandText">SQL command</param>
        /// <param name="commandParams">Parameters if required to execute the command text</param>
        /// <returns>DataTable</returns>
        public DataTable GetDataTable(CommandType commandType, string commandText, string[,] commandParams, string tableName)
        {
            SqlCommand cmd = PrepareCommand(commandType, commandText, commandParams);
            DataTable result = new DataTable();
            try
            {
                if (string.IsNullOrEmpty(tableName))
                    tableName = "Table1";
                result.TableName = tableName;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
            }
            catch (Exception ex)
            {
                //Logger.LogException("DAL", "GetDataTable", ex);
               // Logger.LogException(ex, "ManageXDAL", "DAL", 0);
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
            return result;
        }

        /// <summary>
        /// GetDataSet Overload with out Command Parameters
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="commandText"></param>
        /// <returns></returns>
        public DataSet GetDataSet(CommandType commandType, string commandText)
        {
            return GetDataSet(commandType, commandText, null);
        }
        /// <summary>
        /// Get Data Set based on the Command and parameters provided
        /// </summary>
        /// <param name="commandType">Type of Command</param>
        /// <param name="commandText">SQL command</param>
        /// <param name="commandParams">Parameters if required to execute the command text</param>
        /// <returns>DataSet</returns>
        public DataSet GetDataSet(CommandType commandType, string commandText, string[,] commandParams)
        {
            SqlCommand cmd = PrepareCommand(commandType, commandText, commandParams);
            DataSet result = new DataSet();
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(result);
            }
            catch (Exception ex)
            {
                //Logger.LogException("DAL", "GetDataSet", ex);
               // Logger.LogException(ex, "ManageXDAL", "DAL", 0);
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Dispose();
            }
            return result;
        }
        public static string GetMacAddress()
        {
            string macAddresses = "";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddresses;

        }
        #endregion

    }// end class
}
