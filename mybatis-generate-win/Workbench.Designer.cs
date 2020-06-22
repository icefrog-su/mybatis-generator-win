namespace mybatis_generate_win
{
    partial class Workbench
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workbench));
            this.tb_next = new CCWin.SkinControl.SkinButton();
            this.cbx_databaseList = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.txt_userName = new CCWin.SkinControl.SkinTextBox();
            this.txt_password = new CCWin.SkinControl.SkinTextBox();
            this.txt_ip = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.txt_port = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.cbx_scheme = new CCWin.SkinControl.SkinComboBox();
            this.btn_initlize = new CCWin.SkinControl.SkinButton();
            this.panel_initResource = new CCWin.SkinControl.SkinPanel();
            this.label_scheme = new CCWin.SkinControl.SkinLabel();
            this.label_password = new CCWin.SkinControl.SkinLabel();
            this.label_userName = new CCWin.SkinControl.SkinLabel();
            this.label_port = new CCWin.SkinControl.SkinLabel();
            this.label_ip = new CCWin.SkinControl.SkinLabel();
            this.panel_generate = new CCWin.SkinControl.SkinPanel();
            this.cbx_tables = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.txt_mapperPackage = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.txt_daoPackage = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.cb_useActualColumnNames = new CCWin.SkinControl.SkinCheckBox();
            this.cb_trimStrings = new CCWin.SkinControl.SkinCheckBox();
            this.cb_enableSubPackages = new CCWin.SkinControl.SkinCheckBox();
            this.cb_forceBbigDecimals = new CCWin.SkinControl.SkinCheckBox();
            this.cb_removeComment = new CCWin.SkinControl.SkinCheckBox();
            this.txt_targetRuntime = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel14 = new CCWin.SkinControl.SkinLabel();
            this.txt_modelPackage = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel20 = new CCWin.SkinControl.SkinLabel();
            this.label_connectStatus = new CCWin.SkinControl.SkinLabel();
            this.panel_initResource.SuspendLayout();
            this.panel_generate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_next
            // 
            this.tb_next.BackColor = System.Drawing.Color.Transparent;
            this.tb_next.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.tb_next.DownBack = null;
            this.tb_next.Enabled = false;
            this.tb_next.Location = new System.Drawing.Point(284, 393);
            this.tb_next.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_next.MouseBack = null;
            this.tb_next.Name = "tb_next";
            this.tb_next.NormlBack = null;
            this.tb_next.Size = new System.Drawing.Size(99, 30);
            this.tb_next.TabIndex = 0;
            this.tb_next.Text = "next";
            this.tb_next.UseVisualStyleBackColor = false;
            this.tb_next.Click += new System.EventHandler(this.tb_next_Click);
            // 
            // cbx_databaseList
            // 
            this.cbx_databaseList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_databaseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_databaseList.FormattingEnabled = true;
            this.cbx_databaseList.Location = new System.Drawing.Point(97, 17);
            this.cbx_databaseList.Name = "cbx_databaseList";
            this.cbx_databaseList.Size = new System.Drawing.Size(242, 26);
            this.cbx_databaseList.TabIndex = 1;
            this.cbx_databaseList.WaterText = "";
            this.cbx_databaseList.SelectedIndexChanged += new System.EventHandler(this.cbx_databaseList_SelectedIndexChanged);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(25, 21);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(66, 17);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "Database:";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(14, 159);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(77, 17);
            this.skinLabel2.TabIndex = 3;
            this.skinLabel2.Text = "User Name:";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(24, 205);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(67, 17);
            this.skinLabel3.TabIndex = 4;
            this.skinLabel3.Text = "Password:";
            // 
            // txt_userName
            // 
            this.txt_userName.BackColor = System.Drawing.Color.Transparent;
            this.txt_userName.DownBack = null;
            this.txt_userName.Icon = null;
            this.txt_userName.IconIsButton = false;
            this.txt_userName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_userName.IsPasswordChat = '\0';
            this.txt_userName.IsSystemPasswordChar = false;
            this.txt_userName.Lines = new string[0];
            this.txt_userName.Location = new System.Drawing.Point(97, 155);
            this.txt_userName.Margin = new System.Windows.Forms.Padding(0);
            this.txt_userName.MaxLength = 32767;
            this.txt_userName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txt_userName.MouseBack = null;
            this.txt_userName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_userName.Multiline = false;
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.NormlBack = null;
            this.txt_userName.Padding = new System.Windows.Forms.Padding(5);
            this.txt_userName.ReadOnly = false;
            this.txt_userName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_userName.Size = new System.Drawing.Size(242, 28);
            // 
            // 
            // 
            this.txt_userName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_userName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_userName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txt_userName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txt_userName.SkinTxt.Name = "BaseText";
            this.txt_userName.SkinTxt.Size = new System.Drawing.Size(232, 18);
            this.txt_userName.SkinTxt.TabIndex = 0;
            this.txt_userName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_userName.SkinTxt.WaterText = "";
            this.txt_userName.TabIndex = 6;
            this.txt_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_userName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_userName.WaterText = "";
            this.txt_userName.WordWrap = true;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.Transparent;
            this.txt_password.DownBack = null;
            this.txt_password.Icon = null;
            this.txt_password.IconIsButton = false;
            this.txt_password.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_password.IsPasswordChat = '*';
            this.txt_password.IsSystemPasswordChar = false;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(97, 201);
            this.txt_password.Margin = new System.Windows.Forms.Padding(0);
            this.txt_password.MaxLength = 32767;
            this.txt_password.MinimumSize = new System.Drawing.Size(28, 28);
            this.txt_password.MouseBack = null;
            this.txt_password.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.NormlBack = null;
            this.txt_password.Padding = new System.Windows.Forms.Padding(5);
            this.txt_password.ReadOnly = false;
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.Size = new System.Drawing.Size(242, 28);
            // 
            // 
            // 
            this.txt_password.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_password.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txt_password.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txt_password.SkinTxt.Name = "BaseText";
            this.txt_password.SkinTxt.PasswordChar = '*';
            this.txt_password.SkinTxt.Size = new System.Drawing.Size(232, 18);
            this.txt_password.SkinTxt.TabIndex = 0;
            this.txt_password.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_password.SkinTxt.WaterText = "";
            this.txt_password.TabIndex = 7;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_password.WaterText = "";
            this.txt_password.WordWrap = true;
            // 
            // txt_ip
            // 
            this.txt_ip.BackColor = System.Drawing.Color.Transparent;
            this.txt_ip.DownBack = null;
            this.txt_ip.Icon = null;
            this.txt_ip.IconIsButton = false;
            this.txt_ip.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_ip.IsPasswordChat = '\0';
            this.txt_ip.IsSystemPasswordChar = false;
            this.txt_ip.Lines = new string[0];
            this.txt_ip.Location = new System.Drawing.Point(97, 61);
            this.txt_ip.Margin = new System.Windows.Forms.Padding(0);
            this.txt_ip.MaxLength = 32767;
            this.txt_ip.MinimumSize = new System.Drawing.Size(28, 28);
            this.txt_ip.MouseBack = null;
            this.txt_ip.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_ip.Multiline = false;
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.NormlBack = null;
            this.txt_ip.Padding = new System.Windows.Forms.Padding(5);
            this.txt_ip.ReadOnly = false;
            this.txt_ip.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ip.Size = new System.Drawing.Size(242, 28);
            // 
            // 
            // 
            this.txt_ip.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ip.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ip.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txt_ip.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txt_ip.SkinTxt.Name = "BaseText";
            this.txt_ip.SkinTxt.Size = new System.Drawing.Size(232, 18);
            this.txt_ip.SkinTxt.TabIndex = 0;
            this.txt_ip.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_ip.SkinTxt.WaterText = "";
            this.txt_ip.TabIndex = 10;
            this.txt_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ip.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_ip.WaterText = "";
            this.txt_ip.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(69, 65);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(22, 17);
            this.skinLabel5.TabIndex = 9;
            this.skinLabel5.Text = "IP:";
            // 
            // txt_port
            // 
            this.txt_port.BackColor = System.Drawing.Color.Transparent;
            this.txt_port.DownBack = null;
            this.txt_port.Icon = null;
            this.txt_port.IconIsButton = false;
            this.txt_port.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_port.IsPasswordChat = '\0';
            this.txt_port.IsSystemPasswordChar = false;
            this.txt_port.Lines = new string[0];
            this.txt_port.Location = new System.Drawing.Point(97, 108);
            this.txt_port.Margin = new System.Windows.Forms.Padding(0);
            this.txt_port.MaxLength = 32767;
            this.txt_port.MinimumSize = new System.Drawing.Size(28, 28);
            this.txt_port.MouseBack = null;
            this.txt_port.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_port.Multiline = false;
            this.txt_port.Name = "txt_port";
            this.txt_port.NormlBack = null;
            this.txt_port.Padding = new System.Windows.Forms.Padding(5);
            this.txt_port.ReadOnly = false;
            this.txt_port.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_port.Size = new System.Drawing.Size(242, 28);
            // 
            // 
            // 
            this.txt_port.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_port.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_port.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txt_port.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txt_port.SkinTxt.Name = "BaseText";
            this.txt_port.SkinTxt.Size = new System.Drawing.Size(232, 18);
            this.txt_port.SkinTxt.TabIndex = 0;
            this.txt_port.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_port.SkinTxt.WaterText = "";
            this.txt_port.TabIndex = 12;
            this.txt_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_port.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_port.WaterText = "";
            this.txt_port.WordWrap = true;
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(56, 111);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(35, 17);
            this.skinLabel6.TabIndex = 11;
            this.skinLabel6.Text = "Port:";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(35, 255);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(56, 17);
            this.skinLabel7.TabIndex = 14;
            this.skinLabel7.Text = "Scheme:";
            // 
            // cbx_scheme
            // 
            this.cbx_scheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_scheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_scheme.FormattingEnabled = true;
            this.cbx_scheme.Location = new System.Drawing.Point(97, 251);
            this.cbx_scheme.Name = "cbx_scheme";
            this.cbx_scheme.Size = new System.Drawing.Size(165, 26);
            this.cbx_scheme.TabIndex = 13;
            this.cbx_scheme.WaterText = "";
            // 
            // btn_initlize
            // 
            this.btn_initlize.BackColor = System.Drawing.Color.Transparent;
            this.btn_initlize.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_initlize.DownBack = null;
            this.btn_initlize.Location = new System.Drawing.Point(265, 251);
            this.btn_initlize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_initlize.MouseBack = null;
            this.btn_initlize.Name = "btn_initlize";
            this.btn_initlize.NormlBack = null;
            this.btn_initlize.Size = new System.Drawing.Size(72, 24);
            this.btn_initlize.TabIndex = 15;
            this.btn_initlize.Text = "Connect";
            this.btn_initlize.UseVisualStyleBackColor = false;
            this.btn_initlize.Click += new System.EventHandler(this.btn_initlize_Click);
            // 
            // panel_initResource
            // 
            this.panel_initResource.BackColor = System.Drawing.Color.Transparent;
            this.panel_initResource.Controls.Add(this.panel_generate);
            this.panel_initResource.Controls.Add(this.label_scheme);
            this.panel_initResource.Controls.Add(this.label_password);
            this.panel_initResource.Controls.Add(this.label_userName);
            this.panel_initResource.Controls.Add(this.label_port);
            this.panel_initResource.Controls.Add(this.label_ip);
            this.panel_initResource.Controls.Add(this.cbx_scheme);
            this.panel_initResource.Controls.Add(this.skinLabel7);
            this.panel_initResource.Controls.Add(this.cbx_databaseList);
            this.panel_initResource.Controls.Add(this.btn_initlize);
            this.panel_initResource.Controls.Add(this.skinLabel1);
            this.panel_initResource.Controls.Add(this.skinLabel2);
            this.panel_initResource.Controls.Add(this.skinLabel3);
            this.panel_initResource.Controls.Add(this.txt_port);
            this.panel_initResource.Controls.Add(this.txt_userName);
            this.panel_initResource.Controls.Add(this.skinLabel6);
            this.panel_initResource.Controls.Add(this.txt_password);
            this.panel_initResource.Controls.Add(this.txt_ip);
            this.panel_initResource.Controls.Add(this.skinLabel5);
            this.panel_initResource.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_initResource.DownBack = null;
            this.panel_initResource.Location = new System.Drawing.Point(7, 35);
            this.panel_initResource.MouseBack = null;
            this.panel_initResource.Name = "panel_initResource";
            this.panel_initResource.NormlBack = null;
            this.panel_initResource.Size = new System.Drawing.Size(349, 351);
            this.panel_initResource.TabIndex = 16;
            // 
            // label_scheme
            // 
            this.label_scheme.AutoSize = true;
            this.label_scheme.BackColor = System.Drawing.Color.Transparent;
            this.label_scheme.BorderColor = System.Drawing.Color.White;
            this.label_scheme.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_scheme.ForeColor = System.Drawing.Color.Red;
            this.label_scheme.Location = new System.Drawing.Point(96, 279);
            this.label_scheme.Name = "label_scheme";
            this.label_scheme.Size = new System.Drawing.Size(147, 17);
            this.label_scheme.TabIndex = 20;
            this.label_scheme.Text = "Please choose scheme !";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.BorderColor = System.Drawing.Color.White;
            this.label_password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_password.ForeColor = System.Drawing.Color.Red;
            this.label_password.Location = new System.Drawing.Point(94, 229);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(170, 17);
            this.label_password.TabIndex = 19;
            this.label_password.Text = "Please enter the password !";
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.BackColor = System.Drawing.Color.Transparent;
            this.label_userName.BorderColor = System.Drawing.Color.White;
            this.label_userName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_userName.ForeColor = System.Drawing.Color.Red;
            this.label_userName.Location = new System.Drawing.Point(94, 183);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(174, 17);
            this.label_userName.TabIndex = 18;
            this.label_userName.Text = "Please enter the user name !";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.BackColor = System.Drawing.Color.Transparent;
            this.label_port.BorderColor = System.Drawing.Color.White;
            this.label_port.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_port.ForeColor = System.Drawing.Color.Red;
            this.label_port.Location = new System.Drawing.Point(94, 138);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(138, 17);
            this.label_port.TabIndex = 17;
            this.label_port.Text = "Please enter the port !";
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.BackColor = System.Drawing.Color.Transparent;
            this.label_ip.BorderColor = System.Drawing.Color.White;
            this.label_ip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ip.ForeColor = System.Drawing.Color.Red;
            this.label_ip.Location = new System.Drawing.Point(94, 89);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(175, 17);
            this.label_ip.TabIndex = 16;
            this.label_ip.Text = "Please enter the IP address !";
            // 
            // panel_generate
            // 
            this.panel_generate.BackColor = System.Drawing.Color.Transparent;
            this.panel_generate.Controls.Add(this.cbx_tables);
            this.panel_generate.Controls.Add(this.skinLabel10);
            this.panel_generate.Controls.Add(this.txt_mapperPackage);
            this.panel_generate.Controls.Add(this.skinLabel9);
            this.panel_generate.Controls.Add(this.txt_daoPackage);
            this.panel_generate.Controls.Add(this.skinLabel8);
            this.panel_generate.Controls.Add(this.cb_useActualColumnNames);
            this.panel_generate.Controls.Add(this.cb_trimStrings);
            this.panel_generate.Controls.Add(this.cb_enableSubPackages);
            this.panel_generate.Controls.Add(this.cb_forceBbigDecimals);
            this.panel_generate.Controls.Add(this.cb_removeComment);
            this.panel_generate.Controls.Add(this.txt_targetRuntime);
            this.panel_generate.Controls.Add(this.skinLabel14);
            this.panel_generate.Controls.Add(this.txt_modelPackage);
            this.panel_generate.Controls.Add(this.skinLabel20);
            this.panel_generate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel_generate.DownBack = null;
            this.panel_generate.Location = new System.Drawing.Point(3, 3);
            this.panel_generate.MouseBack = null;
            this.panel_generate.Name = "panel_generate";
            this.panel_generate.NormlBack = null;
            this.panel_generate.Size = new System.Drawing.Size(349, 351);
            this.panel_generate.TabIndex = 23;
            // 
            // cbx_tables
            // 
            this.cbx_tables.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tables.FormattingEnabled = true;
            this.cbx_tables.Location = new System.Drawing.Point(122, 174);
            this.cbx_tables.Name = "cbx_tables";
            this.cbx_tables.Size = new System.Drawing.Size(206, 26);
            this.cbx_tables.TabIndex = 22;
            this.cbx_tables.WaterText = "";
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(69, 179);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(49, 17);
            this.skinLabel10.TabIndex = 21;
            this.skinLabel10.Text = "Tables:";
            // 
            // txt_mapperPackage
            // 
            this.txt_mapperPackage.BackColor = System.Drawing.Color.Transparent;
            this.txt_mapperPackage.DownBack = null;
            this.txt_mapperPackage.Icon = null;
            this.txt_mapperPackage.IconIsButton = false;
            this.txt_mapperPackage.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_mapperPackage.IsPasswordChat = '\0';
            this.txt_mapperPackage.IsSystemPasswordChar = false;
            this.txt_mapperPackage.Lines = new string[0];
            this.txt_mapperPackage.Location = new System.Drawing.Point(122, 136);
            this.txt_mapperPackage.Margin = new System.Windows.Forms.Padding(0);
            this.txt_mapperPackage.MaxLength = 32767;
            this.txt_mapperPackage.MinimumSize = new System.Drawing.Size(28, 28);
            this.txt_mapperPackage.MouseBack = null;
            this.txt_mapperPackage.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_mapperPackage.Multiline = false;
            this.txt_mapperPackage.Name = "txt_mapperPackage";
            this.txt_mapperPackage.NormlBack = null;
            this.txt_mapperPackage.Padding = new System.Windows.Forms.Padding(5);
            this.txt_mapperPackage.ReadOnly = false;
            this.txt_mapperPackage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mapperPackage.Size = new System.Drawing.Size(206, 28);
            // 
            // 
            // 
            this.txt_mapperPackage.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mapperPackage.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mapperPackage.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txt_mapperPackage.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txt_mapperPackage.SkinTxt.Name = "BaseText";
            this.txt_mapperPackage.SkinTxt.Size = new System.Drawing.Size(196, 18);
            this.txt_mapperPackage.SkinTxt.TabIndex = 0;
            this.txt_mapperPackage.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_mapperPackage.SkinTxt.WaterText = "";
            this.txt_mapperPackage.TabIndex = 20;
            this.txt_mapperPackage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_mapperPackage.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_mapperPackage.WaterText = "";
            this.txt_mapperPackage.WordWrap = true;
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(6, 140);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(112, 17);
            this.skinLabel9.TabIndex = 19;
            this.skinLabel9.Text = "Mapper package:";
            // 
            // txt_daoPackage
            // 
            this.txt_daoPackage.BackColor = System.Drawing.Color.Transparent;
            this.txt_daoPackage.DownBack = null;
            this.txt_daoPackage.Icon = null;
            this.txt_daoPackage.IconIsButton = false;
            this.txt_daoPackage.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_daoPackage.IsPasswordChat = '\0';
            this.txt_daoPackage.IsSystemPasswordChar = false;
            this.txt_daoPackage.Lines = new string[0];
            this.txt_daoPackage.Location = new System.Drawing.Point(122, 99);
            this.txt_daoPackage.Margin = new System.Windows.Forms.Padding(0);
            this.txt_daoPackage.MaxLength = 32767;
            this.txt_daoPackage.MinimumSize = new System.Drawing.Size(28, 28);
            this.txt_daoPackage.MouseBack = null;
            this.txt_daoPackage.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_daoPackage.Multiline = false;
            this.txt_daoPackage.Name = "txt_daoPackage";
            this.txt_daoPackage.NormlBack = null;
            this.txt_daoPackage.Padding = new System.Windows.Forms.Padding(5);
            this.txt_daoPackage.ReadOnly = false;
            this.txt_daoPackage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_daoPackage.Size = new System.Drawing.Size(206, 28);
            // 
            // 
            // 
            this.txt_daoPackage.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_daoPackage.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_daoPackage.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txt_daoPackage.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txt_daoPackage.SkinTxt.Name = "BaseText";
            this.txt_daoPackage.SkinTxt.Size = new System.Drawing.Size(196, 18);
            this.txt_daoPackage.SkinTxt.TabIndex = 0;
            this.txt_daoPackage.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_daoPackage.SkinTxt.WaterText = "";
            this.txt_daoPackage.TabIndex = 18;
            this.txt_daoPackage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_daoPackage.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_daoPackage.WaterText = "";
            this.txt_daoPackage.WordWrap = true;
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(29, 103);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(89, 17);
            this.skinLabel8.TabIndex = 17;
            this.skinLabel8.Text = "Dao package:";
            // 
            // cb_useActualColumnNames
            // 
            this.cb_useActualColumnNames.AutoSize = true;
            this.cb_useActualColumnNames.BackColor = System.Drawing.Color.Transparent;
            this.cb_useActualColumnNames.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb_useActualColumnNames.DownBack = null;
            this.cb_useActualColumnNames.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_useActualColumnNames.Location = new System.Drawing.Point(122, 311);
            this.cb_useActualColumnNames.MouseBack = null;
            this.cb_useActualColumnNames.Name = "cb_useActualColumnNames";
            this.cb_useActualColumnNames.NormlBack = null;
            this.cb_useActualColumnNames.SelectedDownBack = null;
            this.cb_useActualColumnNames.SelectedMouseBack = null;
            this.cb_useActualColumnNames.SelectedNormlBack = null;
            this.cb_useActualColumnNames.Size = new System.Drawing.Size(177, 21);
            this.cb_useActualColumnNames.TabIndex = 16;
            this.cb_useActualColumnNames.Text = "Use Actual ColumnNames";
            this.cb_useActualColumnNames.UseVisualStyleBackColor = false;
            // 
            // cb_trimStrings
            // 
            this.cb_trimStrings.AutoSize = true;
            this.cb_trimStrings.BackColor = System.Drawing.Color.Transparent;
            this.cb_trimStrings.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb_trimStrings.DownBack = null;
            this.cb_trimStrings.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_trimStrings.Location = new System.Drawing.Point(122, 284);
            this.cb_trimStrings.MouseBack = null;
            this.cb_trimStrings.Name = "cb_trimStrings";
            this.cb_trimStrings.NormlBack = null;
            this.cb_trimStrings.SelectedDownBack = null;
            this.cb_trimStrings.SelectedMouseBack = null;
            this.cb_trimStrings.SelectedNormlBack = null;
            this.cb_trimStrings.Size = new System.Drawing.Size(97, 21);
            this.cb_trimStrings.TabIndex = 15;
            this.cb_trimStrings.Text = "Trim Strings";
            this.cb_trimStrings.UseVisualStyleBackColor = false;
            // 
            // cb_enableSubPackages
            // 
            this.cb_enableSubPackages.AutoSize = true;
            this.cb_enableSubPackages.BackColor = System.Drawing.Color.Transparent;
            this.cb_enableSubPackages.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb_enableSubPackages.DownBack = null;
            this.cb_enableSubPackages.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_enableSubPackages.Location = new System.Drawing.Point(122, 257);
            this.cb_enableSubPackages.MouseBack = null;
            this.cb_enableSubPackages.Name = "cb_enableSubPackages";
            this.cb_enableSubPackages.NormlBack = null;
            this.cb_enableSubPackages.SelectedDownBack = null;
            this.cb_enableSubPackages.SelectedMouseBack = null;
            this.cb_enableSubPackages.SelectedNormlBack = null;
            this.cb_enableSubPackages.Size = new System.Drawing.Size(147, 21);
            this.cb_enableSubPackages.TabIndex = 14;
            this.cb_enableSubPackages.Text = "Enable SubPackages";
            this.cb_enableSubPackages.UseVisualStyleBackColor = false;
            // 
            // cb_forceBbigDecimals
            // 
            this.cb_forceBbigDecimals.AutoSize = true;
            this.cb_forceBbigDecimals.BackColor = System.Drawing.Color.Transparent;
            this.cb_forceBbigDecimals.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb_forceBbigDecimals.DownBack = null;
            this.cb_forceBbigDecimals.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_forceBbigDecimals.Location = new System.Drawing.Point(122, 230);
            this.cb_forceBbigDecimals.MouseBack = null;
            this.cb_forceBbigDecimals.Name = "cb_forceBbigDecimals";
            this.cb_forceBbigDecimals.NormlBack = null;
            this.cb_forceBbigDecimals.SelectedDownBack = null;
            this.cb_forceBbigDecimals.SelectedMouseBack = null;
            this.cb_forceBbigDecimals.SelectedNormlBack = null;
            this.cb_forceBbigDecimals.Size = new System.Drawing.Size(134, 21);
            this.cb_forceBbigDecimals.TabIndex = 13;
            this.cb_forceBbigDecimals.Text = "Force BigDecimals";
            this.cb_forceBbigDecimals.UseVisualStyleBackColor = false;
            // 
            // cb_removeComment
            // 
            this.cb_removeComment.AutoSize = true;
            this.cb_removeComment.BackColor = System.Drawing.Color.Transparent;
            this.cb_removeComment.Checked = true;
            this.cb_removeComment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_removeComment.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb_removeComment.DownBack = null;
            this.cb_removeComment.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_removeComment.Location = new System.Drawing.Point(122, 205);
            this.cb_removeComment.MouseBack = null;
            this.cb_removeComment.Name = "cb_removeComment";
            this.cb_removeComment.NormlBack = null;
            this.cb_removeComment.SelectedDownBack = null;
            this.cb_removeComment.SelectedMouseBack = null;
            this.cb_removeComment.SelectedNormlBack = null;
            this.cb_removeComment.Size = new System.Drawing.Size(154, 21);
            this.cb_removeComment.TabIndex = 12;
            this.cb_removeComment.Text = "Remove the comment";
            this.cb_removeComment.UseVisualStyleBackColor = false;
            // 
            // txt_targetRuntime
            // 
            this.txt_targetRuntime.BackColor = System.Drawing.Color.Transparent;
            this.txt_targetRuntime.DownBack = null;
            this.txt_targetRuntime.Icon = null;
            this.txt_targetRuntime.IconIsButton = false;
            this.txt_targetRuntime.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_targetRuntime.IsPasswordChat = '\0';
            this.txt_targetRuntime.IsSystemPasswordChar = false;
            this.txt_targetRuntime.Lines = new string[] {
        "MyBatis3"};
            this.txt_targetRuntime.Location = new System.Drawing.Point(122, 22);
            this.txt_targetRuntime.Margin = new System.Windows.Forms.Padding(0);
            this.txt_targetRuntime.MaxLength = 32767;
            this.txt_targetRuntime.MinimumSize = new System.Drawing.Size(28, 28);
            this.txt_targetRuntime.MouseBack = null;
            this.txt_targetRuntime.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_targetRuntime.Multiline = false;
            this.txt_targetRuntime.Name = "txt_targetRuntime";
            this.txt_targetRuntime.NormlBack = null;
            this.txt_targetRuntime.Padding = new System.Windows.Forms.Padding(5);
            this.txt_targetRuntime.ReadOnly = true;
            this.txt_targetRuntime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_targetRuntime.Size = new System.Drawing.Size(206, 28);
            // 
            // 
            // 
            this.txt_targetRuntime.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_targetRuntime.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_targetRuntime.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txt_targetRuntime.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txt_targetRuntime.SkinTxt.Name = "BaseText";
            this.txt_targetRuntime.SkinTxt.ReadOnly = true;
            this.txt_targetRuntime.SkinTxt.Size = new System.Drawing.Size(196, 18);
            this.txt_targetRuntime.SkinTxt.TabIndex = 0;
            this.txt_targetRuntime.SkinTxt.Text = "MyBatis3";
            this.txt_targetRuntime.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_targetRuntime.SkinTxt.WaterText = "";
            this.txt_targetRuntime.TabIndex = 11;
            this.txt_targetRuntime.Text = "MyBatis3";
            this.txt_targetRuntime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_targetRuntime.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_targetRuntime.WaterText = "";
            this.txt_targetRuntime.WordWrap = true;
            // 
            // skinLabel14
            // 
            this.skinLabel14.AutoSize = true;
            this.skinLabel14.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel14.BorderColor = System.Drawing.Color.White;
            this.skinLabel14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel14.Location = new System.Drawing.Point(69, 27);
            this.skinLabel14.Name = "skinLabel14";
            this.skinLabel14.Size = new System.Drawing.Size(49, 17);
            this.skinLabel14.TabIndex = 2;
            this.skinLabel14.Text = "Target:";
            // 
            // txt_modelPackage
            // 
            this.txt_modelPackage.BackColor = System.Drawing.Color.Transparent;
            this.txt_modelPackage.DownBack = null;
            this.txt_modelPackage.Icon = null;
            this.txt_modelPackage.IconIsButton = false;
            this.txt_modelPackage.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_modelPackage.IsPasswordChat = '\0';
            this.txt_modelPackage.IsSystemPasswordChar = false;
            this.txt_modelPackage.Lines = new string[0];
            this.txt_modelPackage.Location = new System.Drawing.Point(122, 62);
            this.txt_modelPackage.Margin = new System.Windows.Forms.Padding(0);
            this.txt_modelPackage.MaxLength = 32767;
            this.txt_modelPackage.MinimumSize = new System.Drawing.Size(28, 28);
            this.txt_modelPackage.MouseBack = null;
            this.txt_modelPackage.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txt_modelPackage.Multiline = false;
            this.txt_modelPackage.Name = "txt_modelPackage";
            this.txt_modelPackage.NormlBack = null;
            this.txt_modelPackage.Padding = new System.Windows.Forms.Padding(5);
            this.txt_modelPackage.ReadOnly = false;
            this.txt_modelPackage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_modelPackage.Size = new System.Drawing.Size(206, 28);
            // 
            // 
            // 
            this.txt_modelPackage.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_modelPackage.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_modelPackage.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txt_modelPackage.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txt_modelPackage.SkinTxt.Name = "BaseText";
            this.txt_modelPackage.SkinTxt.Size = new System.Drawing.Size(196, 18);
            this.txt_modelPackage.SkinTxt.TabIndex = 0;
            this.txt_modelPackage.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_modelPackage.SkinTxt.WaterText = "";
            this.txt_modelPackage.TabIndex = 10;
            this.txt_modelPackage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_modelPackage.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_modelPackage.WaterText = "";
            this.txt_modelPackage.WordWrap = true;
            // 
            // skinLabel20
            // 
            this.skinLabel20.AutoSize = true;
            this.skinLabel20.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel20.BorderColor = System.Drawing.Color.White;
            this.skinLabel20.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel20.Location = new System.Drawing.Point(17, 66);
            this.skinLabel20.Name = "skinLabel20";
            this.skinLabel20.Size = new System.Drawing.Size(103, 17);
            this.skinLabel20.TabIndex = 9;
            this.skinLabel20.Text = "Model package:";
            // 
            // label_connectStatus
            // 
            this.label_connectStatus.AutoSize = true;
            this.label_connectStatus.BackColor = System.Drawing.Color.Transparent;
            this.label_connectStatus.BorderColor = System.Drawing.Color.White;
            this.label_connectStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_connectStatus.ForeColor = System.Drawing.Color.Green;
            this.label_connectStatus.Location = new System.Drawing.Point(7, 406);
            this.label_connectStatus.Name = "label_connectStatus";
            this.label_connectStatus.Size = new System.Drawing.Size(149, 17);
            this.label_connectStatus.TabIndex = 22;
            this.label_connectStatus.Text = "Connected successfully !";
            // 
            // Workbench
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 431);
            this.Controls.Add(this.label_connectStatus);
            this.Controls.Add(this.panel_initResource);
            this.Controls.Add(this.tb_next);
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Workbench";
            this.Text = "Workbench (Mybatis Generator)";
            this.Load += new System.EventHandler(this.Workbench_Load);
            this.panel_initResource.ResumeLayout(false);
            this.panel_initResource.PerformLayout();
            this.panel_generate.ResumeLayout(false);
            this.panel_generate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton tb_next;
        private CCWin.SkinControl.SkinComboBox cbx_databaseList;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinTextBox txt_userName;
        private CCWin.SkinControl.SkinTextBox txt_password;
        private CCWin.SkinControl.SkinTextBox txt_ip;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinTextBox txt_port;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinComboBox cbx_scheme;
        private CCWin.SkinControl.SkinButton btn_initlize;
        private CCWin.SkinControl.SkinPanel panel_initResource;
        private CCWin.SkinControl.SkinLabel label_ip;
        private CCWin.SkinControl.SkinLabel label_password;
        private CCWin.SkinControl.SkinLabel label_userName;
        private CCWin.SkinControl.SkinLabel label_port;
        private CCWin.SkinControl.SkinLabel label_scheme;
        private CCWin.SkinControl.SkinLabel label_connectStatus;
        private CCWin.SkinControl.SkinPanel panel_generate;
        private CCWin.SkinControl.SkinLabel skinLabel14;
        private CCWin.SkinControl.SkinTextBox txt_modelPackage;
        private CCWin.SkinControl.SkinLabel skinLabel20;
        private CCWin.SkinControl.SkinTextBox txt_targetRuntime;
        private CCWin.SkinControl.SkinCheckBox cb_removeComment;
        private CCWin.SkinControl.SkinCheckBox cb_forceBbigDecimals;
        private CCWin.SkinControl.SkinCheckBox cb_useActualColumnNames;
        private CCWin.SkinControl.SkinCheckBox cb_trimStrings;
        private CCWin.SkinControl.SkinCheckBox cb_enableSubPackages;
        private CCWin.SkinControl.SkinTextBox txt_daoPackage;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinTextBox txt_mapperPackage;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinComboBox cbx_tables;
    }
}

