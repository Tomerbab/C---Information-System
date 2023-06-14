namespace Group11
{
    partial class Form_TotalOrderPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TotalOrderPrice));
            this.label1 = new System.Windows.Forms.Label();
            this.button_EndCalculate = new System.Windows.Forms.Button();
            this.label_FinalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxIsVIP = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_discount = new System.Windows.Forms.ComboBox();
            this.label_discount = new System.Windows.Forms.Label();
            this.label_fabricsCost = new System.Windows.Forms.Label();
            this.label_fixedCost = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(178, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "סיכום מחיר הזמנה";
            // 
            // button_EndCalculate
            // 
            this.button_EndCalculate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_EndCalculate.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_EndCalculate.ForeColor = System.Drawing.Color.White;
            this.button_EndCalculate.Location = new System.Drawing.Point(3, 320);
            this.button_EndCalculate.Name = "button_EndCalculate";
            this.button_EndCalculate.Size = new System.Drawing.Size(71, 38);
            this.button_EndCalculate.TabIndex = 1;
            this.button_EndCalculate.Text = "סיום";
            this.button_EndCalculate.UseVisualStyleBackColor = false;
            this.button_EndCalculate.Click += new System.EventHandler(this.button_EndCalculate_Click);
            // 
            // label_FinalPrice
            // 
            this.label_FinalPrice.AutoSize = true;
            this.label_FinalPrice.Location = new System.Drawing.Point(180, 279);
            this.label_FinalPrice.Name = "label_FinalPrice";
            this.label_FinalPrice.Size = new System.Drawing.Size(43, 13);
            this.label_FinalPrice.TabIndex = 2;
            this.label_FinalPrice.Text = "______";
            this.label_FinalPrice.Click += new System.EventHandler(this.label_FinalPrice_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(315, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = ":מחיר סופי כולל מע\"מ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(371, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = ":עלויות קבועות";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(426, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(375, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = ":בדים ואביזרים";
            // 
            // checkBoxIsVIP
            // 
            this.checkBoxIsVIP.AutoSize = true;
            this.checkBoxIsVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxIsVIP.Location = new System.Drawing.Point(208, 196);
            this.checkBoxIsVIP.Name = "checkBoxIsVIP";
            this.checkBoxIsVIP.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIsVIP.TabIndex = 12;
            this.checkBoxIsVIP.UseVisualStyleBackColor = true;
            this.checkBoxIsVIP.CheckedChanged += new System.EventHandler(this.checkBoxIsVIP_CheckedChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(357, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "VIP האם הלקוח";
            // 
            // comboBox_discount
            // 
            this.comboBox_discount.FormattingEnabled = true;
            this.comboBox_discount.Items.AddRange(new object[] {
            "0",
            "10",
            "15",
            "20",
            "25"});
            this.comboBox_discount.Location = new System.Drawing.Point(102, 236);
            this.comboBox_discount.Name = "comboBox_discount";
            this.comboBox_discount.Size = new System.Drawing.Size(121, 21);
            this.comboBox_discount.TabIndex = 42;
            this.comboBox_discount.Visible = false;
            this.comboBox_discount.SelectedIndexChanged += new System.EventHandler(this.comboBox_discount_SelectedIndexChanged);
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_discount.Location = new System.Drawing.Point(365, 230);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(132, 26);
            this.label_discount.TabIndex = 43;
            this.label_discount.Text = "בחר אחוז הנחה";
            this.label_discount.Visible = false;
            // 
            // label_fabricsCost
            // 
            this.label_fabricsCost.AutoSize = true;
            this.label_fabricsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_fabricsCost.Location = new System.Drawing.Point(191, 111);
            this.label_fabricsCost.Name = "label_fabricsCost";
            this.label_fabricsCost.Size = new System.Drawing.Size(32, 20);
            this.label_fabricsCost.TabIndex = 44;
            this.label_fabricsCost.Text = "ריק";
            // 
            // label_fixedCost
            // 
            this.label_fixedCost.AutoSize = true;
            this.label_fixedCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_fixedCost.Location = new System.Drawing.Point(191, 146);
            this.label_fixedCost.Name = "label_fixedCost";
            this.label_fixedCost.Size = new System.Drawing.Size(32, 20);
            this.label_fixedCost.TabIndex = 45;
            this.label_fixedCost.Text = "ריק";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(563, 14);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // Form_TotalOrderPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_fixedCost);
            this.Controls.Add(this.label_fabricsCost);
            this.Controls.Add(this.label_discount);
            this.Controls.Add(this.comboBox_discount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxIsVIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_FinalPrice);
            this.Controls.Add(this.button_EndCalculate);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_TotalOrderPrice";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form_TotalOrderPrice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_EndCalculate;
        private System.Windows.Forms.Label label_FinalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxIsVIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_discount;
        private System.Windows.Forms.Label label_discount;
        private System.Windows.Forms.Label label_fabricsCost;
        private System.Windows.Forms.Label label_fixedCost;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}