namespace Group11
{
    partial class Form_readProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_readProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_productSerialNumberSearch = new System.Windows.Forms.TextBox();
            this.button_backFromReadProduct = new System.Windows.Forms.Button();
            this.button_ProductSearch = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(270, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = ":הזן מספר סידורי";
            // 
            // textBox_productSerialNumberSearch
            // 
            this.textBox_productSerialNumberSearch.Location = new System.Drawing.Point(164, 173);
            this.textBox_productSerialNumberSearch.Name = "textBox_productSerialNumberSearch";
            this.textBox_productSerialNumberSearch.Size = new System.Drawing.Size(100, 20);
            this.textBox_productSerialNumberSearch.TabIndex = 1;
            // 
            // button_backFromReadProduct
            // 
            this.button_backFromReadProduct.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_backFromReadProduct.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_backFromReadProduct.ForeColor = System.Drawing.Color.White;
            this.button_backFromReadProduct.Location = new System.Drawing.Point(497, 316);
            this.button_backFromReadProduct.Name = "button_backFromReadProduct";
            this.button_backFromReadProduct.Size = new System.Drawing.Size(75, 33);
            this.button_backFromReadProduct.TabIndex = 9;
            this.button_backFromReadProduct.Text = "חזרה";
            this.button_backFromReadProduct.UseVisualStyleBackColor = false;
            this.button_backFromReadProduct.Click += new System.EventHandler(this.button_backFromReadProduct_Click);
            // 
            // button_ProductSearch
            // 
            this.button_ProductSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_ProductSearch.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_ProductSearch.ForeColor = System.Drawing.Color.White;
            this.button_ProductSearch.Location = new System.Drawing.Point(12, 316);
            this.button_ProductSearch.Name = "button_ProductSearch";
            this.button_ProductSearch.Size = new System.Drawing.Size(75, 33);
            this.button_ProductSearch.TabIndex = 8;
            this.button_ProductSearch.Text = "חפש";
            this.button_ProductSearch.UseVisualStyleBackColor = false;
            this.button_ProductSearch.Click += new System.EventHandler(this.button_ProductSearch_Click);
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
            // Form_readProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_backFromReadProduct);
            this.Controls.Add(this.button_ProductSearch);
            this.Controls.Add(this.textBox_productSerialNumberSearch);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_readProduct";
            this.Text = "Form_readProduct";
            this.Load += new System.EventHandler(this.Form_readProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_productSerialNumberSearch;
        private System.Windows.Forms.Button button_backFromReadProduct;
        private System.Windows.Forms.Button button_ProductSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}