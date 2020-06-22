/* Copyright 2019 icefrog.su@qq.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using mybatis_generate_win.database;
using System;
using System.Collections.Generic;
using System.Data;

namespace mybatis_generate_win.util
{
    /// <summary>
    /// Database connect utils, implements Connector interface.
    /// </summary>
    public class DatabaseConnectorProvider : Connector
    {

        private static DatabaseConnectorProvider DEFAULT_PROVIDER = null;

        private static string IP;

        private static string PORT;

        private static string USER_NAME;

        private static string PASSWORD;

        private static DataBaseType DATABASE_TYPE;

        /// <summary>
        /// Singleton
        /// </summary>
        private DatabaseConnectorProvider() { }

        public static DatabaseConnectorProvider GetInstance(string ip, string port, string userName, string password, DataBaseType dbType)
        {
            if(DEFAULT_PROVIDER == null)
            {
                DEFAULT_PROVIDER = new DatabaseConnectorProvider();
            }
            IP = ip;
            PORT = port;
            USER_NAME = userName;
            PASSWORD = password;
            DATABASE_TYPE = dbType;
            return DEFAULT_PROVIDER;
        }

        public static DatabaseConnectorProvider ReBuildInstance(string ip, string port, string userName, string password, DataBaseType dbType)
        {
            return GetInstance(ip, port, userName, password, dbType);
        }

        public void ChangeDatabaseType(DataBaseType dbType)
        {
            DATABASE_TYPE = dbType;
        }

        /// <summary>
        /// Check if the current connection information is connected
        /// </summary>
        /// <param name="ip">Ip address</param>
        /// <param name="port">Port</param>
        /// <param name="userName">User name</param>
        /// <param name="password">Password</param>
        /// <param name="dbType">Type of DataBaseType</param>
        /// <returns>Returns true if it can connect, otherwise returns false</returns>
        public bool connect()
        {
            try
            {
                // An attempt to perform a database operation is considered incorrect if an exception is thrown
                if (DATABASE_TYPE == DataBaseType.MySql)
                {
                    MySqlConnector connector = MySqlConnector.GetInstance(IP, PORT, USER_NAME, PASSWORD, "");
                    DataTable tb = connector.ExecuteDataTable(Database.MYSQL_ALL_DATABASE_SCRIPT);
                    tb.Rows[0]["Database"].ToString();
                }
                else if (DATABASE_TYPE == DataBaseType.SqlServer)
                {
                    SqlServerConnector connector = SqlServerConnector.GetInstance(IP, USER_NAME, PASSWORD, "");
                    DataTable tb = connector.ExecuteDataTable(Database.SQLSERVER_ALL_TABLE_SCRIPT);
                    tb.Rows[0]["NAME"].ToString();
                }
                else if (DATABASE_TYPE == DataBaseType.Oracle)
                {
                    OracleConnector connector = OracleConnector.GetInstance(IP, USER_NAME, PASSWORD);
                    DataTable tb = connector.ExecuteDataTable(Database.ORACLE_ALL_USER_SCRIPT);
                    tb.Rows[0][0].ToString();
                }
                else
                {
                    // unknow database, return the false
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Load all tables list for the connection (oracle does not apply)
        /// </summary>
        /// <returns>List for all tables name</returns>
        public List<string> initAllTable(string scheme)
        {
            List<string> schemes = new List<string>();
            try
            {
                // An attempt to perform a database operation is considered incorrect if an exception is thrown
                if (DATABASE_TYPE == DataBaseType.MySql)
                {
                    MySqlConnector connector = MySqlConnector.GetInstance(IP, PORT, USER_NAME, PASSWORD, scheme);
                    DataTable tb = connector.ExecuteDataTable(Database.MYSQL_ALL_TABLES_SCRIPT);
                    for (int i = 0; i < tb.Rows.Count; i++)
                    {
                        schemes.Add(tb.Rows[i][0].ToString());
                    }
                }
                else if (DATABASE_TYPE == DataBaseType.SqlServer)
                {
                    // unsupport
                }
                else if (DATABASE_TYPE == DataBaseType.Oracle)
                {
                    // unsupport
                }
                else
                {
                    // unknow database, return the false
                }
            } catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return schemes;
        }

        /// <summary>
        /// Load all database information for this connection (oracle does not apply)
        /// </summary>
        /// <returns>List's all scheme name</returns>
        public List<string> initScheme()
        {
            List<string> schemes = new List<string>();
            try
            {
                // An attempt to perform a database operation is considered incorrect if an exception is thrown
                if (DATABASE_TYPE == DataBaseType.MySql)
                {
                    MySqlConnector connector = MySqlConnector.GetInstance(IP, PORT, USER_NAME, PASSWORD, "");
                    DataTable tb = connector.ExecuteDataTable(Database.MYSQL_ALL_DATABASE_SCRIPT);
                    for(int i = 0; i < tb.Rows.Count; i++)
                    {
                        schemes.Add(tb.Rows[i]["Database"].ToString());
                    }
                }
                else if (DATABASE_TYPE == DataBaseType.SqlServer)
                {
                    SqlServerConnector connector = SqlServerConnector.GetInstance(IP, USER_NAME, PASSWORD, "");
                    DataTable tb = connector.ExecuteDataTable(Database.SQLSERVER_ALL_TABLE_SCRIPT);
                    for (int i = 0; i < tb.Rows.Count; i++)
                    {
                        schemes.Add(tb.Rows[i]["NAME"].ToString());
                    }
                }
                else if (DATABASE_TYPE == DataBaseType.Oracle)
                {
                    OracleConnector connector = OracleConnector.GetInstance(IP, USER_NAME, PASSWORD);
                    DataTable tb = connector.ExecuteDataTable(Database.ORACLE_ALL_USER_SCRIPT);
                    for (int i = 0; i < tb.Rows.Count; i++)
                    {
                        schemes.Add(tb.Rows[i][0].ToString());
                    }
                }
                else
                {
                    // unknow database, return the false
                }
            }
            catch
            {
                
            }
            return schemes;
        }
    }
}
