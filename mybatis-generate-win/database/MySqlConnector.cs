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

using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace mybatis_generate_win.database
{
    public class MySqlConnector : AbstractDatabaseConnector
    {

        public const string DRIVER_CLASS = "com.mysql.jdbc.Driver";

        /// <summary>
        /// Database connect object
        /// </summary>
        private MySqlConnection conn;

        /// <summary>
        /// Database connect str, be use to rebuild connect object
        /// </summary>
        private string ConnectionStr = null;

        private MySqlConnector(string connectStr, MySqlConnection conn)
        {
            this.conn = conn;
            this.ConnectionStr = connectStr;
        }

        public static MySqlConnector GetInstance(string ip, string port, string userName, string password, string scheme)
        {
            string connStr = string.Format("server={0};port={1};user={2};password={3}; database={4};", ip, port, userName, password, scheme);
            return new MySqlConnector(connStr, new MySqlConnection(connStr));
        }


        public MySqlDataReader ReBuildMySQLDataReader(string sql)
        {
            MySqlDataReader reader = null;
            MySqlConnection reConn = new MySqlConnection(this.ConnectionStr);
            try
            { 
                reConn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, reConn);
                reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                return reader;
            }
            catch
            {
                throw new NotSupportedException("MySQL operation abnormal, please check the connection");
            }
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                int flag = cmd.ExecuteNonQuery();
                return flag;
            }
            catch (Exception e)
            {
                throw new NotSupportedException("MySQL operation abnormal, please check the connection");
            }
            finally
            {
                conn.Close();
            }
        }

        public object ExecuteScalar(string sql)
        {
            try
            { 
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                object obj = cmd.ExecuteScalar();
                return obj;
            }
            catch
            {
                throw new NotSupportedException("MySQL operation abnormal, please check the connection");
            }
            finally
            {
                conn.Close();
            }
        }

        public MySqlDataReader ExecuteDataReader(string sql)
        {
            try
            { 
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                return reader;
            }
            catch
            {
                throw new NotSupportedException("MySQL operation abnormal, please check the connection");
            }
        }

        public override DataSet ExecuteDataSet(string sql)
        {
            try
            {
                MySqlDataAdapter dat = new MySqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                dat.Fill(ds);
                return ds;
            }
            catch
            {
                throw new NotSupportedException("MySQL operation abnormal, please check the connection");
            }
        }

        public override DataTable ExecuteDataTable(string sql)
        {
            DataTable dt = new DataTable();
            dt = ExecuteDataSet(sql).Tables[0];
            return dt;
        }

        public override DataRow ExecuteDataRow(string sql)
        {
            DataRow dr;
            dr = ExecuteDataSet(sql).Tables[0].Rows[0];
            return dr;
        }

    }
}
