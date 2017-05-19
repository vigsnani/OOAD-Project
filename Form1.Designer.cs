namespace SwiftPayRoll
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
            this.EmpID = new System.Windows.Forms.Label();
            this.EmpIDTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Search = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpID
            // 
            this.EmpID.AutoSize = true;
            this.EmpID.Location = new System.Drawing.Point(49, 127);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(79, 13);
            this.EmpID.TabIndex = 0;
            this.EmpID.Text = "Employee ID   :";
            // 
            // EmpIDTB
            // 
            this.EmpIDTB.Location = new System.Drawing.Point(134, 124);
            this.EmpIDTB.Name = "EmpIDTB";
            this.EmpIDTB.Size = new System.Drawing.Size(100, 20);
            this.EmpIDTB.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SwiftPayRoll.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(93, 150);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(307, 124);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(112, 40);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add New Employee";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(276, 24);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(63, 30);
            this.Back.TabIndex = 5;
            this.Back.Text = "<- Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(358, 24);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(61, 30);
            this.Home.TabIndex = 6;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 221);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EmpIDTB);
            this.Controls.Add(this.EmpID);
            this.Name = "Form1";
            this.Text = "Employee Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmpID;
        private System.Windows.Forms.TextBox EmpIDTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Home;
    }
}

