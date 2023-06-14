namespace Group11
{
    partial class CrudCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudCustomer));
            this.readCustomer = new System.Windows.Forms.Button();
            this.createCustomer = new System.Windows.Forms.Button();
            this.button_CrudCustomer_back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // readCustomer
            // 
            this.readCustomer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.readCustomer.Cursor = System.Windows.Forms.Cursors.Cross;
            this.readCustomer.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readCustomer.ForeColor = System.Drawing.Color.White;
            this.readCustomer.Location = new System.Drawing.Point(180, 115);
            this.readCustomer.Name = "readCustomer";
            this.readCustomer.Size = new System.Drawing.Size(201, 56);
            this.readCustomer.TabIndex = 0;
            this.readCustomer.Text = "צפייה בפרטי לקוח";
            this.readCustomer.UseVisualStyleBackColor = false;
            this.readCustomer.Click += new System.EventHandler(this.readC_Click);
            // 
            // createCustomer
            // 
            this.createCustomer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.createCustomer.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.createCustomer.ForeColor = System.Drawing.Color.White;
            this.createCustomer.Location = new System.Drawing.Point(180, 177);
            this.createCustomer.Name = "createCustomer";
            this.createCustomer.Size = new System.Drawing.Size(201, 56);
            this.createCustomer.TabIndex = 2;
            this.createCustomer.Text = "יצירת לקוח חדש";
            this.createCustomer.UseVisualStyleBackColor = false;
            this.createCustomer.Click += new System.EventHandler(this.createCustomer_Click);
            // 
            // button_CrudCustomer_back
            // 
            this.button_CrudCustomer_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_CrudCustomer_back.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_CrudCustomer_back.ForeColor = System.Drawing.Color.White;
            this.button_CrudCustomer_back.Location = new System.Drawing.Point(498, 318);
            this.button_CrudCustomer_back.Name = "button_CrudCustomer_back";
            this.button_CrudCustomer_back.Size = new System.Drawing.Size(74, 31);
            this.button_CrudCustomer_back.TabIndex = 3;
            this.button_CrudCustomer_back.Text = "חזרה";
            this.button_CrudCustomer_back.UseVisualStyleBackColor = false;
            this.button_CrudCustomer_back.Click += new System.EventHandler(this.button_CrudCustomer_back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 285);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // CrudCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_CrudCustomer_back);
            this.Controls.Add(this.createCustomer);
            this.Controls.Add(this.readCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrudCustomer";
            this.Text = "CrudCustomer";
            this.Load += new System.EventHandler(this.CrudCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readCustomer;
        private System.Windows.Forms.Button createCustomer;
        private System.Windows.Forms.Button button_CrudCustomer_back;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}