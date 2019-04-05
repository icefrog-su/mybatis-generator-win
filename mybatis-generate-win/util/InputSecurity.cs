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
using System.Text.RegularExpressions;

namespace mybatis_generate_win.util
{
    public class InputSecurity
    {
        // Deprecated
        public static bool inputCheck(string databaseSel, string ipAddress, string port,
            string userName, string password, string scheme, string url)
        {
            return false;
        }

        public static bool isIp(string ip)
        {
            Regex rx = new Regex(@"((?:(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d)))\.){3}(?:25[0-5]|2[0-4]\d|((1\d{2})|([1-9]?\d))))");
            if (rx.IsMatch(ip))
                return true;
            else
                return false;
        }
    }
}