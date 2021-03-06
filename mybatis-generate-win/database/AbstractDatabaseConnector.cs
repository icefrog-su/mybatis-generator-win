﻿/* Copyright 2019 icefrog.su@qq.com
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

using System.Data;

namespace mybatis_generate_win.database
{
    public abstract class AbstractDatabaseConnector
    {
        /// <summary>
        /// Execute a sql and return the DataSet
        /// </summary>
        /// <param name="sql">sql string</param>
        /// <returns></returns>
        public abstract DataSet ExecuteDataSet(string sql);

        /// <summary>
        /// Execute a sql and return the DataTable
        /// </summary>
        /// <param name="sql">sql string</param>
        /// <returns></returns>
        public abstract DataTable ExecuteDataTable(string sql);

        /// <summary>
        /// Execute a sql and return the DataRow
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public abstract DataRow ExecuteDataRow(string sql);
    }
}
