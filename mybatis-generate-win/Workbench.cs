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
using System.Drawing;
using System.Windows.Forms;
using CCWin;
using mybatis_generate_win.util;

namespace mybatis_generate_win
{
    // Use the mac style(CSKin DLL)
    public partial class Workbench : Skin_Mac
    {
        /// <summary>
        /// Mark whether the current database is oracle database, 
        /// which is used to mark whether the database information function under the current connection is loaded 
        /// (oracle database has no concept of library, only the concept of user)
        /// </summary>
        public static bool IsOracle = false;

        /// <summary>
        /// Indicates whether the connection is currently checked for validity
        /// </summary>
        public static bool IsTest = false;

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
            // cbx_databaseList.Items.Add(Database.SqlServer);
            // cbx_databaseList.Items.Add(Database.Oracle);

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
            switch (currentDatabaseSelectedText)
            {
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

            bool checkResult = CheckInput(false);
            if (!checkResult)
            {
                return;
            }

            string databaseSel = cbx_databaseList.Text;
            string ipAddr = txt_ip.Text;
            string port = txt_port.Text;
            string userName = txt_userName.Text;
            string password = txt_password.Text;
            string scheme = cbx_scheme.Text;

            // check current is an oracle. if an oracle,response the test event, othwise initlize scheme
            // Query all current connect's database(scheme) information, default DatabaseType is MySQL
            DatabaseConnectorProvider connectorProvider = DatabaseConnectorProvider.GetInstance(ipAddr, port, userName, password, DataBaseType.MySql);
            bool result;

            // Init the scheme info (sqlserver or mysql) can be test the connect before
            switch (databaseSel)
            {
                case Database.MySQL:
                    connectorProvider.ChangeDatabaseType(DataBaseType.MySql);
                    result = connectorProvider.connect();
                    break;
                case Database.SqlServer:
                    connectorProvider.ChangeDatabaseType(DataBaseType.SqlServer);
                    result = connectorProvider.connect();
                    break;
                case Database.Oracle:
                    // Modity the test tag
                    IsTest = true;
                    connectorProvider.ChangeDatabaseType(DataBaseType.Oracle);
                    result = connectorProvider.connect();
                    break;
                default:
                    result = false;
                    break;
            }
            if (result)
            {
                label_connectStatus.Text = "Connected successfully !";
                label_connectStatus.ForeColor = Color.Green;
                label_connectStatus.Show();
                tb_next.Enabled = true;
            }
            else
            {
                label_connectStatus.Text = "Connected failed !";
                label_connectStatus.ForeColor = Color.Red;
                label_connectStatus.Show();
                // disable the tb_next button
                tb_next.Enabled = false;
            }

            if (!IsOracle)
            {
                // init the database all scheme
                List<string> schemes = connectorProvider.initScheme();
                cbx_scheme.Items.Clear();
                for (int i = 0; i < schemes.Count; i++)
                {
                    cbx_scheme.Items.Add(schemes[i].ToString());
                }
                if (cbx_scheme.Items.Count > 0)
                {
                    cbx_scheme.SelectedIndex = 0;
                }
            }

        }


        /// <summary>
        /// 当前按钮状态。 1 = Next  2 = Serialize
        /// </summary>
        int currentButtonStatus = 1;

