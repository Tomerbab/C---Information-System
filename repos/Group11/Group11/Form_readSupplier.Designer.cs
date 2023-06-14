namespace Group11
{
    partial class Form_readSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_readSupplier));
            this.textBox_supplierIdSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SupplierSearch = new System.Windows.Forms.Button();
            this.button_backFromReadSupplier = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_supplierIdSearch
            // 
            this.textBox_supplierIdSearch.Location = new System.Drawing.Point(152, 170);
            this.textBox_supplierIdSearch.Name = "textBox_supplierIdSearch";
            this.textBox_supplierIdSearch.Size = new System.Drawing.Size(100, 20);
            this.textBox_supplierIdSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(258, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = ":הזן מספר ספק לחיפוש";
            // 
            // button_SupplierSearch
            // 
            this.button_SupplierSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_SupplierSearch.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_SupplierSearch.ForeColor = System.Drawing.Color.White;
            this.button_SupplierSearch.Location = new System.Drawing.Point(12, 314);
            this.button_SupplierSearch.Name = "button_SupplierSearch";
            this.button_SupplierSearch.Size = new System.Drawing.Size(75, 35);
            this.button_SupplierSearch.TabIndex = 2;
            this.button_SupplierSearch.Text = "חפש";
            this.button_SupplierSearch.UseVisualStyleBackColor = false;
            this.button_SupplierSearch.Click += new System.EventHandler(this.button_SupplierSearch_Click);
            // 
            // button_backFromReadSupplier
            // 
            this.button_backFromReadSupplier.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_backFromReadSupplier.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_backFromReadSupplier.ForeColor = System.Drawing.Color.White;
            this.button_backFromReadSupplier.Location = new System.Drawing.Point(497, 314);
            this.button_backFromReadSupplier.Name = "button_backFromReadSupplier";
            this.button_backFromReadSupplier.Size = new System.Drawing.Size(75, 35);
            this.button_backFromReadSupplier.TabIndex = 3;
            this.button_backFromReadSupplier.Text = "חזרה";
            this.button_backFromReadSupplier.UseVisualStyleBackColor = false;
            this.button_backFromReadSupplier.Click += new System.EventHandler(this.button_backFromReadSupplier_Click);
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
            // Form_readSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_backFromReadSupplier);
            this.Controls.Add(this.button_SupplierSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_supplierIdSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_readSupplier";
            this.Text = "Form_readSupplier";
            this.Load += new System.EventHandler(this.Form_readSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_supplierIdSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SupplierSearch;
        private System.Windows.Forms.Button button_backFromReadSupplier;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}