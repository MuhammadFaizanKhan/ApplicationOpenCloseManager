namespace Application_Start_Close_Manager
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
            this.tbExeLocation = new System.Windows.Forms.TextBox();
            this.tbExeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbApplicationStartTime = new System.Windows.Forms.ListBox();
            this.lbApplicationEndTime = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbExeLocation
            // 
            this.tbExeLocation.Location = new System.Drawing.Point(208, 88);
            this.tbExeLocation.Name = "tbExeLocation";
            this.tbExeLocation.Size = new System.Drawing.Size(240, 20);
            this.tbExeLocation.TabIndex = 0;
            this.tbExeLocation.Text = "D:\\ZKTeco C#\\Build\\Debug\\";
            // 
            // tbExeName
            // 
            this.tbExeName.Location = new System.Drawing.Point(208, 128);
            this.tbExeName.Name = "tbExeName";
            this.tbExeName.Size = new System.Drawing.Size(240, 20);
            this.tbExeName.TabIndex = 1;
            this.tbExeName.Text = "BioMetrixCore.exe1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "App Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(200, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Application Open/Close Manager";
            // 
            // lbApplicationStartTime
            // 
            this.lbApplicationStartTime.BackColor = System.Drawing.Color.DarkGreen;
            this.lbApplicationStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationStartTime.ForeColor = System.Drawing.SystemColors.Window;
            this.lbApplicationStartTime.FormattingEnabled = true;
            this.lbApplicationStartTime.ItemHeight = 25;
            this.lbApplicationStartTime.Location = new System.Drawing.Point(24, 208);
            this.lbApplicationStartTime.Name = "lbApplicationStartTime";
            this.lbApplicationStartTime.Size = new System.Drawing.Size(280, 229);
            this.lbApplicationStartTime.TabIndex = 18;
            // 
            // lbApplicationEndTime
            // 
            this.lbApplicationEndTime.BackColor = System.Drawing.Color.Maroon;
            this.lbApplicationEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationEndTime.ForeColor = System.Drawing.SystemColors.Window;
            this.lbApplicationEndTime.FormattingEnabled = true;
            this.lbApplicationEndTime.ItemHeight = 25;
            this.lbApplicationEndTime.Location = new System.Drawing.Point(376, 208);
            this.lbApplicationEndTime.Name = "lbApplicationEndTime";
            this.lbApplicationEndTime.Size = new System.Drawing.Size(280, 229);
            this.lbApplicationEndTime.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(472, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "e.g., C:\\ABCApp\\";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(472, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "e.g., abc.exe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Note: Add applicatin path, name and applicaiton open close timing in ScheduleTime" +
    " text file.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Start Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "End Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 469);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbApplicationEndTime);
            this.Controls.Add(this.lbApplicationStartTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbExeName);
            this.Controls.Add(this.tbExeLocation);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Application Open/Close Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbExeLocation;
        private System.Windows.Forms.TextBox tbExeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbApplicationStartTime;
        private System.Windows.Forms.ListBox lbApplicationEndTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

