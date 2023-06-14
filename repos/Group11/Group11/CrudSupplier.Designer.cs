namespace Group11
{
    partial class CrudSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudSupplier));
            this.createSupplier = new System.Windows.Forms.Button();
            this.readSupplier = new System.Windows.Forms.Button();
            this.button_CrudSupplier_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // createSupplier
            // 
            this.createSupplier.BackColor = System.Drawing.Color.DarkSlateGray;
            this.createSupplier.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.createSupplier.ForeColor = System.Drawing.Color.White;
            this.createSupplier.Location = new System.Drawing.Point(182, 183);
            this.createSupplier.Name = "createSupplier";
            this.createSupplier.Size = new System.Drawing.Size(204, 58);
            this.createSupplier.TabIndex = 4;
            this.createSupplier.Text = "יצירת ספק חדש";
            this.createSupplier.UseVisualStyleBackColor = false;
            this.createSupplier.Click += new System.EventHandler(this.createSupplier_Click);
            // 
            // readSupplier
            // 
            this.readSupplier.BackColor = System.Drawing.Color.DarkSlateGray;
            this.readSupplier.Cursor = System.Windows.Forms.Cursors.Cross;
            this.readSupplier.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readSupplier.ForeColor = System.Drawing.Color.White;
            this.readSupplier.Location = new System.Drawing.Point(182, 119);
            this.readSupplier.Name = "readSupplier";
            this.readSupplier.Size = new System.Drawing.Size(204, 58);
            this.readSupplier.TabIndex = 3;
            this.readSupplier.Text = "צפייה בפרטי ספק";
            this.readSupplier.UseVisualStyleBackColor = false;
            this.readSupplier.Click += new System.EventHandler(this.readSupplier_Click);
            // 
            // button_CrudSupplier_back
            // 
            this.button_CrudSupplier_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_CrudSupplier_back.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_CrudSupplier_back.ForeColor = System.Drawing.Color.White;
            this.button_CrudSupplier_back.Location = new System.Drawing.Point(494, 321);
            this.button_CrudSupplier_back.Name = "button_CrudSupplier_back";
            this.button_CrudSupplier_back.Size = new System.Drawing.Size(78, 33);
            this.button_CrudSupplier_back.TabIndex = 5;
            this.button_CrudSupplier_back.Text = "חזרה";
            this.button_CrudSupplier_back.UseVisualStyleBackColor = false;
            this.button_CrudSupplier_back.Click += new System.EventHandler(this.button_CrudSupplier_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 285);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // CrudSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_CrudSupplier_back);
            this.Controls.Add(this.createSupplier);
            this.Controls.Add(this.readSupplier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrudSupplier";
            this.Text = "v";
            this.Load += new System.EventHandler(this.CrudSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createSupplier;
        private System.Windows.Forms.Button readSupplier;
        private System.Windows.Forms.Button button_CrudSupplier_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}