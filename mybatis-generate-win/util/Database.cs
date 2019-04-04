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
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// namespace with util
/// </summary>
namespace mybatis_generate_win.util
{
    /// <summary>
    ///  Database resource define
    /// </summary>
    public static class Database
    {
        /// <summary>
        /// define the mysql
        /// </summary>
        public const string MySQL = "MySQL";

        /// <summary>
        /// define the default user name with mysql
        /// </summary>
        public const string MySQLDefaultUser = "root";

        /// <summary>
        /// define the default port with mysql
        /// </summary>
        public const string MySQLDefaultPort = "3306";

        /// <summary>
        /// define the connect url with mysql
        /// </summary>
        public const string MySQLDefaultUrl = "jdbc:mysql://#{ip}:#{port}/#{scheme}?characterEncoding=utf-8";


        /////////////////////////////////////////////////////


        /// <summary>
        /// define the sqlserver
        /// </summary>
        public const string SqlServer = "SqlServer";

        /// <summary>
        /// define the default user name with sqlserver
        /// </summary>
        public const string SqlServerDefaultUser = "sa";

        /// <summary>
        /// define the default port with sqlserver
        /// </summary>
        public const string SqlServerDefaultPort = "1433";

        /// <summary>
        /// define the connect url with sqlserver
        /// </summary>
        public const string SqlServerDefaultUrl = "jdbc:microsoft:sqlserver://#{ip}:#{port};DatabaseName=#{scheme}";


        /////////////////////////////////////////////////////


        /// <summary>
        /// define the oracle
        /// </summary>
        public const string Oracle = "Oracle";

        /// <summary>
        /// define the default user name with oracle
        /// </summary>
        public const string OracleDefaultUser = "scott";

        /// <summary>
        /// define the default port with oracle
        /// </summary>
        public const string OracleDefaultPort = "1521";

        /// <summary>
        /// define the connect url with oracle
        /// </summary>
        public const string OracleDefaultUrl = "jdbc:oracle:thin:@#{ip}:#{port}:orcl";


        ////////////////////////////////////////////////////


        //LOG THIS CONFIGURATION INFORMATION
        public static string ConnectionString;
        public static string ConnectionDatabase;
        public static string dbversion;

        //SELECT ORACLE/MYSQL/SQLSERVER DATABASE'S ALL DATABASE OR USER T-SQL/PL-SQL SCRIPT
        /// <summary>
        /// SELECT ORACLE DATABASE'S ALL USER
        /// </summary>
        public const string ORACLE_ALL_USER_SCRIPT = "SELECT * FROM ALL_USERS";

        /// <summary>
        /// SELECT MYSQL DATABASE ALL DATABASE NAME
        /// </summary>
        public const string MYSQL_ALL_TABLE_SCRIPT = "SHOW DATABASES";

        /// <summary>
        /// SELECT SQLSERVER DATABASE ALL DATABASE NAME
        /// </summary>
        public const string SQLSERVER_ALL_TABLE_SCRIPT = "SELECT NAME FROM MASTER..SYSDATABASES ORDER BY NAME";

        /// <summary>
        /// SELECT ORACLE DATABASE CURRENT LOGINED USERNAME
        /// </summary>
        public const string ORACLE_CURRENT_USERNAME = "SELECT USER FROM DUAL";

        /// <summary>
        /// SELECT ORACLE DATABASE CURRENT USER'S ALL TABLE
        /// </summary>
        public const string ORACLE_CURRENT_USERNAME_TABLE = "SELECT TABLE_NAME FROM TABS";

    }
}
