namespace Group11
{
    partial class Form_PurchasesFromSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PurchasesFromSuppliers));
            this.button_PurchaseHistory = new System.Windows.Forms.Button();
            this.button_MakePurchase = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_PurchaseHistory
            // 
            this.button_PurchaseHistory.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_PurchaseHistory.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_PurchaseHistory.ForeColor = System.Drawing.Color.White;
            this.button_PurchaseHistory.Location = new System.Drawing.Point(181, 212);
            this.button_PurchaseHistory.Name = "button_PurchaseHistory";
            this.button_PurchaseHistory.Size = new System.Drawing.Size(202, 73);
            this.button_PurchaseHistory.TabIndex = 0;
            this.button_PurchaseHistory.Text = "היסטוריית רכישות";
            this.button_PurchaseHistory.UseVisualStyleBackColor = false;
            this.button_PurchaseHistory.Click += new System.EventHandler(this.button_PurchaseHistory_Click);
            // 
            // button_MakePurchase
            // 
            this.button_MakePurchase.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_MakePurchase.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_MakePurchase.ForeColor = System.Drawing.Color.White;
            this.button_MakePurchase.Location = new System.Drawing.Point(181, 133);
            this.button_MakePurchase.Name = "button_MakePurchase";
            this.button_MakePurchase.Size = new System.Drawing.Size(202, 73);
            this.button_MakePurchase.TabIndex = 1;
            this.button_MakePurchase.Text = "בצע רכישה";
            this.button_MakePurchase.UseVisualStyleBackColor = false;
            this.button_MakePurchase.Click += new System.EventHandler(this.button_MakePurchase_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_back.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(489, 316);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(83, 33);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "חזרה";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
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
            // Form_PurchasesFromSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_MakePurchase);
            this.Controls.Add(this.button_PurchaseHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_PurchasesFromSuppliers";
            this.Text = "Form_PurchasesFromSuppliers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_PurchaseHistory;
        private System.Windows.Forms.Button button_MakePurchase;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}