namespace Group11
{
    partial class Form_readEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_readEmployee));
            this.button_backFromReadEmployee = new System.Windows.Forms.Button();
            this.textBox_employeeIdSearch = new System.Windows.Forms.TextBox();
            this.textbox_customerID = new System.Windows.Forms.Label();
            this.button_EmployeeSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_backFromReadEmployee
            // 
            this.button_backFromReadEmployee.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_backFromReadEmployee.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_backFromReadEmployee.ForeColor = System.Drawing.Color.White;
            this.button_backFromReadEmployee.Location = new System.Drawing.Point(499, 316);
            this.button_backFromReadEmployee.Name = "button_backFromReadEmployee";
            this.button_backFromReadEmployee.Size = new System.Drawing.Size(73, 33);
            this.button_backFromReadEmployee.TabIndex = 7;
            this.button_backFromReadEmployee.Text = "חזרה";
            this.button_backFromReadEmployee.UseVisualStyleBackColor = false;
            this.button_backFromReadEmployee.Click += new System.EventHandler(this.button_backFromReadEmployee_Click);
            // 
            // textBox_employeeIdSearch
            // 
            this.textBox_employeeIdSearch.Location = new System.Drawing.Point(110, 156);
            this.textBox_employeeIdSearch.Name = "textBox_employeeIdSearch";
            this.textBox_employeeIdSearch.Size = new System.Drawing.Size(126, 20);
            this.textBox_employeeIdSearch.TabIndex = 6;
            // 
            // textbox_customerID
            // 
            this.textbox_customerID.AutoSize = true;
            this.textbox_customerID.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textbox_customerID.Location = new System.Drawing.Point(242, 154);
            this.textbox_customerID.Name = "textbox_customerID";
            this.textbox_customerID.Size = new System.Drawing.Size(195, 26);
            this.textbox_customerID.TabIndex = 5;
            this.textbox_customerID.Text = ":הזן מספר עובד לחיפוש";
            // 
            // button_EmployeeSearch
            // 
            this.button_EmployeeSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_EmployeeSearch.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_EmployeeSearch.ForeColor = System.Drawing.Color.White;
            this.button_EmployeeSearch.Location = new System.Drawing.Point(12, 308);
            this.button_EmployeeSearch.Name = "button_EmployeeSearch";
            this.button_EmployeeSearch.Size = new System.Drawing.Size(71, 41);
            this.button_EmployeeSearch.TabIndex = 4;
            this.button_EmployeeSearch.Text = "חפש";
            this.button_EmployeeSearch.UseVisualStyleBackColor = false;
            this.button_EmployeeSearch.Click += new System.EventHandler(this.button_EmployeeSearch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(563, 14);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Form_readEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_backFromReadEmployee);
            this.Controls.Add(this.textBox_employeeIdSearch);
            this.Controls.Add(this.textbox_customerID);
            this.Controls.Add(this.button_EmployeeSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_readEmployee";
            this.Text = "Form_readEmployee";
            this.Load += new System.EventHandler(this.Form_readEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_backFromReadEmployee;
        private System.Windows.Forms.TextBox textBox_employeeIdSearch;
        private System.Windows.Forms.Label textbox_customerID;
        private System.Windows.Forms.Button button_EmployeeSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}