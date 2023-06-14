namespace Group11
{
    partial class CrudProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudProduct));
            this.readProduct = new System.Windows.Forms.Button();
            this.createProduct = new System.Windows.Forms.Button();
            this.button_CrudProduct_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // readProduct
            // 
            this.readProduct.BackColor = System.Drawing.Color.DarkSlateGray;
            this.readProduct.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.readProduct.ForeColor = System.Drawing.Color.White;
            this.readProduct.Location = new System.Drawing.Point(198, 121);
            this.readProduct.Name = "readProduct";
            this.readProduct.Size = new System.Drawing.Size(201, 62);
            this.readProduct.TabIndex = 0;
            this.readProduct.Text = "צפייה בפרטי מוצר";
            this.readProduct.UseVisualStyleBackColor = false;
            this.readProduct.Click += new System.EventHandler(this.readProduct_Click);
            // 
            // createProduct
            // 
            this.createProduct.BackColor = System.Drawing.Color.DarkSlateGray;
            this.createProduct.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.createProduct.ForeColor = System.Drawing.Color.White;
            this.createProduct.Location = new System.Drawing.Point(198, 189);
            this.createProduct.Name = "createProduct";
            this.createProduct.Size = new System.Drawing.Size(201, 62);
            this.createProduct.TabIndex = 1;
            this.createProduct.Text = "יצירת מוצר חדש";
            this.createProduct.UseVisualStyleBackColor = false;
            this.createProduct.Click += new System.EventHandler(this.createProduct_Click);
            // 
            // button_CrudProduct_back
            // 
            this.button_CrudProduct_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_CrudProduct_back.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_CrudProduct_back.ForeColor = System.Drawing.Color.White;
            this.button_CrudProduct_back.Location = new System.Drawing.Point(491, 322);
            this.button_CrudProduct_back.Name = "button_CrudProduct_back";
            this.button_CrudProduct_back.Size = new System.Drawing.Size(81, 32);
            this.button_CrudProduct_back.TabIndex = 2;
            this.button_CrudProduct_back.Text = "חזרה";
            this.button_CrudProduct_back.UseVisualStyleBackColor = false;
            this.button_CrudProduct_back.Click += new System.EventHandler(this.button_CrudProduct_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 285);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // CrudProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_CrudProduct_back);
            this.Controls.Add(this.createProduct);
            this.Controls.Add(this.readProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrudProduct";
            this.Text = "CrudProduct";
            this.Load += new System.EventHandler(this.CrudProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readProduct;
        private System.Windows.Forms.Button createProduct;
        private System.Windows.Forms.Button button_CrudProduct_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}