namespace Group11
{
    partial class Form_readCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_readCustomer));
            this.button_CustomerSearch = new System.Windows.Forms.Button();
            this.textbox_customerID = new System.Windows.Forms.Label();
            this.textBox_customerIdSearch = new System.Windows.Forms.TextBox();
            this.button_backFromReadCustomer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_CustomerSearch
            // 
            this.button_CustomerSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_CustomerSearch.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_CustomerSearch.ForeColor = System.Drawing.Color.White;
            this.button_CustomerSearch.Location = new System.Drawing.Point(13, 316);
            this.button_CustomerSearch.Name = "button_CustomerSearch";
            this.button_CustomerSearch.Size = new System.Drawing.Size(79, 34);
            this.button_CustomerSearch.TabIndex = 0;
            this.button_CustomerSearch.Text = "חפש";
            this.button_CustomerSearch.UseVisualStyleBackColor = false;
            this.button_CustomerSearch.Click += new System.EventHandler(this.button_CustomerSearch_Click);
            // 
            // textbox_customerID
            // 
            this.textbox_customerID.AutoSize = true;
            this.textbox_customerID.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textbox_customerID.ForeColor = System.Drawing.Color.Black;
            this.textbox_customerID.Location = new System.Drawing.Point(283, 161);
            this.textbox_customerID.Name = "textbox_customerID";
            this.textbox_customerID.Size = new System.Drawing.Size(199, 26);
            this.textbox_customerID.TabIndex = 1;
            this.textbox_customerID.Text = ":הזן מספר לקוח לחיפוש";
            this.textbox_customerID.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_customerIdSearch
            // 
            this.textBox_customerIdSearch.Font = new System.Drawing.Font("Microsoft Himalaya", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_customerIdSearch.Location = new System.Drawing.Point(122, 165);
            this.textBox_customerIdSearch.Name = "textBox_customerIdSearch";
            this.textBox_customerIdSearch.Size = new System.Drawing.Size(146, 18);
            this.textBox_customerIdSearch.TabIndex = 2;
            this.textBox_customerIdSearch.TextChanged += new System.EventHandler(this.textBox_customerSearch_TextChanged);
            // 
            // button_backFromReadCustomer
            // 
            this.button_backFromReadCustomer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_backFromReadCustomer.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_backFromReadCustomer.ForeColor = System.Drawing.Color.White;
            this.button_backFromReadCustomer.Location = new System.Drawing.Point(488, 316);
            this.button_backFromReadCustomer.Name = "button_backFromReadCustomer";
            this.button_backFromReadCustomer.Size = new System.Drawing.Size(84, 33);
            this.button_backFromReadCustomer.TabIndex = 3;
            this.button_backFromReadCustomer.Text = "חזרה";
            this.button_backFromReadCustomer.UseVisualStyleBackColor = false;
            this.button_backFromReadCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(13, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(563, 14);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Form_readCustomer
            // 
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_backFromReadCustomer);
            this.Controls.Add(this.textBox_customerIdSearch);
            this.Controls.Add(this.textbox_customerID);
            this.Controls.Add(this.button_CustomerSearch);
            this.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_readCustomer";
            this.Load += new System.EventHandler(this.Form_readCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CustomerSearch;
        private System.Windows.Forms.Label textbox_customerID;
        private System.Windows.Forms.TextBox textBox_customerIdSearch;
        private System.Windows.Forms.Button button_backFromReadCustomer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}