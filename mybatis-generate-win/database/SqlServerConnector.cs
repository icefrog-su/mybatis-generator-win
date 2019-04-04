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

using System;
using System.Data;
using System.Data.SqlClient;

namespace mybatis_generate_win.database
{
    public class SqlServerConnector : AbstractDatabaseConnector
    {

        /// <summary>
        /// Database connect object
        /// </summary>
        private SqlConnection conn;

        /// <summary>
        /// Database connect str, be use to rebuild connect object
        /// </summary>
        private string ConnectionStr = null;

        /// <summary>
        /// rebuild a SQLDataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlDataReader ReBuilderSqlDataReader(string sql)
        {
            SqlDataReader reader = null;
            SqlConnection reConn = new SqlConnection(this.ConnectionStr);
            try
            { 
                reConn.Open();
                SqlCommand cmd = new SqlCommand(sql, reConn);
                reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                return reader;
            }
            catch
            { 
                return reader;
            }
        }

        private SqlServerConnector(string connectStr, SqlConnection conn)
        {
            this.conn = conn;
            this.ConnectionStr = connectStr;
        }

        public static SqlServerConnector GetInstance(string ip, string userName, string password, string scheme)
        {
            string connStr = string.Format("server={0};database={1};uid={2};pwd={3}", ip, scheme, userName, password);
            return new SqlServerConnector(connStr, new SqlConnection(connStr));
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int flag = cmd.ExecuteNonQuery();
                return flag;
            }
            catch
            {
                return -1;
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
                SqlCommand cmd = new SqlCommand(sql, conn);
                object obj = cmd.ExecuteScalar();
                return obj;
            }
            catch
            { 
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

       
        public SqlDataReader ExecuteDataReader(string sql)
        {
            try
            { 
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                return reader;
            }
            catch
            { 
                return null;
            }
        }

      
        public DataSet ExecuteDataSet(string sql)
        {
            try
            {
                SqlDataAdapter dat = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                dat.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            { 
                Console.WriteLine("++++++++++++++++++++++++++++++" + ex.Message);
                return null;
            }
        }

       
        public DataTable ExecuteDataTable(string sql)
        {
            DataTable dt = new DataTable();
            dt = ExecuteDataSet(sql).Tables[0];
            return dt;
        }

       
        public DataRow ExecuteDataRow(string sql)
        {
            DataRow dr;
            dr = ExecuteDataSet(sql).Tables[0].Rows[0];
            return dr;
        }

    }
}
