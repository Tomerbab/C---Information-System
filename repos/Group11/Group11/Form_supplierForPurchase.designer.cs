namespace Group11
{
    partial class Form_supplierForPurchase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_supplierForPurchase));
            this.supplierDataGrid = new System.Windows.Forms.DataGridView();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_11DataSet = new Group11.SAD_11DataSet();
            this.suppliersTableAdapter = new Group11.SAD_11DataSetTableAdapters.SuppliersTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_chooseSupplier = new System.Windows.Forms.Button();
            this.textBox_supplierNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.supplierNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierphoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierDataGrid
            // 
            this.supplierDataGrid.AllowUserToAddRows = false;
            this.supplierDataGrid.AllowUserToDeleteRows = false;
            this.supplierDataGrid.AutoGenerateColumns = false;
            this.supplierDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.supplierDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.supplierDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierNumberDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.supplierAddressDataGridViewTextBoxColumn,
            this.supplierphoneNumberDataGridViewTextBoxColumn,
            this.supplierEmailDataGridViewTextBoxColumn});
            this.supplierDataGrid.DataSource = this.suppliersBindingSource;
            this.supplierDataGrid.Location = new System.Drawing.Point(16, 153);
            this.supplierDataGrid.Name = "supplierDataGrid";
            this.supplierDataGrid.ReadOnly = true;
            this.supplierDataGrid.Size = new System.Drawing.Size(656, 330);
            this.supplierDataGrid.TabIndex = 0;
            this.supplierDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierDataGrid_CellContentClick);
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // sAD_11DataSet
            // 
            this.sAD_11DataSet.DataSetName = "SAD_11DataSet";
            this.sAD_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // button_chooseSupplier
            // 
            this.button_chooseSupplier.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_chooseSupplier.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_chooseSupplier.ForeColor = System.Drawing.Color.White;
            this.button_chooseSupplier.Location = new System.Drawing.Point(12, 507);
            this.button_chooseSupplier.Name = "button_chooseSupplier";
            this.button_chooseSupplier.Size = new System.Drawing.Size(163, 42);
            this.button_chooseSupplier.TabIndex = 1;
            this.button_chooseSupplier.Text = "עבור לבחירת מוצרים";
            this.button_chooseSupplier.UseVisualStyleBackColor = false;
            this.button_chooseSupplier.Click += new System.EventHandler(this.button_chooseSupplier_Click);
            // 
            // textBox_supplierNum
            // 
            this.textBox_supplierNum.Location = new System.Drawing.Point(195, 127);
            this.textBox_supplierNum.Name = "textBox_supplierNum";
            this.textBox_supplierNum.Size = new System.Drawing.Size(138, 20);
            this.textBox_supplierNum.TabIndex = 2;
            this.textBox_supplierNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Heiti Std R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(339, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "הכנס מספר ספק ";
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_Back.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Back.ForeColor = System.Drawing.Color.White;
            this.button_Back.Location = new System.Drawing.Point(593, 507);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(79, 42);
            this.button_Back.TabIndex = 4;
            this.button_Back.Text = "חזרה";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(660, 17);
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
            // supplierNumberDataGridViewTextBoxColumn
            // 
            this.supplierNumberDataGridViewTextBoxColumn.DataPropertyName = "supplierNumber";
            this.supplierNumberDataGridViewTextBoxColumn.HeaderText = "supplierNumber";
            this.supplierNumberDataGridViewTextBoxColumn.Name = "supplierNumberDataGridViewTextBoxColumn";
            this.supplierNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "supplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "supplierName";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierAddressDataGridViewTextBoxColumn
            // 
            this.supplierAddressDataGridViewTextBoxColumn.DataPropertyName = "supplierAddress";
            this.supplierAddressDataGridViewTextBoxColumn.HeaderText = "supplierAddress";
            this.supplierAddressDataGridViewTextBoxColumn.Name = "supplierAddressDataGridViewTextBoxColumn";
            this.supplierAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierAddressDataGridViewTextBoxColumn.Width = 150;
            // 
            // supplierphoneNumberDataGridViewTextBoxColumn
            // 
            this.supplierphoneNumberDataGridViewTextBoxColumn.DataPropertyName = "supplierphoneNumber";
            this.supplierphoneNumberDataGridViewTextBoxColumn.HeaderText = "supplierphoneNumber";
            this.supplierphoneNumberDataGridViewTextBoxColumn.Name = "supplierphoneNumberDataGridViewTextBoxColumn";
            this.supplierphoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierEmailDataGridViewTextBoxColumn
            // 
            this.supplierEmailDataGridViewTextBoxColumn.DataPropertyName = "supplierEmail";
            this.supplierEmailDataGridViewTextBoxColumn.HeaderText = "supplierEmail";
            this.supplierEmailDataGridViewTextBoxColumn.Name = "supplierEmailDataGridViewTextBoxColumn";
            this.supplierEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form_supplierForPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_supplierNum);
            this.Controls.Add(this.button_chooseSupplier);
            this.Controls.Add(this.supplierDataGrid);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_supplierForPurchase";
            this.Text = "Form_supplierForPurchase";
            this.Load += new System.EventHandler(this.Form_supplierForPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView supplierDataGrid;
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private SAD_11DataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_chooseSupplier;
        private System.Windows.Forms.TextBox textBox_supplierNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierphoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierEmailDataGridViewTextBoxColumn;
    }
}