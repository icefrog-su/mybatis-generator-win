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
using Oracle.ManagedDataAccess.Client;

namespace mybatis_generate_win.database
{
    public class OracleConnector : AbstractDatabaseConnector
    {

        /// <summary>
        /// Database connect object
        /// </summary>
        private OracleConnection conn;

        /// <summary>
        /// Database connect str, be use to rebuild connect object
        /// </summary>
        private string ConnectionStr = null;

        private OracleConnector(string connectStr, OracleConnection conn)
        {
            this.conn = conn;
            this.ConnectionStr = connectStr;
        }

        public static OracleConnector GetInstance(string ip, string userName, string password)
        {
            string connStr = string.Format("data source={0}/orcl;User Id={1};Password={2};", ip, userName, password);
            return new OracleConnector(connStr, new OracleConnection(connStr));
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                int flag = cmd.ExecuteNonQuery();
                return flag;
            }
            catch
            {
                throw new NotSupportedException("Oracle operation abnormal, please check the connection");
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
                OracleCommand cmd = new OracleCommand(sql, conn);
                object obj = cmd.ExecuteScalar();
                return obj;
            }
            catch
            {
                throw new NotSupportedException("Oracle operation abnormal, please check the connection");
            }
            finally
            {
                conn.Close();
            }
        }

        public OracleDataReader ExecuteDataReader(string sql)
        {
            try
            { 
                conn.Open();
                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                return reader;
            }
            catch
            {
                throw new NotSupportedException("Oracle operation abnormal, please check the connection");
            }
        }

        public override DataSet ExecuteDataSet(string sql)
        {
            try
            {
                OracleDataAdapter dat = new OracleDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                dat.Fill(ds);
                return ds;
            }
            catch
            {
                throw new NotSupportedException("Oracle operation abnormal, please check the connection");
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
