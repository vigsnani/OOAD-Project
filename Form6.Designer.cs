namespace SwiftPayRoll
{
    partial class Form6
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
            this.Employee_ID = new System.Windows.Forms.Label();
            this.EmpID = new System.Windows.Forms.TextBox();
            this.View_Payslip = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Employee_ID
            // 
            this.Employee_ID.AutoSize = true;
            this.Employee_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_ID.Location = new System.Drawing.Point(12, 62);
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.Size = new System.Drawing.Size(97, 16);
            this.Employee_ID.TabIndex = 0;
            this.Employee_ID.Text = "Employee ID";
            // 
            // EmpID
            // 
            this.EmpID.Location = new System.Drawing.Point(115, 62);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(173, 20);
            this.EmpID.TabIndex = 1;
            // 
            // View_Payslip
            // 
            this.View_Payslip.Location = new System.Drawing.Point(115, 107);
            this.View_Payslip.Name = "View_Payslip";
            this.View_Payslip.Size = new System.Drawing.Size(75, 23);
            this.View_Payslip.TabIndex = 2;
            this.View_Payslip.Text = "View Payroll";
            this.View_Payslip.UseVisualStyleBackColor = true;
            this.View_Payslip.Click += new System.EventHandler(this.View_Payslip_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(169, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(60, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "<- Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(235, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(53, 23);
            this.Home.TabIndex = 4;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.View_Payslip);
            this.Controls.Add(this.EmpID);
            this.Controls.Add(this.Employee_ID);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Employee_ID;
        private System.Windows.Forms.TextBox EmpID;
        private System.Windows.Forms.Button View_Payslip;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Home;
    }
}