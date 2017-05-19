namespace SwiftPayRoll
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Employee_Data = new System.Windows.Forms.Button();
            this.Job_Data = new System.Windows.Forms.Button();
            this.Payroll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SwiftPayRoll.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Employee_Data
            // 
            this.Employee_Data.Location = new System.Drawing.Point(15, 115);
            this.Employee_Data.Margin = new System.Windows.Forms.Padding(2);
            this.Employee_Data.Name = "Employee_Data";
            this.Employee_Data.Size = new System.Drawing.Size(187, 136);
            this.Employee_Data.TabIndex = 1;
            this.Employee_Data.Text = "Employee Data";
            this.Employee_Data.UseVisualStyleBackColor = true;
            this.Employee_Data.Click += new System.EventHandler(this.Employee_Data_Click);
            // 
            // Job_Data
            // 
            this.Job_Data.Location = new System.Drawing.Point(401, 115);
            this.Job_Data.Margin = new System.Windows.Forms.Padding(2);
            this.Job_Data.Name = "Job_Data";
            this.Job_Data.Size = new System.Drawing.Size(177, 136);
            this.Job_Data.TabIndex = 2;
            this.Job_Data.Text = "Job Data";
            this.Job_Data.UseVisualStyleBackColor = true;
            this.Job_Data.Click += new System.EventHandler(this.Job_Data_Click);
            // 
            // Payroll
            // 
            this.Payroll.Location = new System.Drawing.Point(207, 115);
            this.Payroll.Name = "Payroll";
            this.Payroll.Size = new System.Drawing.Size(189, 136);
            this.Payroll.TabIndex = 3;
            this.Payroll.Text = "Payroll";
            this.Payroll.UseVisualStyleBackColor = true;
            this.Payroll.Click += new System.EventHandler(this.Payroll_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 266);
            this.Controls.Add(this.Payroll);
            this.Controls.Add(this.Job_Data);
            this.Controls.Add(this.Employee_Data);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Employee_Data;
        private System.Windows.Forms.Button Job_Data;
        private System.Windows.Forms.Button Payroll;
    }
}