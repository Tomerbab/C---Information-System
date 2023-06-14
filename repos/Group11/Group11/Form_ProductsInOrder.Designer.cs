namespace Group11
{
    partial class Form_ProductsInOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ProductsInOrder));
            this.dataGrid_productsInOrder = new System.Windows.Forms.DataGridView();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsInOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_11DataSet = new Group11.SAD_11DataSet();
            this.productsInOrdersTableAdapter = new Group11.SAD_11DataSetTableAdapters.ProductsInOrdersTableAdapter();
            this.button_Back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_productsInOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsInOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_productsInOrder
            // 
            this.dataGrid_productsInOrder.AllowUserToAddRows = false;
            this.dataGrid_productsInOrder.AllowUserToDeleteRows = false;
            this.dataGrid_productsInOrder.AutoGenerateColumns = false;
            this.dataGrid_productsInOrder.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_productsInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_productsInOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.serialNumberDataGridViewTextBoxColumn,
            this.quantityInOrderDataGridViewTextBoxColumn,
            this.productName});
            this.dataGrid_productsInOrder.DataSource = this.productsInOrdersBindingSource;
            this.dataGrid_productsInOrder.Location = new System.Drawing.Point(11, 112);
            this.dataGrid_productsInOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid_productsInOrder.Name = "dataGrid_productsInOrder";
            this.dataGrid_productsInOrder.ReadOnly = true;
            this.dataGrid_productsInOrder.RowTemplate.Height = 24;
            this.dataGrid_productsInOrder.Size = new System.Drawing.Size(562, 202);
            this.dataGrid_productsInOrder.TabIndex = 0;
            this.dataGrid_productsInOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_productsInOrder_CellContentClick);
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "orderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "orderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serialNumberDataGridViewTextBoxColumn
            // 
            this.serialNumberDataGridViewTextBoxColumn.DataPropertyName = "serialNumber";
            this.serialNumberDataGridViewTextBoxColumn.HeaderText = "serialNumber";
            this.serialNumberDataGridViewTextBoxColumn.Name = "serialNumberDataGridViewTextBoxColumn";
            this.serialNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityInOrderDataGridViewTextBoxColumn
            // 
            this.quantityInOrderDataGridViewTextBoxColumn.DataPropertyName = "quantityInOrder";
            this.quantityInOrderDataGridViewTextBoxColumn.HeaderText = "quantityInOrder";
            this.quantityInOrderDataGridViewTextBoxColumn.Name = "quantityInOrderDataGridViewTextBoxColumn";
            this.quantityInOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityInOrderDataGridViewTextBoxColumn.Width = 150;
            // 
            // productName
            // 
            this.productName.HeaderText = "productName";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 150;
            // 
            // productsInOrdersBindingSource
            // 
            this.productsInOrdersBindingSource.DataMember = "ProductsInOrders";
            this.productsInOrdersBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // sAD_11DataSet
            // 
            this.sAD_11DataSet.DataSetName = "SAD_11DataSet";
            this.sAD_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsInOrdersTableAdapter
            // 
            this.productsInOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // button_Back
            // 
            this.button_Back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_Back.ForeColor = System.Drawing.Color.White;
            this.button_Back.Location = new System.Drawing.Point(491, 322);
            this.button_Back.Margin = new System.Windows.Forms.Padding(2);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(82, 32);
            this.button_Back.TabIndex = 1;
            this.button_Back.Text = "חזרה";
            this.button_Back.UseVisualStyleBackColor = false;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(11, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(563, 14);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Form_ProductsInOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.dataGrid_productsInOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_ProductsInOrder";
            this.Text = "Form_ProductsInOrder";
            this.Load += new System.EventHandler(this.Form_ProductsInOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_productsInOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsInOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_productsInOrder;
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.BindingSource productsInOrdersBindingSource;
        private SAD_11DataSetTableAdapters.ProductsInOrdersTableAdapter productsInOrdersTableAdapter;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}