namespace Group11
{
    partial class Form_addPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_addPayment));
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_cvv = new System.Windows.Forms.TextBox();
            this.label_cvv = new System.Windows.Forms.Label();
            this.button_addPayment = new System.Windows.Forms.Button();
            this.label_exp = new System.Windows.Forms.Label();
            this.textBox_cardNum = new System.Windows.Forms.TextBox();
            this.label_cardNum = new System.Windows.Forms.Label();
            this.label_paymentAmount = new System.Windows.Forms.Label();
            this.label_addPayment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ownerName = new System.Windows.Forms.TextBox();
            this.dateTimePicker_expDate = new System.Windows.Forms.DateTimePicker();
            this.PaymentLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_cancel.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_cancel.ForeColor = System.Drawing.SystemColors.Control;
            this.button_cancel.Location = new System.Drawing.Point(468, 410);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(107, 39);
            this.button_cancel.TabIndex = 116;
            this.button_cancel.Text = "ביטול";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox_cvv
            // 
            this.textBox_cvv.BackColor = System.Drawing.Color.White;
            this.textBox_cvv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_cvv.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_cvv.Location = new System.Drawing.Point(74, 286);
            this.textBox_cvv.Name = "textBox_cvv";
            this.textBox_cvv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_cvv.Size = new System.Drawing.Size(222, 27);
            this.textBox_cvv.TabIndex = 113;
            // 
            // label_cvv
            // 
            this.label_cvv.AutoSize = true;
            this.label_cvv.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_cvv.ForeColor = System.Drawing.Color.Black;
            this.label_cvv.Location = new System.Drawing.Point(439, 286);
            this.label_cvv.Name = "label_cvv";
            this.label_cvv.Size = new System.Drawing.Size(51, 24);
            this.label_cvv.TabIndex = 112;
            this.label_cvv.Text = ":CVV";
            // 
            // button_addPayment
            // 
            this.button_addPayment.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_addPayment.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addPayment.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button_addPayment.Location = new System.Drawing.Point(12, 408);
            this.button_addPayment.Name = "button_addPayment";
            this.button_addPayment.Size = new System.Drawing.Size(107, 41);
            this.button_addPayment.TabIndex = 111;
            this.button_addPayment.Text = "בצע תשלום";
            this.button_addPayment.UseVisualStyleBackColor = false;
            this.button_addPayment.Click += new System.EventHandler(this.button_addPayment_Click);
            // 
            // label_exp
            // 
            this.label_exp.AutoSize = true;
            this.label_exp.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_exp.ForeColor = System.Drawing.Color.Black;
            this.label_exp.Location = new System.Drawing.Point(385, 233);
            this.label_exp.Name = "label_exp";
            this.label_exp.Size = new System.Drawing.Size(113, 26);
            this.label_exp.TabIndex = 107;
            this.label_exp.Text = ":תוקף כרטיס";
            // 
            // textBox_cardNum
            // 
            this.textBox_cardNum.BackColor = System.Drawing.Color.White;
            this.textBox_cardNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_cardNum.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_cardNum.Location = new System.Drawing.Point(74, 187);
            this.textBox_cardNum.Name = "textBox_cardNum";
            this.textBox_cardNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_cardNum.Size = new System.Drawing.Size(220, 27);
            this.textBox_cardNum.TabIndex = 106;
            // 
            // label_cardNum
            // 
            this.label_cardNum.AutoSize = true;
            this.label_cardNum.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_cardNum.ForeColor = System.Drawing.Color.Black;
            this.label_cardNum.Location = new System.Drawing.Point(368, 185);
            this.label_cardNum.Name = "label_cardNum";
            this.label_cardNum.Size = new System.Drawing.Size(130, 26);
            this.label_cardNum.TabIndex = 105;
            this.label_cardNum.Text = ":מספר הכרטיס";
            // 
            // label_paymentAmount
            // 
            this.label_paymentAmount.AutoSize = true;
            this.label_paymentAmount.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_paymentAmount.ForeColor = System.Drawing.Color.Black;
            this.label_paymentAmount.Location = new System.Drawing.Point(372, 334);
            this.label_paymentAmount.Name = "label_paymentAmount";
            this.label_paymentAmount.Size = new System.Drawing.Size(126, 26);
            this.label_paymentAmount.TabIndex = 103;
            this.label_paymentAmount.Text = ":סכום לתשלום";
            // 
            // label_addPayment
            // 
            this.label_addPayment.AutoSize = true;
            this.label_addPayment.Font = new System.Drawing.Font("Adobe Heiti Std R", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addPayment.ForeColor = System.Drawing.Color.Black;
            this.label_addPayment.Location = new System.Drawing.Point(215, 51);
            this.label_addPayment.Name = "label_addPayment";
            this.label_addPayment.Size = new System.Drawing.Size(156, 34);
            this.label_addPayment.TabIndex = 101;
            this.label_addPayment.Text = "ביצוע תשלום";
            this.label_addPayment.Click += new System.EventHandler(this.label_addPayment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(354, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 117;
            this.label1.Text = ":שם בעל הכרטיס";
            // 
            // textBox_ownerName
            // 
            this.textBox_ownerName.BackColor = System.Drawing.Color.White;
            this.textBox_ownerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_ownerName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_ownerName.Location = new System.Drawing.Point(74, 143);
            this.textBox_ownerName.Name = "textBox_ownerName";
            this.textBox_ownerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_ownerName.Size = new System.Drawing.Size(220, 27);
            this.textBox_ownerName.TabIndex = 118;
            this.textBox_ownerName.TextChanged += new System.EventHandler(this.textBox_ownerName_TextChanged);
            // 
            // dateTimePicker_expDate
            // 
            this.dateTimePicker_expDate.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker_expDate.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker_expDate.Location = new System.Drawing.Point(74, 233);
            this.dateTimePicker_expDate.Name = "dateTimePicker_expDate";
            this.dateTimePicker_expDate.Size = new System.Drawing.Size(222, 33);
            this.dateTimePicker_expDate.TabIndex = 119;
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.AutoSize = true;
            this.PaymentLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PaymentLabel.Location = new System.Drawing.Point(267, 339);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(0, 19);
            this.PaymentLabel.TabIndex = 120;
            this.PaymentLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(563, 14);
            this.pictureBox2.TabIndex = 122;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // Form_addPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PaymentLabel);
            this.Controls.Add(this.dateTimePicker_expDate);
            this.Controls.Add(this.textBox_ownerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox_cvv);
            this.Controls.Add(this.label_cvv);
            this.Controls.Add(this.button_addPayment);
            this.Controls.Add(this.label_exp);
            this.Controls.Add(this.textBox_cardNum);
            this.Controls.Add(this.label_cardNum);
            this.Controls.Add(this.label_paymentAmount);
            this.Controls.Add(this.label_addPayment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_addPayment";
            this.Text = "Form_addPayment";
            this.Load += new System.EventHandler(this.Form_addPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBox_cvv;
        private System.Windows.Forms.Label label_cvv;
        private System.Windows.Forms.Button button_addPayment;
        private System.Windows.Forms.Label label_exp;
        private System.Windows.Forms.TextBox textBox_cardNum;
        private System.Windows.Forms.Label label_cardNum;
        private System.Windows.Forms.Label label_paymentAmount;
        private System.Windows.Forms.Label label_addPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ownerName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_expDate;
        private System.Windows.Forms.Label PaymentLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}