        /// <summary>
        /// Next button click event
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void tb_next_Click(object sender, EventArgs e)
        {
            var result = CheckInput(true);
            if (!result)
            {
                return;
            }

            string ip = txt_ip.Text;
            string port = txt_port.Text;
            string userName = txt_userName.Text;
            string password = txt_password.Text;
            string scheme = cbx_scheme.Text;

            string modelPackage = txt_modelPackage.Text;
            string daoPackage = txt_daoPackage.Text;
            string mapperXmlPackage = txt_mapperPackage.Text;

            bool removeComment = cb_removeComment.Checked;
            bool forceBigDecimals = cb_forceBbigDecimals.Checked;
            bool enableSubPackag = cb_enableSubPackages.Checked;
            bool trimStrings = cb_trimStrings.Checked;
            bool useActualColumnNames = cb_useActualColumnNames.Checked;


            if (currentButtonStatus == 1)
            {
                // hidden the init panage and show the generate panel
                // panel_initResource.Hide();
                panel_generate.Show();

                label_connectStatus.Hide();
                tb_next.Text = "Serialize";
                currentButtonStatus = 2;

                // 查询选中数据库下的所有表信息
                DatabaseConnectorProvider connectorProvider = DatabaseConnectorProvider.GetInstance(ip, port, userName, password, DataBaseType.MySql);
                connectorProvider.ChangeDatabaseType(DataBaseType.MySql);
                bool connectResult = connectorProvider.connect();
                if (connectResult)
                {
                    cbx_tables.Items.Clear();
                    List<string> tableList = connectorProvider.initAllTable(scheme);
                    // add default scheme(all table)
                    cbx_tables.Items.Add("%");
                    for (int i = 0; i < tableList.Count; i++)
                    {
                        cbx_tables.Items.Add(tableList[i].ToString());
                    }
                }
            }
            else if (currentButtonStatus == 2)
            {
                // serialize
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "请选择具体保存的文件夹";
                folderBrowserDialog.ShowNewFolderButton = true;
                folderBrowserDialog.ShowDialog();

                string selectPath = folderBrowserDialog.SelectedPath;

                string connectUrl = String.Format("jdbc:mysql://{0}:{1}/{2}?useUnicode=true&amp;characterEncoding=utf8&amp;useSSL=false&amp;autoReconnect=true",
                    ip, port, scheme);
                ApplicationRunnerUtils.SerializeRun(txt_targetRuntime.Text, connectUrl, userName, password, modelPackage, daoPackage, mapperXmlPackage, forceBigDecimals, enableSubPackag, trimStrings, cbx_tables.SelectedItem.ToString(), selectPath);
            }
        }

        private bool CheckInput(bool isNextEvent)
        {
            string databaseSel = cbx_databaseList.Text;
            string ipAddr = txt_ip.Text;
            string port = txt_port.Text;
            string userName = txt_userName.Text;
            string password = txt_password.Text;
            string scheme = cbx_scheme.Text;

            // check inputs
            if (StringUtils.isEmpty(databaseSel))
            {
                // It never happens
                MessageBox.Show("Please select database!");
            }
            // ip address
            if (StringUtils.isEmpty(ipAddr))
            {
                string noIpTitle = "Please enter the IP address !";
                label_ip.Show();
                label_ip.Text = noIpTitle;
                return false;
            }
            /*if (!InputSecurity.IsIp(ipAddr) || !!InputSecurity.IsDomain(ipAddr))
            {
                string ipNotAllow = "Illegal ip address !";
                label_ip.Show();
                label_ip.Text = ipNotAllow;
                return false;
            }*/
            label_ip.Hide();
            // port
            if (StringUtils.isEmpty(port))
            {
                string noPortTitle = "Please enter the port !";
                label_port.Show();
                label_port.Text = noPortTitle;
                return false;
            }
            if (!NumberUtils.IsNumber(port) && !NumberUtils.IsSection(1, 65532, Int32.Parse(port)))
            {
                string noPortTitle = "Illegal port !";
                label_port.Show();
                label_port.Text = noPortTitle;
                return false;
            }
            label_port.Hide();
            // user name
            if (StringUtils.isEmpty(userName))
            {
                string noUserNameTitle = "Please enter the user name !";
                label_userName.Show();
                label_userName.Text = noUserNameTitle;
                return false;
            }
            label_userName.Hide();
            // password
            if (StringUtils.isEmpty(password))
            {
                string noPasswordTitle = "Please enter the password !";
                label_password.Show();
                label_password.Text = noPasswordTitle;
                return false;
            }
            label_password.Hide();
            // if not oracle, check the scheme
            if (!IsOracle && isNextEvent)
            {
                if (StringUtils.isEmpty(scheme))
                {
                    string noSchemeTitle = "Please choose scheme !";
                    label_scheme.Show();
                    label_scheme.Text = noSchemeTitle;
                    return false;
                }
            }
            label_scheme.Hide();
            return true;
        }

        /// <summary>
        /// ip input text value changed event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_ip_SizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
