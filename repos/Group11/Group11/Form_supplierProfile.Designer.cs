namespace Group11
{
    partial class Form_supplierProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_supplierProfile));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SP_ID = new System.Windows.Forms.Label();
            this.SP_name = new System.Windows.Forms.Label();
            this.SP_address = new System.Windows.Forms.Label();
            this.SP_phoneNumber = new System.Windows.Forms.Label();
            this.SP_email = new System.Windows.Forms.Label();
            this.button_CP_supplierUpdate = new System.Windows.Forms.Button();
            this.button_SP_back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(411, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = ":שם";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(351, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = ":מספר ספק";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(386, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = ":כתובת";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(342, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = ":מספר טלפון";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(405, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = ":מייל";
            // 
            // SP_ID
            // 
            this.SP_ID.AutoSize = true;
            this.SP_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SP_ID.Location = new System.Drawing.Point(165, 131);
            this.SP_ID.Name = "SP_ID";
            this.SP_ID.Size = new System.Drawing.Size(32, 20);
            this.SP_ID.TabIndex = 5;
            this.SP_ID.Text = "ריק";
            this.SP_ID.Click += new System.EventHandler(this.SP_id_Click);
            // 
            // SP_name
            // 
            this.SP_name.AutoSize = true;
            this.SP_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SP_name.Location = new System.Drawing.Point(165, 161);
            this.SP_name.Name = "SP_name";
            this.SP_name.Size = new System.Drawing.Size(32, 20);
            this.SP_name.TabIndex = 6;
            this.SP_name.Text = "ריק";
            // 
            // SP_address
            // 
            this.SP_address.AutoSize = true;
            this.SP_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SP_address.Location = new System.Drawing.Point(166, 192);
            this.SP_address.Name = "SP_address";
            this.SP_address.Size = new System.Drawing.Size(32, 20);
            this.SP_address.TabIndex = 7;
            this.SP_address.Text = "ריק";
            // 
            // SP_phoneNumber
            // 
            this.SP_phoneNumber.AutoSize = true;
            this.SP_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SP_phoneNumber.Location = new System.Drawing.Point(165, 228);
            this.SP_phoneNumber.Name = "SP_phoneNumber";
            this.SP_phoneNumber.Size = new System.Drawing.Size(32, 20);
            this.SP_phoneNumber.TabIndex = 8;
            this.SP_phoneNumber.Text = "ריק";
            // 
            // SP_email
            // 
            this.SP_email.AutoSize = true;
            this.SP_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SP_email.Location = new System.Drawing.Point(167, 261);
            this.SP_email.Name = "SP_email";
            this.SP_email.Size = new System.Drawing.Size(32, 20);
            this.SP_email.TabIndex = 9;
            this.SP_email.Text = "ריק";
            // 
            // button_CP_supplierUpdate
            // 
            this.button_CP_supplierUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_CP_supplierUpdate.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_CP_supplierUpdate.ForeColor = System.Drawing.Color.White;
            this.button_CP_supplierUpdate.Location = new System.Drawing.Point(7, 303);
            this.button_CP_supplierUpdate.Name = "button_CP_supplierUpdate";
            this.button_CP_supplierUpdate.Size = new System.Drawing.Size(142, 46);
            this.button_CP_supplierUpdate.TabIndex = 10;
            this.button_CP_supplierUpdate.Text = "עדכון פרטי ספק";
            this.button_CP_supplierUpdate.UseVisualStyleBackColor = false;
            this.button_CP_supplierUpdate.Click += new System.EventHandler(this.button_CP_supplierUpdate_Click);
            // 
            // button_SP_back
            // 
            this.button_SP_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_SP_back.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_SP_back.ForeColor = System.Drawing.Color.White;
            this.button_SP_back.Location = new System.Drawing.Point(500, 303);
            this.button_SP_back.Name = "button_SP_back";
            this.button_SP_back.Size = new System.Drawing.Size(75, 46);
            this.button_SP_back.TabIndex = 11;
            this.button_SP_back.Text = "חזרה";
            this.button_SP_back.UseVisualStyleBackColor = false;
            this.button_SP_back.Click += new System.EventHandler(this.button_SP_back_Click);
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
            // Form_supplierProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_SP_back);
            this.Controls.Add(this.button_CP_supplierUpdate);
            this.Controls.Add(this.SP_email);
            this.Controls.Add(this.SP_phoneNumber);
            this.Controls.Add(this.SP_address);
            this.Controls.Add(this.SP_name);
            this.Controls.Add(this.SP_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_supplierProfile";
            this.Text = "Form_supplierProfile";
            this.Load += new System.EventHandler(this.Form_supplierProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SP_ID;
        private System.Windows.Forms.Label SP_name;
        private System.Windows.Forms.Label SP_address;
        private System.Windows.Forms.Label SP_phoneNumber;
        private System.Windows.Forms.Label SP_email;
        private System.Windows.Forms.Button button_CP_supplierUpdate;
        private System.Windows.Forms.Button button_SP_back;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}