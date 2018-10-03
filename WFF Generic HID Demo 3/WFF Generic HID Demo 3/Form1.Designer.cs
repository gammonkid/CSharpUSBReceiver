namespace WFF_Generic_HID_Demo_3
    {
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toggleLedStateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ledStateLabel = new System.Windows.Forms.Label();
            this.pushButtonStateLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.debugCollectionTimer = new System.Windows.Forms.Timer(this.components);
            this.xGraph = new System.Windows.Forms.RadioButton();
            this.zGraph = new System.Windows.Forms.RadioButton();
            this.yGraph = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pause = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GraphSpace = new System.Windows.Forms.PictureBox();
            this.MinValue = new System.Windows.Forms.Label();
            this.MaxValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.returnValue = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(895, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel1.Text = "USB Status unknown";
            // 
            // toggleLedStateButton
            // 
            this.toggleLedStateButton.Location = new System.Drawing.Point(12, 4);
            this.toggleLedStateButton.Name = "toggleLedStateButton";
            this.toggleLedStateButton.Size = new System.Drawing.Size(115, 23);
            this.toggleLedStateButton.TabIndex = 3;
            this.toggleLedStateButton.Text = "Toggle LED State";
            this.toggleLedStateButton.UseVisualStyleBackColor = true;
            this.toggleLedStateButton.Click += new System.EventHandler(this.toggleLedStateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Query Rate: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "LED State:";
            // 
            // ledStateLabel
            // 
            this.ledStateLabel.AutoSize = true;
            this.ledStateLabel.Location = new System.Drawing.Point(202, 9);
            this.ledStateLabel.Name = "ledStateLabel";
            this.ledStateLabel.Size = new System.Drawing.Size(53, 13);
            this.ledStateLabel.TabIndex = 6;
            this.ledStateLabel.Text = "Unknown";
            // 
            // pushButtonStateLabel
            // 
            this.pushButtonStateLabel.AutoSize = true;
            this.pushButtonStateLabel.Location = new System.Drawing.Point(345, 9);
            this.pushButtonStateLabel.Name = "pushButtonStateLabel";
            this.pushButtonStateLabel.Size = new System.Drawing.Size(53, 13);
            this.pushButtonStateLabel.TabIndex = 7;
            this.pushButtonStateLabel.Text = "Unknown";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // debugCollectionTimer
            // 
            this.debugCollectionTimer.Enabled = true;
            this.debugCollectionTimer.Interval = 10;
            this.debugCollectionTimer.Tick += new System.EventHandler(this.debugCollectionTimer_Tick);
            // 
            // xGraph
            // 
            this.xGraph.AutoSize = true;
            this.xGraph.Location = new System.Drawing.Point(4, 15);
            this.xGraph.Name = "xGraph";
            this.xGraph.Size = new System.Drawing.Size(32, 17);
            this.xGraph.TabIndex = 8;
            this.xGraph.Text = "X";
            this.xGraph.UseVisualStyleBackColor = true;
            this.xGraph.CheckedChanged += new System.EventHandler(this.xGraph_CheckedChanged);
            // 
            // zGraph
            // 
            this.zGraph.AutoSize = true;
            this.zGraph.Location = new System.Drawing.Point(186, 15);
            this.zGraph.Name = "zGraph";
            this.zGraph.Size = new System.Drawing.Size(32, 17);
            this.zGraph.TabIndex = 10;
            this.zGraph.Text = "Z";
            this.zGraph.UseVisualStyleBackColor = true;
            this.zGraph.CheckedChanged += new System.EventHandler(this.zGraph_CheckedChanged);
            // 
            // yGraph
            // 
            this.yGraph.AutoSize = true;
            this.yGraph.Location = new System.Drawing.Point(95, 15);
            this.yGraph.Name = "yGraph";
            this.yGraph.Size = new System.Drawing.Size(32, 17);
            this.yGraph.TabIndex = 9;
            this.yGraph.Text = "Y";
            this.yGraph.UseVisualStyleBackColor = true;
            this.yGraph.CheckedChanged += new System.EventHandler(this.yGraph_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zGraph);
            this.groupBox1.Controls.Add(this.yGraph);
            this.groupBox1.Controls.Add(this.xGraph);
            this.groupBox1.Location = new System.Drawing.Point(444, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 37);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graph";
            // 
            // pause
            // 
            this.pause.AutoSize = true;
            this.pause.Location = new System.Drawing.Point(717, 19);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(56, 17);
            this.pause.TabIndex = 12;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current Max:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Current Min:";
            // 
            // GraphSpace
            // 
            this.GraphSpace.Location = new System.Drawing.Point(10, 141);
            this.GraphSpace.Name = "GraphSpace";
            this.GraphSpace.Size = new System.Drawing.Size(862, 226);
            this.GraphSpace.TabIndex = 11;
            this.GraphSpace.TabStop = false;
            // 
            // MinValue
            // 
            this.MinValue.AutoSize = true;
            this.MinValue.Location = new System.Drawing.Point(345, 28);
            this.MinValue.Name = "MinValue";
            this.MinValue.Size = new System.Drawing.Size(53, 13);
            this.MinValue.TabIndex = 16;
            this.MinValue.Text = "Unknown";
            // 
            // MaxValue
            // 
            this.MaxValue.AutoSize = true;
            this.MaxValue.Location = new System.Drawing.Point(202, 28);
            this.MaxValue.Name = "MaxValue";
            this.MaxValue.Size = new System.Drawing.Size(53, 13);
            this.MaxValue.TabIndex = 15;
            this.MaxValue.Text = "Unknown";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Set Sensitivity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // returnValue
            // 
            this.returnValue.Location = new System.Drawing.Point(140, 80);
            this.returnValue.Name = "returnValue";
            this.returnValue.Size = new System.Drawing.Size(73, 20);
            this.returnValue.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 394);
            this.Controls.Add(this.returnValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MinValue);
            this.Controls.Add(this.MaxValue);
            this.Controls.Add(this.GraphSpace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.pushButtonStateLabel);
            this.Controls.Add(this.ledStateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toggleLedStateButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "WFF Generic HID Demo 3";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button toggleLedStateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ledStateLabel;
        private System.Windows.Forms.Label pushButtonStateLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer debugCollectionTimer;
        private System.Windows.Forms.RadioButton xGraph;
        private System.Windows.Forms.RadioButton zGraph;
        private System.Windows.Forms.RadioButton yGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox pause;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox GraphSpace;
        private System.Windows.Forms.Label MinValue;
        private System.Windows.Forms.Label MaxValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox returnValue;
    }
    }

