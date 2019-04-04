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
