namespace Group11
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.Main_Customer = new System.Windows.Forms.Button();
            this.Main_Employee = new System.Windows.Forms.Button();
            this.pictureBox_curtain = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_curtain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Customer
            // 
            this.Main_Customer.BackColor = System.Drawing.Color.DimGray;
            this.Main_Customer.Font = new System.Drawing.Font("Adobe Heiti Std R", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Main_Customer.ForeColor = System.Drawing.Color.White;
            this.Main_Customer.Location = new System.Drawing.Point(473, 410);
            this.Main_Customer.Name = "Main_Customer";
            this.Main_Customer.Size = new System.Drawing.Size(156, 88);
            this.Main_Customer.TabIndex = 0;
            this.Main_Customer.Text = "לקוח";
            this.Main_Customer.UseVisualStyleBackColor = false;
            this.Main_Customer.Click += new System.EventHandler(this.Main_Customer_Click);
            // 
            // Main_Employee
            // 
            this.Main_Employee.BackColor = System.Drawing.Color.DimGray;
            this.Main_Employee.Font = new System.Drawing.Font("Adobe Heiti Std R", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Main_Employee.ForeColor = System.Drawing.Color.White;
            this.Main_Employee.Location = new System.Drawing.Point(473, 504);
            this.Main_Employee.Name = "Main_Employee";
            this.Main_Employee.Size = new System.Drawing.Size(156, 88);
            this.Main_Employee.TabIndex = 1;
            this.Main_Employee.Text = "עובד";
            this.Main_Employee.UseVisualStyleBackColor = false;
            this.Main_Employee.Click += new System.EventHandler(this.Main_Employee_Click);
            // 
            // pictureBox_curtain
            // 
            this.pictureBox_curtain.BackColor = System.Drawing.Color.White;
            this.pictureBox_curtain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_curtain.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_curtain.Image")));
            this.pictureBox_curtain.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_curtain.Name = "pictureBox_curtain";
            this.pictureBox_curtain.Size = new System.Drawing.Size(684, 606);
            this.pictureBox_curtain.TabIndex = 4;
            this.pictureBox_curtain.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(441, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "אנא בחר סוג משתמש";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Location = new System.Drawing.Point(413, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 603);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(684, 606);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Main_Employee);
            this.Controls.Add(this.Main_Customer);
            this.Controls.Add(this.pictureBox_curtain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_curtain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Main_Customer;
        private System.Windows.Forms.Button Main_Employee;
        private System.Windows.Forms.PictureBox pictureBox_curtain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}