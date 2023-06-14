namespace Group11
{
    partial class Form_employeeMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_employeeMain));
            this.button_crudSupplier_ = new System.Windows.Forms.Button();
            this.button_crudEmployee = new System.Windows.Forms.Button();
            this.button_crudCustomer = new System.Windows.Forms.Button();
            this.button_crudProduct = new System.Windows.Forms.Button();
            this.button_addShiftConstraint = new System.Windows.Forms.Button();
            this.button_shiftArrangement = new System.Windows.Forms.Button();
            this.button_newPurchase = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.buttonGoToCalculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_crudSupplier_
            // 
            this.button_crudSupplier_.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_crudSupplier_.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_crudSupplier_.ForeColor = System.Drawing.Color.White;
            this.button_crudSupplier_.Location = new System.Drawing.Point(80, 263);
            this.button_crudSupplier_.Name = "button_crudSupplier_";
            this.button_crudSupplier_.Size = new System.Drawing.Size(181, 43);
            this.button_crudSupplier_.TabIndex = 0;
            this.button_crudSupplier_.Text = "ניהול ספקים";
            this.button_crudSupplier_.UseVisualStyleBackColor = false;
            this.button_crudSupplier_.Click += new System.EventHandler(this.button_crudSupplier);
            // 
            // button_crudEmployee
            // 
            this.button_crudEmployee.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_crudEmployee.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_crudEmployee.ForeColor = System.Drawing.Color.White;
            this.button_crudEmployee.Location = new System.Drawing.Point(80, 163);
            this.button_crudEmployee.Name = "button_crudEmployee";
            this.button_crudEmployee.Size = new System.Drawing.Size(181, 43);
            this.button_crudEmployee.TabIndex = 1;
            this.button_crudEmployee.Text = "ניהול עובדים";
            this.button_crudEmployee.UseVisualStyleBackColor = false;
            this.button_crudEmployee.Click += new System.EventHandler(this.button_crudEmployee_Click);
            // 
            // button_crudCustomer
            // 
            this.button_crudCustomer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_crudCustomer.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_crudCustomer.ForeColor = System.Drawing.Color.White;
            this.button_crudCustomer.Location = new System.Drawing.Point(80, 214);
            this.button_crudCustomer.Name = "button_crudCustomer";
            this.button_crudCustomer.Size = new System.Drawing.Size(181, 43);
            this.button_crudCustomer.TabIndex = 2;
            this.button_crudCustomer.Text = "ניהול לקוחות";
            this.button_crudCustomer.UseVisualStyleBackColor = false;
            this.button_crudCustomer.Click += new System.EventHandler(this.button_crudCustomer_Click);
            // 
            // button_crudProduct
            // 
            this.button_crudProduct.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_crudProduct.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_crudProduct.ForeColor = System.Drawing.Color.White;
            this.button_crudProduct.Location = new System.Drawing.Point(80, 312);
            this.button_crudProduct.Name = "button_crudProduct";
            this.button_crudProduct.Size = new System.Drawing.Size(181, 43);
            this.button_crudProduct.TabIndex = 3;
            this.button_crudProduct.Text = "ניהול מוצרים";
            this.button_crudProduct.UseVisualStyleBackColor = false;
            this.button_crudProduct.Click += new System.EventHandler(this.button_crudProduct_Click);
            // 
            // button_addShiftConstraint
            // 
            this.button_addShiftConstraint.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_addShiftConstraint.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_addShiftConstraint.ForeColor = System.Drawing.Color.White;
            this.button_addShiftConstraint.Location = new System.Drawing.Point(333, 214);
            this.button_addShiftConstraint.Name = "button_addShiftConstraint";
            this.button_addShiftConstraint.Size = new System.Drawing.Size(181, 43);
            this.button_addShiftConstraint.TabIndex = 4;
            this.button_addShiftConstraint.Text = "הוספת אילוץ עבודה";
            this.button_addShiftConstraint.UseVisualStyleBackColor = false;
            this.button_addShiftConstraint.Click += new System.EventHandler(this.button_addShiftConstraint_Click);
            // 
            // button_shiftArrangement
            // 
            this.button_shiftArrangement.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_shiftArrangement.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_shiftArrangement.ForeColor = System.Drawing.Color.White;
            this.button_shiftArrangement.Location = new System.Drawing.Point(333, 163);
            this.button_shiftArrangement.Name = "button_shiftArrangement";
            this.button_shiftArrangement.Size = new System.Drawing.Size(181, 43);
            this.button_shiftArrangement.TabIndex = 5;
            this.button_shiftArrangement.Text = "סידור משמרות";
            this.button_shiftArrangement.UseVisualStyleBackColor = false;
            this.button_shiftArrangement.Click += new System.EventHandler(this.button_shiftArrangement_Click);
            // 
            // button_newPurchase
            // 
            this.button_newPurchase.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_newPurchase.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_newPurchase.ForeColor = System.Drawing.Color.White;
            this.button_newPurchase.Location = new System.Drawing.Point(333, 263);
            this.button_newPurchase.Name = "button_newPurchase";
            this.button_newPurchase.Size = new System.Drawing.Size(181, 43);
            this.button_newPurchase.TabIndex = 6;
            this.button_newPurchase.Text = "רכישות מספקים";
            this.button_newPurchase.UseVisualStyleBackColor = false;
            this.button_newPurchase.Click += new System.EventHandler(this.button_newPurchase_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_exit.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(497, 417);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 32);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "יציאה";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // buttonGoToCalculate
            // 
            this.buttonGoToCalculate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonGoToCalculate.Font = new System.Drawing.Font("Adobe Heiti Std R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonGoToCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonGoToCalculate.Location = new System.Drawing.Point(333, 312);
            this.buttonGoToCalculate.Name = "buttonGoToCalculate";
            this.buttonGoToCalculate.Size = new System.Drawing.Size(181, 43);
            this.buttonGoToCalculate.TabIndex = 8;
            this.buttonGoToCalculate.Text = "חשב מחיר להזמנה";
            this.buttonGoToCalculate.UseVisualStyleBackColor = false;
            this.buttonGoToCalculate.Click += new System.EventHandler(this.buttonGoToCalculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Adobe Heiti Std R", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHello.Location = new System.Drawing.Point(231, 77);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(265, 48);
            this.labelHello.TabIndex = 36;
            this.labelHello.Text = "ברוכים הבאים  ";
            this.labelHello.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Adobe Heiti Std R", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelName.Location = new System.Drawing.Point(145, 85);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 40);
            this.labelName.TabIndex = 37;
            this.labelName.Text = "שם ";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox3.Location = new System.Drawing.Point(12, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 372);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // Form_employeeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGoToCalculate);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_newPurchase);
            this.Controls.Add(this.button_shiftArrangement);
            this.Controls.Add(this.button_addShiftConstraint);
            this.Controls.Add(this.button_crudProduct);
            this.Controls.Add(this.button_crudCustomer);
            this.Controls.Add(this.button_crudEmployee);
            this.Controls.Add(this.button_crudSupplier_);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_employeeMain";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_crudSupplier_;
        private System.Windows.Forms.Button button_crudEmployee;
        private System.Windows.Forms.Button button_crudCustomer;
        private System.Windows.Forms.Button button_crudProduct;
        private System.Windows.Forms.Button button_addShiftConstraint;
        private System.Windows.Forms.Button button_shiftArrangement;
        private System.Windows.Forms.Button button_newPurchase;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button buttonGoToCalculate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

