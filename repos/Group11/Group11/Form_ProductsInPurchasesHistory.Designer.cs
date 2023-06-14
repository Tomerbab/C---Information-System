namespace Group11
{
    partial class Form_ProductsInPurchasesHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ProductsInPurchasesHistory));
            this.dataGridView_ProductsInPurchase = new System.Windows.Forms.DataGridView();
            this.purchaseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInPurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsInPurchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_11DataSet = new Group11.SAD_11DataSet();
            this.productsInPurchaseTableAdapter = new Group11.SAD_11DataSetTableAdapters.ProductsInPurchaseTableAdapter();
            this.button_Back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductsInPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsInPurchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ProductsInPurchase
            // 
            this.dataGridView_ProductsInPurchase.AllowUserToAddRows = false;
            this.dataGridView_ProductsInPurchase.AllowUserToDeleteRows = false;
            this.dataGridView_ProductsInPurchase.AutoGenerateColumns = false;
            this.dataGridView_ProductsInPurchase.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_ProductsInPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProductsInPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseNumberDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.quantityInPurchaseDataGridViewTextBoxColumn,
            this.ProductName});
            this.dataGridView_ProductsInPurchase.DataSource = this.productsInPurchaseBindingSource;
            this.dataGridView_ProductsInPurchase.Location = new System.Drawing.Point(53, 115);
            this.dataGridView_ProductsInPurchase.Name = "dataGridView_ProductsInPurchase";
            this.dataGridView_ProductsInPurchase.ReadOnly = true;
            this.dataGridView_ProductsInPurchase.Size = new System.Drawing.Size(450, 196);
            this.dataGridView_ProductsInPurchase.TabIndex = 0;
            // 
            // purchaseNumberDataGridViewTextBoxColumn
            // 
            this.purchaseNumberDataGridViewTextBoxColumn.DataPropertyName = "purchaseNumber";
            this.purchaseNumberDataGridViewTextBoxColumn.HeaderText = "purchaseNumber";
            this.purchaseNumberDataGridViewTextBoxColumn.Name = "purchaseNumberDataGridViewTextBoxColumn";
            this.purchaseNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "serialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "serialNumber";
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            this.serialNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityInPurchaseDataGridViewTextBoxColumn
            // 
            this.quantityInPurchaseDataGridViewTextBoxColumn.DataPropertyName = "quantityInPurchase";
            this.quantityInPurchaseDataGridViewTextBoxColumn.HeaderText = "quantityInPurchase";
            this.quantityInPurchaseDataGridViewTextBoxColumn.Name = "quantityInPurchaseDataGridViewTextBoxColumn";
            this.quantityInPurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // productsInPurchaseBindingSource
            // 
            this.productsInPurchaseBindingSource.DataMember = "ProductsInPurchase";
            this.productsInPurchaseBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // sAD_11DataSet
            // 
            this.sAD_11DataSet.DataSetName = "SAD_11DataSet";
            this.sAD_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsInPurchaseTableAdapter
            // 
            this.productsInPurchaseTableAdapter.ClearBeforeFill = true;
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_Back.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Back.ForeColor = System.Drawing.Color.White;
            this.button_Back.Location = new System.Drawing.Point(497, 317);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 32);
            this.button_Back.TabIndex = 1;
            this.button_Back.Text = "חזרה";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(563, 14);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
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
            // Form_ProductsInPurchasesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(658, 427);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.dataGridView_ProductsInPurchase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ProductsInPurchasesHistory";
            this.Text = "Form_ProductsInPurchasesHistory";
            this.Load += new System.EventHandler(this.Form_ProductsInPurchasesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProductsInPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsInPurchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ProductsInPurchase;
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.BindingSource productsInPurchaseBindingSource;
        private SAD_11DataSetTableAdapters.ProductsInPurchaseTableAdapter productsInPurchaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInPurchaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}