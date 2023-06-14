namespace Group11
{
    partial class Form_newShiftConstraint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_newShiftConstraint));
            this.button_addShiftConstraint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_newSC_date = new System.Windows.Forms.Label();
            this.label_newSC_type = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_newSC_reason = new System.Windows.Forms.TextBox();
            this.buttonChooseShift = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_addShiftConstraint
            // 
            this.button_addShiftConstraint.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_addShiftConstraint.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_addShiftConstraint.ForeColor = System.Drawing.Color.White;
            this.button_addShiftConstraint.Location = new System.Drawing.Point(12, 298);
            this.button_addShiftConstraint.Name = "button_addShiftConstraint";
            this.button_addShiftConstraint.Size = new System.Drawing.Size(160, 59);
            this.button_addShiftConstraint.TabIndex = 0;
            this.button_addShiftConstraint.Text = "הוספת אילוץ עבודה";
            this.button_addShiftConstraint.UseVisualStyleBackColor = false;
            this.button_addShiftConstraint.Click += new System.EventHandler(this.button_addShiftConstraint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(192, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "יצירת אילוץ עבודה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(390, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = ":תאריך המשמרת";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(414, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = ":סוג המשמרת";
            // 
            // label_newSC_date
            // 
            this.label_newSC_date.AutoSize = true;
            this.label_newSC_date.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_newSC_date.Location = new System.Drawing.Point(61, 134);
            this.label_newSC_date.Name = "label_newSC_date";
            this.label_newSC_date.Size = new System.Drawing.Size(32, 24);
            this.label_newSC_date.TabIndex = 4;
            this.label_newSC_date.Text = "ריק";
            // 
            // label_newSC_type
            // 
            this.label_newSC_type.AutoSize = true;
            this.label_newSC_type.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_newSC_type.Location = new System.Drawing.Point(61, 181);
            this.label_newSC_type.Name = "label_newSC_type";
            this.label_newSC_type.Size = new System.Drawing.Size(32, 24);
            this.label_newSC_type.TabIndex = 5;
            this.label_newSC_type.Text = "ריק";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(479, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = ":סיבה";
            // 
            // textBox_newSC_reason
            // 
            this.textBox_newSC_reason.Location = new System.Drawing.Point(65, 222);
            this.textBox_newSC_reason.Name = "textBox_newSC_reason";
            this.textBox_newSC_reason.Size = new System.Drawing.Size(310, 20);
            this.textBox_newSC_reason.TabIndex = 7;
            this.textBox_newSC_reason.TextChanged += new System.EventHandler(this.textBox_newSC_reason_TextChanged);
            // 
            // buttonChooseShift
            // 
            this.buttonChooseShift.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonChooseShift.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonChooseShift.ForeColor = System.Drawing.Color.White;
            this.buttonChooseShift.Location = new System.Drawing.Point(395, 298);
            this.buttonChooseShift.Name = "buttonChooseShift";
            this.buttonChooseShift.Size = new System.Drawing.Size(177, 59);
            this.buttonChooseShift.TabIndex = 8;
            this.buttonChooseShift.Text = "חזרה לבחירת משמרות";
            this.buttonChooseShift.UseVisualStyleBackColor = false;
            this.buttonChooseShift.Click += new System.EventHandler(this.buttonChooseShift_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(563, 14);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Form_newShiftConstraint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonChooseShift);
            this.Controls.Add(this.textBox_newSC_reason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_newSC_type);
            this.Controls.Add(this.label_newSC_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_addShiftConstraint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_newShiftConstraint";
            this.Text = "Form_newShiftConstraint";
            this.Load += new System.EventHandler(this.Form_newShiftConstraint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addShiftConstraint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_newSC_date;
        private System.Windows.Forms.Label label_newSC_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_newSC_reason;
        private System.Windows.Forms.Button buttonChooseShift;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}