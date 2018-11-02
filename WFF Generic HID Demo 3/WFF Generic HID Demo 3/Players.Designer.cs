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
            this.lblAssociatedPlayer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPacketLength = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(274, 9);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(583, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAssociatedPlayer);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblPacketLength);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblConnectionStatus);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(274, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 205);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Device Connection Status";
            // 
            // lblAssociatedPlayer
            // 
            this.lblAssociatedPlayer.AutoSize = true;
            this.lblAssociatedPlayer.Location = new System.Drawing.Point(144, 70);
            this.lblAssociatedPlayer.Name = "lblAssociatedPlayer";
            this.lblAssociatedPlayer.Size = new System.Drawing.Size(31, 13);
            this.lblAssociatedPlayer.TabIndex = 5;
            this.lblAssociatedPlayer.Text = "none";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 70);
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
            this.lblConnectionStatus.Location = new System.Drawing.Point(140, 16);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(76, 13);
            this.lblConnectionStatus.TabIndex = 1;
            this.lblConnectionStatus.Text = "not connected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Device is currently:";
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTeamName);
            this.Name = "Players";
            this.Text = "Players";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}