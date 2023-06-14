namespace Group11
{
    partial class CrudEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudEmployee));
            this.createEmployee = new System.Windows.Forms.Button();
            this.readEmployee = new System.Windows.Forms.Button();
            this.button_CrudEmployee_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // createEmployee
            // 
            this.createEmployee.BackColor = System.Drawing.Color.DarkSlateGray;
            this.createEmployee.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.createEmployee.ForeColor = System.Drawing.Color.White;
            this.createEmployee.Location = new System.Drawing.Point(196, 184);
            this.createEmployee.Name = "createEmployee";
            this.createEmployee.Size = new System.Drawing.Size(203, 54);
            this.createEmployee.TabIndex = 4;
            this.createEmployee.Text = "יצירת עובד חדש";
            this.createEmployee.UseVisualStyleBackColor = false;
            this.createEmployee.Click += new System.EventHandler(this.createEmployee_Click);
            // 
            // readEmployee
            // 
            this.readEmployee.BackColor = System.Drawing.Color.DarkSlateGray;
            this.readEmployee.Cursor = System.Windows.Forms.Cursors.Cross;
            this.readEmployee.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.readEmployee.ForeColor = System.Drawing.Color.White;
            this.readEmployee.Location = new System.Drawing.Point(196, 124);
            this.readEmployee.Name = "readEmployee";
            this.readEmployee.Size = new System.Drawing.Size(203, 54);
            this.readEmployee.TabIndex = 3;
            this.readEmployee.Text = "צפייה בפרטי עובד";
            this.readEmployee.UseVisualStyleBackColor = false;
            this.readEmployee.Click += new System.EventHandler(this.readEmployee_Click);
            // 
            // button_CrudEmployee_back
            // 
            this.button_CrudEmployee_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_CrudEmployee_back.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_CrudEmployee_back.ForeColor = System.Drawing.Color.White;
            this.button_CrudEmployee_back.Location = new System.Drawing.Point(505, 319);
            this.button_CrudEmployee_back.Name = "button_CrudEmployee_back";
            this.button_CrudEmployee_back.Size = new System.Drawing.Size(67, 30);
            this.button_CrudEmployee_back.TabIndex = 5;
            this.button_CrudEmployee_back.Text = "חזרה";
            this.button_CrudEmployee_back.UseVisualStyleBackColor = false;
            this.button_CrudEmployee_back.Click += new System.EventHandler(this.button_CrudEmployee_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
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
            // CrudEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_CrudEmployee_back);
            this.Controls.Add(this.createEmployee);
            this.Controls.Add(this.readEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrudEmployee";
            this.Text = "CrudEmployee";
            this.Load += new System.EventHandler(this.CrudEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createEmployee;
        private System.Windows.Forms.Button readEmployee;
        private System.Windows.Forms.Button button_CrudEmployee_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}