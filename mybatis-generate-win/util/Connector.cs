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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mybatis_generate_win.util
{
    public interface Connector
    {
        /// <summary>
        /// Check if the current connection information is connected
        /// </summary>
        /// <param name="ip">Ip address</param>
        /// <param name="port">Port</param>
        /// <param name="userName">User name</param>
        /// <param name="password">Password</param>
        /// <param name="dbType">Type of DataBaseType</param>
        /// <returns>Returns true if it can connect, otherwise returns false</returns>
        bool connect(string ip, string port, string userName, string password, DataBaseType dbType);

        /// <summary>
        /// Load all database information for this connection (oracle does not apply)
        /// </summary>
        /// <returns>List's all scheme name</returns>
        List<String> initScheme();

    }
}
