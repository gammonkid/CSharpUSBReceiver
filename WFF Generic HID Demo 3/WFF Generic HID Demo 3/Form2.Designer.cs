namespace WFF_Generic_HID_Demo_3
{
    partial class Form2
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
            this.Sensitivity = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sensitivity
            // 
            this.Sensitivity.AutoSize = true;
            this.Sensitivity.BackColor = System.Drawing.SystemColors.Control;
            this.Sensitivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sensitivity.Location = new System.Drawing.Point(47, 57);
            this.Sensitivity.Name = "Sensitivity";
            this.Sensitivity.Size = new System.Drawing.Size(193, 15);
            this.Sensitivity.TabIndex = 0;
            this.Sensitivity.Text = "Move the slider to adjust the sensitivity.";
            this.Sensitivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sensitivity.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 95);
            this.trackBar1.Maximum = 512;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(260, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // returnButton
            // 
            this.returnButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.returnButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.returnButton.Location = new System.Drawing.Point(99, 146);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "OK";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Sensitivity);
            this.Name = "Form2";
            this.Text = "Set Sensitivity";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sensitivity;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button returnButton;
    }
}