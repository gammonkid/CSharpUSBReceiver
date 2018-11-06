namespace WFF_Generic_HID_Demo_3
{
    partial class Players
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_Position = new System.Windows.Forms.CheckBox();
            this.chk_Jersey = new System.Windows.Forms.CheckBox();
            this.chk_lastName = new System.Windows.Forms.CheckBox();
            this.chk_firstName = new System.Windows.Forms.CheckBox();
            this.cmboxPosition = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_Jersey = new System.Windows.Forms.TextBox();
            this.txtbox_lastName = new System.Windows.Forms.TextBox();
            this.txtbx_firstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGameAss = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_sendData = new System.Windows.Forms.Button();
            this.lblAssociatedPlayer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPacketLength = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tmr_pollDevice = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSubmitGame = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.txtTheirScore = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMyScore = new System.Windows.Forms.TextBox();
            this.txtOpponent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpBoxStats = new System.Windows.Forms.GroupBox();
            this.lblMaxHitText = new System.Windows.Forms.Label();
            this.lblAvgHitText = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmBoxGameSelect = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(7, 9);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(35, 13);
            this.lblTeamName.TabIndex = 0;
            this.lblTeamName.Text = "label1";
            this.lblTeamName.Click += new System.EventHandler(this.lblTeamName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_Position);
            this.groupBox1.Controls.Add(this.chk_Jersey);
            this.groupBox1.Controls.Add(this.chk_lastName);
            this.groupBox1.Controls.Add(this.chk_firstName);
            this.groupBox1.Controls.Add(this.cmboxPosition);
            this.groupBox1.Controls.Add(this.btn_Submit);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtbx_Jersey);
            this.groupBox1.Controls.Add(this.txtbox_lastName);
            this.groupBox1.Controls.Add(this.txtbx_firstName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(293, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "new player";
            // 
            // chk_Position
            // 
            this.chk_Position.AutoCheck = false;
            this.chk_Position.AutoSize = true;
            this.chk_Position.Location = new System.Drawing.Point(200, 90);
            this.chk_Position.Name = "chk_Position";
            this.chk_Position.Size = new System.Drawing.Size(15, 14);
            this.chk_Position.TabIndex = 14;
            this.chk_Position.UseVisualStyleBackColor = true;
            this.chk_Position.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_Jersey
            // 
            this.chk_Jersey.AutoCheck = false;
            this.chk_Jersey.AutoSize = true;
            this.chk_Jersey.Location = new System.Drawing.Point(200, 63);
            this.chk_Jersey.Name = "chk_Jersey";
            this.chk_Jersey.Size = new System.Drawing.Size(15, 14);
            this.chk_Jersey.TabIndex = 13;
            this.chk_Jersey.UseVisualStyleBackColor = true;
            this.chk_Jersey.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_lastName
            // 
            this.chk_lastName.AutoCheck = false;
            this.chk_lastName.AutoSize = true;
            this.chk_lastName.Location = new System.Drawing.Point(200, 38);
            this.chk_lastName.Name = "chk_lastName";
            this.chk_lastName.Size = new System.Drawing.Size(15, 14);
            this.chk_lastName.TabIndex = 12;
            this.chk_lastName.UseVisualStyleBackColor = true;
            this.chk_lastName.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chk_firstName
            // 
            this.chk_firstName.AutoCheck = false;
            this.chk_firstName.AutoSize = true;
            this.chk_firstName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chk_firstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk_firstName.Location = new System.Drawing.Point(200, 16);
            this.chk_firstName.Name = "chk_firstName";
            this.chk_firstName.Size = new System.Drawing.Size(15, 14);
            this.chk_firstName.TabIndex = 11;
            this.chk_firstName.UseVisualStyleBackColor = false;
            this.chk_firstName.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // cmboxPosition
            // 
            this.cmboxPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmboxPosition.FormattingEnabled = true;
            this.cmboxPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmboxPosition.Items.AddRange(new object[] {
            "",
            "QB",
            "RB",
            "FB",
            "WR",
            "TE",
            "OL",
            "C",
            "G",
            "LG",
            "RG",
            "T",
            "LT",
            "RT",
            "K",
            "KR",
            "DL",
            "DE",
            "DT",
            "NT",
            "LB",
            "ILB",
            "OLB",
            "MLB",
            "DB",
            "CB",
            "FS",
            "SS",
            "S",
            "P",
            "PR"});
            this.cmboxPosition.Location = new System.Drawing.Point(94, 87);
            this.cmboxPosition.Name = "cmboxPosition";
            this.cmboxPosition.Size = new System.Drawing.Size(100, 21);
            this.cmboxPosition.TabIndex = 2;
            this.cmboxPosition.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(140, 125);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 130);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "waiting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "status:";
            // 
            // txtbx_Jersey
            // 
            this.txtbx_Jersey.Location = new System.Drawing.Point(94, 60);
            this.txtbx_Jersey.Name = "txtbx_Jersey";
            this.txtbx_Jersey.Size = new System.Drawing.Size(100, 20);
            this.txtbx_Jersey.TabIndex = 6;
            this.txtbx_Jersey.TextChanged += new System.EventHandler(this.txtbx_Jersey_TextChanged);
            // 
            // txtbox_lastName
            // 
            this.txtbox_lastName.Location = new System.Drawing.Point(94, 36);
            this.txtbox_lastName.Name = "txtbox_lastName";
            this.txtbox_lastName.Size = new System.Drawing.Size(100, 20);
            this.txtbox_lastName.TabIndex = 5;
            this.txtbox_lastName.TextChanged += new System.EventHandler(this.txtbox_lastName_TextChanged);
            // 
            // txtbx_firstName
            // 
            this.txtbx_firstName.Location = new System.Drawing.Point(94, 16);
            this.txtbx_firstName.Name = "txtbx_firstName";
            this.txtbx_firstName.Size = new System.Drawing.Size(100, 20);
            this.txtbx_firstName.TabIndex = 4;
            this.txtbx_firstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jersey Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "YYYY-MM-DD";
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGameAss);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btn_sendData);
            this.groupBox2.Controls.Add(this.lblAssociatedPlayer);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblPacketLength);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblConnectionStatus);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(274, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 205);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device Connection Status";
            // 
            // lblGameAss
            // 
            this.lblGameAss.AutoSize = true;
            this.lblGameAss.Location = new System.Drawing.Point(104, 97);
            this.lblGameAss.Name = "lblGameAss";
            this.lblGameAss.Size = new System.Drawing.Size(31, 13);
            this.lblGameAss.TabIndex = 8;
            this.lblGameAss.Text = "none";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "game association:";
            // 
            // btn_sendData
            // 
            this.btn_sendData.Location = new System.Drawing.Point(66, 118);
            this.btn_sendData.Name = "btn_sendData";
            this.btn_sendData.Size = new System.Drawing.Size(75, 23);
            this.btn_sendData.TabIndex = 6;
            this.btn_sendData.Text = "Send Data";
            this.btn_sendData.UseVisualStyleBackColor = true;
            this.btn_sendData.Click += new System.EventHandler(this.btn_sendData_Click);
            // 
            // lblAssociatedPlayer
            // 
            this.lblAssociatedPlayer.AutoSize = true;
            this.lblAssociatedPlayer.Location = new System.Drawing.Point(106, 70);
            this.lblAssociatedPlayer.Name = "lblAssociatedPlayer";
            this.lblAssociatedPlayer.Size = new System.Drawing.Size(31, 13);
            this.lblAssociatedPlayer.TabIndex = 5;
            this.lblAssociatedPlayer.Text = "none";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "player association:";
            // 
            // lblPacketLength
            // 
            this.lblPacketLength.AutoSize = true;
            this.lblPacketLength.Location = new System.Drawing.Point(143, 40);
            this.lblPacketLength.Name = "lblPacketLength";
            this.lblPacketLength.Size = new System.Drawing.Size(51, 13);
            this.lblPacketLength.TabIndex = 3;
            this.lblPacketLength.Text = "unknown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Num of packets on device:";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(143, 16);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(76, 13);
            this.lblConnectionStatus.TabIndex = 1;
            this.lblConnectionStatus.Text = "not connected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Device is currently:";
            // 
            // tmr_pollDevice
            // 
            this.tmr_pollDevice.Interval = 1000;
            this.tmr_pollDevice.Tick += new System.EventHandler(this.tmr_pollDevice_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSubmitGame);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtOpponent);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Location = new System.Drawing.Point(605, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 154);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "new Game";
            // 
            // btnSubmitGame
            // 
            this.btnSubmitGame.Location = new System.Drawing.Point(73, 126);
            this.btnSubmitGame.Name = "btnSubmitGame";
            this.btnSubmitGame.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitGame.TabIndex = 6;
            this.btnSubmitGame.Text = "submit";
            this.btnSubmitGame.UseVisualStyleBackColor = true;
            this.btnSubmitGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblOutcome);
            this.groupBox4.Controls.Add(this.txtTheirScore);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtMyScore);
            this.groupBox4.Location = new System.Drawing.Point(10, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 54);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "score";
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(71, 41);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(50, 13);
            this.lblOutcome.TabIndex = 3;
            this.lblOutcome.Text = "no Score";
            // 
            // txtTheirScore
            // 
            this.txtTheirScore.Location = new System.Drawing.Point(128, 18);
            this.txtTheirScore.Name = "txtTheirScore";
            this.txtTheirScore.Size = new System.Drawing.Size(50, 20);
            this.txtTheirScore.TabIndex = 2;
            this.txtTheirScore.TextChanged += new System.EventHandler(this.txtTheirScore_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "---";
            // 
            // txtMyScore
            // 
            this.txtMyScore.Location = new System.Drawing.Point(7, 19);
            this.txtMyScore.Name = "txtMyScore";
            this.txtMyScore.Size = new System.Drawing.Size(50, 20);
            this.txtMyScore.TabIndex = 0;
            this.txtMyScore.TextChanged += new System.EventHandler(this.txtMyScore_TextChanged);
            // 
            // txtOpponent
            // 
            this.txtOpponent.Location = new System.Drawing.Point(73, 43);
            this.txtOpponent.Name = "txtOpponent";
            this.txtOpponent.Size = new System.Drawing.Size(100, 20);
            this.txtOpponent.TabIndex = 4;
            this.txtOpponent.TextChanged += new System.EventHandler(this.txtOpponent_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Opponent -";
            // 
            // grpBoxStats
            // 
            this.grpBoxStats.Controls.Add(this.lblMaxHitText);
            this.grpBoxStats.Controls.Add(this.lblAvgHitText);
            this.grpBoxStats.Controls.Add(this.label14);
            this.grpBoxStats.Controls.Add(this.cmBoxGameSelect);
            this.grpBoxStats.Location = new System.Drawing.Point(542, 13);
            this.grpBoxStats.Name = "grpBoxStats";
            this.grpBoxStats.Size = new System.Drawing.Size(327, 202);
            this.grpBoxStats.TabIndex = 5;
            this.grpBoxStats.TabStop = false;
            this.grpBoxStats.Text = "Game Stats for All Players";
            // 
            // lblMaxHitText
            // 
            this.lblMaxHitText.AutoSize = true;
            this.lblMaxHitText.Location = new System.Drawing.Point(10, 66);
            this.lblMaxHitText.Name = "lblMaxHitText";
            this.lblMaxHitText.Size = new System.Drawing.Size(133, 13);
            this.lblMaxHitText.TabIndex = 18;
            this.lblMaxHitText.Text = "Maximum Hit for All Players";
            // 
            // lblAvgHitText
            // 
            this.lblAvgHitText.AutoSize = true;
            this.lblAvgHitText.Location = new System.Drawing.Point(10, 42);
            this.lblAvgHitText.Name = "lblAvgHitText";
            this.lblAvgHitText.Size = new System.Drawing.Size(129, 13);
            this.lblAvgHitText.TabIndex = 17;
            this.lblAvgHitText.Text = "Average Hit for All Players";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "selected Game:";
            // 
            // cmBoxGameSelect
            // 
            this.cmBoxGameSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmBoxGameSelect.FormattingEnabled = true;
            this.cmBoxGameSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmBoxGameSelect.Location = new System.Drawing.Point(94, 15);
            this.cmBoxGameSelect.Name = "cmBoxGameSelect";
            this.cmBoxGameSelect.Size = new System.Drawing.Size(227, 21);
            this.cmBoxGameSelect.TabIndex = 15;
            this.cmBoxGameSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "All Players",
            "QB",
            "RB",
            "FB",
            "WR",
            "TE",
            "OL",
            "C",
            "G",
            "LG",
            "RG",
            "T",
            "LT",
            "RT",
            "K",
            "KR",
            "DL",
            "DE",
            "DT",
            "NT",
            "LB",
            "ILB",
            "OLB",
            "MLB",
            "DB",
            "CB",
            "FS",
            "SS",
            "S",
            "P",
            "PR"});
            this.comboBox1.Location = new System.Drawing.Point(107, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "All Players";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "filter:";
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 398);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grpBoxStats);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTeamName);
            this.Name = "Players";
            this.Text = "Players";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpBoxStats.ResumeLayout(false);
            this.grpBoxStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbx_Jersey;
        private System.Windows.Forms.TextBox txtbox_lastName;
        private System.Windows.Forms.TextBox txtbx_firstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmboxPosition;
        private System.Windows.Forms.CheckBox chk_Position;
        private System.Windows.Forms.CheckBox chk_Jersey;
        private System.Windows.Forms.CheckBox chk_lastName;
        private System.Windows.Forms.CheckBox chk_firstName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAssociatedPlayer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPacketLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_sendData;
        private System.Windows.Forms.Timer tmr_pollDevice;
        private System.Windows.Forms.ComboBox cmBoxGameSelect;
        private System.Windows.Forms.Label lblGameAss;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSubmitGame;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.TextBox txtTheirScore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMyScore;
        private System.Windows.Forms.TextBox txtOpponent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpBoxStats;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMaxHitText;
        private System.Windows.Forms.Label lblAvgHitText;
    }
}