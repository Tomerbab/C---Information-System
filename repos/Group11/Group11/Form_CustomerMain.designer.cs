namespace Group11
{
    partial class Form_CustomerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CustomerMain));
            this.button_ordersHistory = new System.Windows.Forms.Button();
            this.button_payForOrders = new System.Windows.Forms.Button();
            this.CM_back = new System.Windows.Forms.Button();
            this.button_scheduleMetting = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ordersHistory
            // 
            this.button_ordersHistory.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_ordersHistory.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_ordersHistory.ForeColor = System.Drawing.Color.White;
            this.button_ordersHistory.Location = new System.Drawing.Point(173, 192);
            this.button_ordersHistory.Name = "button_ordersHistory";
            this.button_ordersHistory.Size = new System.Drawing.Size(261, 52);
            this.button_ordersHistory.TabIndex = 0;
            this.button_ordersHistory.Text = "צפה בהיסטוריית הזמנות";
            this.button_ordersHistory.UseVisualStyleBackColor = false;
            this.button_ordersHistory.Click += new System.EventHandler(this.button_ordersHistory_Click);
            // 
            // button_payForOrders
            // 
            this.button_payForOrders.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_payForOrders.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_payForOrders.ForeColor = System.Drawing.Color.White;
            this.button_payForOrders.Location = new System.Drawing.Point(173, 308);
            this.button_payForOrders.Name = "button_payForOrders";
            this.button_payForOrders.Size = new System.Drawing.Size(261, 52);
            this.button_payForOrders.TabIndex = 1;
            this.button_payForOrders.Text = "שלם עבור הזמנה";
            this.button_payForOrders.UseVisualStyleBackColor = false;
            this.button_payForOrders.Click += new System.EventHandler(this.button_payForOrders_Click);
            // 
            // CM_back
            // 
            this.CM_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CM_back.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CM_back.ForeColor = System.Drawing.Color.White;
            this.CM_back.Location = new System.Drawing.Point(502, 409);
            this.CM_back.Name = "CM_back";
            this.CM_back.Size = new System.Drawing.Size(76, 32);
            this.CM_back.TabIndex = 22;
            this.CM_back.Text = "יציאה";
            this.CM_back.UseVisualStyleBackColor = false;
            this.CM_back.Click += new System.EventHandler(this.CM_back_Click);
            // 
            // button_scheduleMetting
            // 
            this.button_scheduleMetting.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_scheduleMetting.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_scheduleMetting.ForeColor = System.Drawing.Color.White;
            this.button_scheduleMetting.Location = new System.Drawing.Point(173, 250);
            this.button_scheduleMetting.Name = "button_scheduleMetting";
            this.button_scheduleMetting.Size = new System.Drawing.Size(261, 52);
            this.button_scheduleMetting.TabIndex = 23;
            this.button_scheduleMetting.Text = "קבע פגישה";
            this.button_scheduleMetting.UseVisualStyleBackColor = false;
            this.button_scheduleMetting.Click += new System.EventHandler(this.button_scheduleMeeting);
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
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Adobe Heiti Std R", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHello.Location = new System.Drawing.Point(246, 92);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(255, 48);
            this.labelHello.TabIndex = 37;
            this.labelHello.Text = "ברוכים הבאים ";
            this.labelHello.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Adobe Heiti Std R", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelName.Location = new System.Drawing.Point(125, 97);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 40);
            this.labelName.TabIndex = 38;
            this.labelName.Text = "שם ";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox3.Location = new System.Drawing.Point(12, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 372);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // Form_CustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(590, 449);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_scheduleMetting);
            this.Controls.Add(this.CM_back);
            this.Controls.Add(this.button_payForOrders);
            this.Controls.Add(this.button_ordersHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_CustomerMain";
            this.Text = "Form_CustomerMain";
            this.Load += new System.EventHandler(this.Form_CustomerMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ordersHistory;
        private System.Windows.Forms.Button button_payForOrders;
        private System.Windows.Forms.Button CM_back;
        private System.Windows.Forms.Button button_scheduleMetting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}