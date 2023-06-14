namespace Group11
{
    partial class Form_customerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_customerLogin));
            this.label_CustomerEnter = new System.Windows.Forms.Label();
            this.label_CustomerID = new System.Windows.Forms.Label();
            this.label_CustomerPassword = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.Button_Enter = new System.Windows.Forms.Button();
            this.CS_back = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CustomerEnter
            // 
            this.label_CustomerEnter.AutoSize = true;
            this.label_CustomerEnter.Font = new System.Drawing.Font("Adobe Heiti Std R", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_CustomerEnter.ForeColor = System.Drawing.Color.Black;
            this.label_CustomerEnter.Location = new System.Drawing.Point(218, 43);
            this.label_CustomerEnter.Name = "label_CustomerEnter";
            this.label_CustomerEnter.Size = new System.Drawing.Size(143, 34);
            this.label_CustomerEnter.TabIndex = 0;
            this.label_CustomerEnter.Text = "כניסת לקוח";
            this.label_CustomerEnter.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_CustomerID
            // 
            this.label_CustomerID.AutoSize = true;
            this.label_CustomerID.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_CustomerID.ForeColor = System.Drawing.Color.Black;
            this.label_CustomerID.Location = new System.Drawing.Point(318, 140);
            this.label_CustomerID.Name = "label_CustomerID";
            this.label_CustomerID.Size = new System.Drawing.Size(108, 26);
            this.label_CustomerID.TabIndex = 1;
            this.label_CustomerID.Text = ":מספר לקוח";
            // 
            // label_CustomerPassword
            // 
            this.label_CustomerPassword.AutoSize = true;
            this.label_CustomerPassword.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_CustomerPassword.ForeColor = System.Drawing.Color.Black;
            this.label_CustomerPassword.Location = new System.Drawing.Point(355, 177);
            this.label_CustomerPassword.Name = "label_CustomerPassword";
            this.label_CustomerPassword.Size = new System.Drawing.Size(71, 26);
            this.label_CustomerPassword.TabIndex = 2;
            this.label_CustomerPassword.Text = ":סיסמה";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(164, 146);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(136, 20);
            this.textBox_UserName.TabIndex = 3;
            this.textBox_UserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(165, 184);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(135, 20);
            this.textBox_Password.TabIndex = 4;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // Button_Enter
            // 
            this.Button_Enter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Button_Enter.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_Enter.ForeColor = System.Drawing.Color.White;
            this.Button_Enter.Location = new System.Drawing.Point(7, 311);
            this.Button_Enter.Name = "Button_Enter";
            this.Button_Enter.Size = new System.Drawing.Size(69, 31);
            this.Button_Enter.TabIndex = 5;
            this.Button_Enter.Text = "כניסה";
            this.Button_Enter.UseVisualStyleBackColor = false;
            this.Button_Enter.Click += new System.EventHandler(this.Button_Enter_Click);
            // 
            // CS_back
            // 
            this.CS_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CS_back.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CS_back.ForeColor = System.Drawing.Color.White;
            this.CS_back.Location = new System.Drawing.Point(493, 311);
            this.CS_back.Name = "CS_back";
            this.CS_back.Size = new System.Drawing.Size(71, 31);
            this.CS_back.TabIndex = 22;
            this.CS_back.Text = "חזרה";
            this.CS_back.UseVisualStyleBackColor = false;
            this.CS_back.Click += new System.EventHandler(this.CS_back_Click);
            // 
            // button_close
            // 
            this.button_close.Image = ((System.Drawing.Image)(resources.GetObject("button_close.Image")));
            this.button_close.Location = new System.Drawing.Point(129, 182);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(30, 23);
            this.button_close.TabIndex = 24;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_open
            // 
            this.button_open.Image = ((System.Drawing.Image)(resources.GetObject("button_open.Image")));
            this.button_open.Location = new System.Drawing.Point(130, 184);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(29, 23);
            this.button_open.TabIndex = 25;
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(7, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(563, 14);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Form_customerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(576, 354);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.CS_back);
            this.Controls.Add(this.Button_Enter);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_CustomerPassword);
            this.Controls.Add(this.label_CustomerID);
            this.Controls.Add(this.label_CustomerEnter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_customerLogin";
            this.Text = "Form_customerLogin";
            this.Load += new System.EventHandler(this.Form_customerLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_CustomerEnter;
        private System.Windows.Forms.Label label_CustomerID;
        private System.Windows.Forms.Label label_CustomerPassword;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button Button_Enter;
        private System.Windows.Forms.Button CS_back;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}