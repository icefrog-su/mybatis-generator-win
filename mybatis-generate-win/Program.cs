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

using mybatis_generate_win.util;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace mybatis_generate_win
{
    static class Program
    {
        /// <summary>
        /// Application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check system version mast be vista or higher
            if (!SystemUtils.IsWinVistaOrHigher())
            {
                MessageBox.Show("Unsupported operating system, use Windows Vista at least.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check .NET Framework version
            if (!SystemUtils.IsSupportedRuntimeVersion())
            {
                MessageBox.Show("Unsupported .NET Framework, please update to 4.6.2 or later.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Process.Start(
                    "https://www.microsoft.com/download/details.aspx?id=53344");
                return;
            }

            // remove the memory
            SystemUtils.ReleaseMemory(true);


            Application.Run(new Workbench());
        }
    }
}
