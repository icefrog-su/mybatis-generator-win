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

namespace mybatis_generate_win.util
{
    /// <summary>
    /// StringUtils, see apache.commons.lang(jar)
    /// </summary>
    public class StringUtils
    {

        /// <summary>
        /// when str is null or length is zero, return true, othwire false
        /// </summary>
        /// <param name="str">string</param>
        /// <returns></returns>
        public static bool isEmpty(string str)
        {
            if(str == null || str.Length == 0)
            {
                return true;
            }
            return false;
        }

        public static bool isNotEmpty(string str)
        {
            return !StringUtils.isEmpty(str);
        }
    }
}
