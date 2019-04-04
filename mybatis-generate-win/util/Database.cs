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
    }
}
