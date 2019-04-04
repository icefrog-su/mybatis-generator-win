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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using mybatis_generate_win.util;

namespace mybatis_generate_win
{
    public partial class Workbench : Skin_Mac
    {
        /// <summary>
        /// Mark whether the current database is oracle database, 
        /// which is used to mark whether the database information function under the current connection is loaded 
        /// (oracle database has no concept of library, only the concept of user)
        /// </summary>
        public static bool IsOracle = false;

        public Workbench()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Workbench initialize event
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void Workbench_Load(object sender, EventArgs e)
        {
            // initialize database
            cbx_databaseList.Items.Add(Database.MySQL);
            cbx_databaseList.Items.Add(Database.SqlServer);
            cbx_databaseList.Items.Add(Database.Oracle);
            // default selected index 1(0)
            cbx_databaseList.SelectedIndex = 0;

            // initialize default ip address
            txt_ip.Text = Constance.DefaultIpAddress;

            // hidden some label resource
            label_ip.Hide();
            label_port.Hide();
            label_userName.Hide();
            label_password.Hide();
            label_scheme.Hide();
            label_url.Hide();
            label_connectStatus.Hide();

            // hidden generate panel and show the init panel
            panel_generate.Hide();
            panel_initResource.Show();

        }

        /// <summary>
        /// cbx_databaseList control's selected changed event.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void cbx_databaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentDatabaseSelectedText = cbx_databaseList.Text;
            if (StringUtils.isEmpty(currentDatabaseSelectedText))
            {
                // if currentDatabaseSelectedText is empty, nothing to do.
                return;
            }

            // initialize default database connecte user name and port
            switch(currentDatabaseSelectedText){
                case Database.MySQL:
                    InitPageDefaultResource(Database.MySQLDefaultUser, Database.MySQLDefaultPort, Database.MySQLDefaultUrl, true, "initialize", false);
                    break;
                case Database.SqlServer:
                    InitPageDefaultResource(Database.SqlServerDefaultUser, Database.SqlServerDefaultPort, Database.SqlServerDefaultUrl, true, "initialize", false);
                    break;
                case Database.Oracle:
                    // if oracle, disable scheme selectbox and change the initialize button to test connect button
                    InitPageDefaultResource(Database.OracleDefaultUser, Database.OracleDefaultPort, Database.OracleDefaultUrl, false, "test", true);
                    break;
            }
        }

        /// <summary>
        /// Init page default resource func
        /// </summary>
        /// <param name="defaultUser">current default user name (sa,root,scott...)</param>
        /// <param name="defaultPort">default port</param>
        /// <param name="defaultUrl">default url</param>
        /// <param name="isEnableScheme">is enable scheme selectbox</param>
        /// <param name="initializeBtnText">initialize button's label text</param>
        /// <param name="isOracle">current is an oracle</param>
        private void InitPageDefaultResource(string defaultUser, string defaultPort, string defaultUrl, bool isEnableScheme, string initializeBtnText, bool isOracle)
        {
            txt_userName.Text = defaultUser;
            txt_port.Text = defaultPort;
            txt_url.Text = defaultUrl;
            cbx_scheme.Enabled = isEnableScheme;
            btn_initlize.Text = initializeBtnText;
            IsOracle = isOracle;
        }

        /// <summary>
        /// inialize button (or test) button click event
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btn_initlize_Click(object sender, EventArgs e)
        {
            // check current is an oracle. if an oracle,response the test event, othwise initlize scheme

            if (IsOracle)
            {
                MessageBox.Show("test the connect(oracle not be has a scheme)");
            }
            else
            {
                MessageBox.Show("initialize the all scheme and test the connect");
            }

        }

        /// <summary>
        /// Next button click event
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void tb_next_Click(object sender, EventArgs e)
        {

            // hidden the init panage and show the generate panel
            panel_initResource.Hide();
            panel_generate.Show();

            string databaseSel = cbx_databaseList.Text;
            string ipAddr = txt_ip.Text;
            string port = txt_port.Text;
            string userName = txt_userName.Text;
            string password = txt_password.Text;
            string scheme = cbx_scheme.Text;
            string url = txt_url.Text;
            

            // 数据必填项校验

            // 提示选择数据库/ 必须经过校验

            // 创建新的panel, 并且构建控件元素

            // add some  
        }
    }
}
