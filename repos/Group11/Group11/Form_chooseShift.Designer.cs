namespace Group11
{
    partial class Form_chooseShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_chooseShift));
            this.dataGridView_futureShifts = new System.Windows.Forms.DataGridView();
            this.shiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_11DataSet = new Group11.SAD_11DataSet();
            this.shiftsTableAdapter = new Group11.SAD_11DataSetTableAdapters.ShiftsTableAdapter();
            this.shiftsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button_backToEM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.shiftDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbersOfEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_chooseShift = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_futureShifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_futureShifts
            // 
            this.dataGridView_futureShifts.AllowUserToAddRows = false;
            this.dataGridView_futureShifts.AllowUserToDeleteRows = false;
            this.dataGridView_futureShifts.AutoGenerateColumns = false;
            this.dataGridView_futureShifts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_futureShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_futureShifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shiftDateDataGridViewTextBoxColumn,
            this.shiftTypeDataGridViewTextBoxColumn,
            this.numbersOfEmployeesDataGridViewTextBoxColumn,
            this.Column_chooseShift});
            this.dataGridView_futureShifts.DataSource = this.shiftsBindingSource;
            this.dataGridView_futureShifts.Location = new System.Drawing.Point(57, 84);
            this.dataGridView_futureShifts.Name = "dataGridView_futureShifts";
            this.dataGridView_futureShifts.ReadOnly = true;
            this.dataGridView_futureShifts.Size = new System.Drawing.Size(527, 321);
            this.dataGridView_futureShifts.TabIndex = 0;
            this.dataGridView_futureShifts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_futureShifts_CellContentClick);
            // 
            // shiftsBindingSource
            // 
            this.shiftsBindingSource.DataMember = "Shifts";
            this.shiftsBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // sAD_11DataSet
            // 
            this.sAD_11DataSet.DataSetName = "SAD_11DataSet";
            this.sAD_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shiftsTableAdapter
            // 
            this.shiftsTableAdapter.ClearBeforeFill = true;
            // 
            // shiftsBindingSource1
            // 
            this.shiftsBindingSource1.DataMember = "Shifts";
            this.shiftsBindingSource1.DataSource = this.sAD_11DataSet;
            // 
            // button_backToEM
            // 
            this.button_backToEM.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_backToEM.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_backToEM.ForeColor = System.Drawing.Color.White;
            this.button_backToEM.Location = new System.Drawing.Point(492, 411);
            this.button_backToEM.Name = "button_backToEM";
            this.button_backToEM.Size = new System.Drawing.Size(92, 38);
            this.button_backToEM.TabIndex = 7;
            this.button_backToEM.Text = "חזרה";
            this.button_backToEM.UseVisualStyleBackColor = false;
            this.button_backToEM.Click += new System.EventHandler(this.button_backToEM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 380);
            this.pictureBox2.TabIndex = 128;
            this.pictureBox2.TabStop = false;
            // 
            // shiftDateDataGridViewTextBoxColumn
            // 
            this.shiftDateDataGridViewTextBoxColumn.DataPropertyName = "shiftDate";
            this.shiftDateDataGridViewTextBoxColumn.HeaderText = "shiftDate";
            this.shiftDateDataGridViewTextBoxColumn.Name = "shiftDateDataGridViewTextBoxColumn";
            this.shiftDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // shiftTypeDataGridViewTextBoxColumn
            // 
            this.shiftTypeDataGridViewTextBoxColumn.DataPropertyName = "shiftType";
            this.shiftTypeDataGridViewTextBoxColumn.HeaderText = "shiftType";
            this.shiftTypeDataGridViewTextBoxColumn.Name = "shiftTypeDataGridViewTextBoxColumn";
            this.shiftTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numbersOfEmployeesDataGridViewTextBoxColumn
            // 
            this.numbersOfEmployeesDataGridViewTextBoxColumn.DataPropertyName = "numbersOfEmployees";
            this.numbersOfEmployeesDataGridViewTextBoxColumn.HeaderText = "numbersOfEmployees";
            this.numbersOfEmployeesDataGridViewTextBoxColumn.Name = "numbersOfEmployeesDataGridViewTextBoxColumn";
            this.numbersOfEmployeesDataGridViewTextBoxColumn.ReadOnly = true;
            this.numbersOfEmployeesDataGridViewTextBoxColumn.Width = 120;
            // 
            // Column_chooseShift
            // 
            this.Column_chooseShift.HeaderText = "Choose Shift";
            this.Column_chooseShift.Name = "Column_chooseShift";
            this.Column_chooseShift.ReadOnly = true;
            this.Column_chooseShift.Text = "Choose Shift";
            this.Column_chooseShift.UseColumnTextForButtonValue = true;
            // 
            // Form_chooseShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_backToEM);
            this.Controls.Add(this.dataGridView_futureShifts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_chooseShift";
            this.Text = "Form_chooseShift";
            this.Load += new System.EventHandler(this.Form_chooseShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_futureShifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_futureShifts;
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.BindingSource shiftsBindingSource;
        private SAD_11DataSetTableAdapters.ShiftsTableAdapter shiftsTableAdapter;
        private System.Windows.Forms.BindingSource shiftsBindingSource1;
        private System.Windows.Forms.Button button_backToEM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersOfEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column_chooseShift;
    }
}