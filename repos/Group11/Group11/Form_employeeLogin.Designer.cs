namespace Group11
{
    partial class Form_employeeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_employeeLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_employeeID = new System.Windows.Forms.TextBox();
            this.textBox_employeePassword = new System.Windows.Forms.TextBox();
            this.button_employeeEnter = new System.Windows.Forms.Button();
            this.BackTomain = new System.Windows.Forms.Button();
            this.button_closeEmployee = new System.Windows.Forms.Button();
            this.button_openEmployee = new System.Windows.Forms.Button();
            this.label_CustomerEnter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(374, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = ":מספר עובד";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(407, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = ":סיסמה";
            // 
            // textBox_employeeID
            // 
            this.textBox_employeeID.Location = new System.Drawing.Point(134, 176);
            this.textBox_employeeID.Name = "textBox_employeeID";
            this.textBox_employeeID.Size = new System.Drawing.Size(170, 20);
            this.textBox_employeeID.TabIndex = 2;
            // 
            // textBox_employeePassword
            // 
            this.textBox_employeePassword.Location = new System.Drawing.Point(134, 222);
            this.textBox_employeePassword.Name = "textBox_employeePassword";
            this.textBox_employeePassword.PasswordChar = '*';
            this.textBox_employeePassword.Size = new System.Drawing.Size(170, 20);
            this.textBox_employeePassword.TabIndex = 3;
            // 
            // button_employeeEnter
            // 
            this.button_employeeEnter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_employeeEnter.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_employeeEnter.ForeColor = System.Drawing.Color.White;
            this.button_employeeEnter.Location = new System.Drawing.Point(12, 364);
            this.button_employeeEnter.Name = "button_employeeEnter";
            this.button_employeeEnter.Size = new System.Drawing.Size(70, 32);
            this.button_employeeEnter.TabIndex = 4;
            this.button_employeeEnter.Text = "כניסה";
            this.button_employeeEnter.UseVisualStyleBackColor = false;
            this.button_employeeEnter.Click += new System.EventHandler(this.button_employeeEnter_Click);
            // 
            // BackTomain
            // 
            this.BackTomain.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackTomain.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BackTomain.ForeColor = System.Drawing.Color.Transparent;
            this.BackTomain.Location = new System.Drawing.Point(503, 364);
            this.BackTomain.Name = "BackTomain";
            this.BackTomain.Size = new System.Drawing.Size(72, 32);
            this.BackTomain.TabIndex = 5;
            this.BackTomain.Text = "חזרה ";
            this.BackTomain.UseVisualStyleBackColor = false;
            this.BackTomain.Click += new System.EventHandler(this.BackTomain_Click);
            // 
            // button_closeEmployee
            // 
            this.button_closeEmployee.Image = ((System.Drawing.Image)(resources.GetObject("button_closeEmployee.Image")));
            this.button_closeEmployee.Location = new System.Drawing.Point(98, 220);
            this.button_closeEmployee.Name = "button_closeEmployee";
            this.button_closeEmployee.Size = new System.Drawing.Size(30, 23);
            this.button_closeEmployee.TabIndex = 25;
            this.button_closeEmployee.UseVisualStyleBackColor = true;
            this.button_closeEmployee.Click += new System.EventHandler(this.button_closeEmployee_Click);
            // 
            // button_openEmployee
            // 
            this.button_openEmployee.Image = ((System.Drawing.Image)(resources.GetObject("button_openEmployee.Image")));
            this.button_openEmployee.Location = new System.Drawing.Point(99, 219);
            this.button_openEmployee.Name = "button_openEmployee";
            this.button_openEmployee.Size = new System.Drawing.Size(29, 23);
            this.button_openEmployee.TabIndex = 26;
            this.button_openEmployee.UseVisualStyleBackColor = true;
            this.button_openEmployee.Click += new System.EventHandler(this.button_openEmployee_Click);
            // 
            // label_CustomerEnter
            // 
            this.label_CustomerEnter.AutoSize = true;
            this.label_CustomerEnter.Font = new System.Drawing.Font("Adobe Heiti Std R", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_CustomerEnter.ForeColor = System.Drawing.Color.Black;
            this.label_CustomerEnter.Location = new System.Drawing.Point(224, 51);
            this.label_CustomerEnter.Name = "label_CustomerEnter";
            this.label_CustomerEnter.Size = new System.Drawing.Size(138, 34);
            this.label_CustomerEnter.TabIndex = 27;
            this.label_CustomerEnter.Text = "כניסת עובד";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(563, 14);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // Form_employeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(587, 408);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_CustomerEnter);
            this.Controls.Add(this.button_openEmployee);
            this.Controls.Add(this.button_closeEmployee);
            this.Controls.Add(this.BackTomain);
            this.Controls.Add(this.button_employeeEnter);
            this.Controls.Add(this.textBox_employeePassword);
            this.Controls.Add(this.textBox_employeeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_employeeLogin";
            this.Text = "Form_employeeLogin";
            this.Load += new System.EventHandler(this.Form_employeeLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_employeeID;
        private System.Windows.Forms.TextBox textBox_employeePassword;
        private System.Windows.Forms.Button button_employeeEnter;
        private System.Windows.Forms.Button BackTomain;
        private System.Windows.Forms.Button button_closeEmployee;
        private System.Windows.Forms.Button button_openEmployee;
        private System.Windows.Forms.Label label_CustomerEnter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}