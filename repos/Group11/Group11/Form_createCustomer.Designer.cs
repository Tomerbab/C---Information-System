namespace Group11
{
    partial class Form_createCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_createCustomer));
            this.textBox_CC_password = new System.Windows.Forms.TextBox();
            this.textBox_CC_address = new System.Windows.Forms.TextBox();
            this.textBox_CC_phoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_CC_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CC_name = new System.Windows.Forms.TextBox();
            this.button_CC_create = new System.Windows.Forms.Button();
            this.CC_back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_CC_password
            // 
            this.textBox_CC_password.Location = new System.Drawing.Point(106, 281);
            this.textBox_CC_password.Name = "textBox_CC_password";
            this.textBox_CC_password.Size = new System.Drawing.Size(202, 20);
            this.textBox_CC_password.TabIndex = 15;
            // 
            // textBox_CC_address
            // 
            this.textBox_CC_address.Location = new System.Drawing.Point(106, 244);
            this.textBox_CC_address.Name = "textBox_CC_address";
            this.textBox_CC_address.Size = new System.Drawing.Size(202, 20);
            this.textBox_CC_address.TabIndex = 16;
            // 
            // textBox_CC_phoneNumber
            // 
            this.textBox_CC_phoneNumber.Location = new System.Drawing.Point(106, 205);
            this.textBox_CC_phoneNumber.Name = "textBox_CC_phoneNumber";
            this.textBox_CC_phoneNumber.Size = new System.Drawing.Size(202, 20);
            this.textBox_CC_phoneNumber.TabIndex = 17;
            // 
            // textBox_CC_email
            // 
            this.textBox_CC_email.Location = new System.Drawing.Point(106, 169);
            this.textBox_CC_email.Name = "textBox_CC_email";
            this.textBox_CC_email.Size = new System.Drawing.Size(202, 20);
            this.textBox_CC_email.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(413, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = ":סיסמה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(421, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = ":כתובת";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(377, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = ":מספר טלפון";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(440, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = ":מייל";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(444, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = ":שם";
            // 
            // textBox_CC_name
            // 
            this.textBox_CC_name.Location = new System.Drawing.Point(106, 131);
            this.textBox_CC_name.Name = "textBox_CC_name";
            this.textBox_CC_name.Size = new System.Drawing.Size(202, 20);
            this.textBox_CC_name.TabIndex = 18;
            this.textBox_CC_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_CC_create
            // 
            this.button_CC_create.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_CC_create.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_CC_create.ForeColor = System.Drawing.Color.White;
            this.button_CC_create.Location = new System.Drawing.Point(12, 311);
            this.button_CC_create.Name = "button_CC_create";
            this.button_CC_create.Size = new System.Drawing.Size(90, 38);
            this.button_CC_create.TabIndex = 19;
            this.button_CC_create.Text = "צור לקוח";
            this.button_CC_create.UseVisualStyleBackColor = false;
            this.button_CC_create.Click += new System.EventHandler(this.button_CC_create_Click);
            // 
            // CC_back
            // 
            this.CC_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CC_back.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CC_back.ForeColor = System.Drawing.Color.White;
            this.CC_back.Location = new System.Drawing.Point(492, 311);
            this.CC_back.Name = "CC_back";
            this.CC_back.Size = new System.Drawing.Size(80, 38);
            this.CC_back.TabIndex = 20;
            this.CC_back.Text = "חזרה";
            this.CC_back.UseVisualStyleBackColor = false;
            this.CC_back.Click += new System.EventHandler(this.CC_back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(563, 14);
            this.pictureBox2.TabIndex = 128;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form_createCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CC_back);
            this.Controls.Add(this.button_CC_create);
            this.Controls.Add(this.textBox_CC_password);
            this.Controls.Add(this.textBox_CC_address);
            this.Controls.Add(this.textBox_CC_phoneNumber);
            this.Controls.Add(this.textBox_CC_name);
            this.Controls.Add(this.textBox_CC_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_createCustomer";
            this.Text = "Form_createCustomer";
            this.Load += new System.EventHandler(this.Form_createCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_CC_password;
        private System.Windows.Forms.TextBox textBox_CC_address;
        private System.Windows.Forms.TextBox textBox_CC_phoneNumber;
        private System.Windows.Forms.TextBox textBox_CC_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_CC_name;
        private System.Windows.Forms.Button button_CC_create;
        private System.Windows.Forms.Button CC_back;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}