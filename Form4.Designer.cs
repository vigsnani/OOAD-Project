namespace SwiftPayRoll
{
    partial class Form4
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
            this.Calculate_Payroll = new System.Windows.Forms.Button();
            this.View_Payslip = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SwiftPayRoll.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Calculate_Payroll
            // 
            this.Calculate_Payroll.Location = new System.Drawing.Point(36, 112);
            this.Calculate_Payroll.Name = "Calculate_Payroll";
            this.Calculate_Payroll.Size = new System.Drawing.Size(114, 32);
            this.Calculate_Payroll.TabIndex = 1;
            this.Calculate_Payroll.Text = "Calculate Payroll";
            this.Calculate_Payroll.UseVisualStyleBackColor = true;
            this.Calculate_Payroll.Click += new System.EventHandler(this.Calculate_Payroll_Click);
            // 
            // View_Payslip
            // 
            this.View_Payslip.Location = new System.Drawing.Point(213, 112);
            this.View_Payslip.Name = "View_Payslip";
            this.View_Payslip.Size = new System.Drawing.Size(123, 32);
            this.View_Payslip.TabIndex = 2;
            this.View_Payslip.Text = "View payroll details";
            this.View_Payslip.UseVisualStyleBackColor = true;
            this.View_Payslip.Click += new System.EventHandler(this.View_Payslip_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(290, 21);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(46, 32);
            this.Home.TabIndex = 3;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dataGridView1.Location = new System.Drawing.Point(11, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 257);
            this.dataGridView1.TabIndex = 4;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.View_Payslip);
            this.Controls.Add(this.Calculate_Payroll);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Calculate_Payroll;
        private System.Windows.Forms.Button View_Payslip;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
    }
}