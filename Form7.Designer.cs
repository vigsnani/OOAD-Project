namespace SwiftPayRoll
{
    partial class Form7
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
            this.AddJobID = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.JobID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddJobID
            // 
            this.AddJobID.Location = new System.Drawing.Point(252, 79);
            this.AddJobID.Name = "AddJobID";
            this.AddJobID.Size = new System.Drawing.Size(98, 49);
            this.AddJobID.TabIndex = 0;
            this.AddJobID.Text = "Add new Designation";
            this.AddJobID.UseVisualStyleBackColor = true;
            this.AddJobID.Click += new System.EventHandler(this.AddJobID_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(76, 105);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 1;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // JobID
            // 
            this.JobID.AutoSize = true;
            this.JobID.Location = new System.Drawing.Point(12, 82);
            this.JobID.Name = "JobID";
            this.JobID.Size = new System.Drawing.Size(97, 13);
            this.JobID.TabIndex = 2;
            this.JobID.Text = "Job Designation ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(115, 79);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(108, 20);
            this.ID.TabIndex = 3;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 267);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.JobID);
            this.Controls.Add(this.search);
            this.Controls.Add(this.AddJobID);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddJobID;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label JobID;
        private System.Windows.Forms.TextBox ID;

    }
}