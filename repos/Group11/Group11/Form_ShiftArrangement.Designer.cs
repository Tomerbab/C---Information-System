namespace Group11
{
    partial class Form_ShiftArrangement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ShiftArrangement));
            this.dataGridShifts = new System.Windows.Forms.DataGridView();
            this.shiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_11DataSet = new Group11.SAD_11DataSet();
            this.shiftsTableAdapter = new Group11.SAD_11DataSetTableAdapters.ShiftsTableAdapter();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shiftDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbersOfEmployeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrangementShift = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridShifts
            // 
            this.dataGridShifts.AllowUserToAddRows = false;
            this.dataGridShifts.AllowUserToDeleteRows = false;
            this.dataGridShifts.AutoGenerateColumns = false;
            this.dataGridShifts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shiftDateDataGridViewTextBoxColumn,
            this.shiftTypeDataGridViewTextBoxColumn,
            this.numbersOfEmployeesDataGridViewTextBoxColumn,
            this.arrangementShift});
            this.dataGridShifts.DataSource = this.shiftsBindingSource;
            this.dataGridShifts.Location = new System.Drawing.Point(23, 134);
            this.dataGridShifts.Name = "dataGridShifts";
            this.dataGridShifts.ReadOnly = true;
            this.dataGridShifts.Size = new System.Drawing.Size(549, 277);
            this.dataGridShifts.TabIndex = 0;
            this.dataGridShifts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_back.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(497, 417);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 32);
            this.button_back.TabIndex = 1;
            this.button_back.Text = "חזרה";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(560, 20);
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
            // arrangementShift
            // 
            this.arrangementShift.HeaderText = "Arrangement Shift";
            this.arrangementShift.Name = "arrangementShift";
            this.arrangementShift.ReadOnly = true;
            this.arrangementShift.Text = "Arrange";
            this.arrangementShift.ToolTipText = "Arrangement Shift";
            this.arrangementShift.UseColumnTextForButtonValue = true;
            // 
            // Form_ShiftArrangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.dataGridShifts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ShiftArrangement";
            this.Text = "Form_ShiftArrangement";
            this.Load += new System.EventHandler(this.Form_ShiftArrangement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridShifts;
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.BindingSource shiftsBindingSource;
        private SAD_11DataSetTableAdapters.ShiftsTableAdapter shiftsTableAdapter;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbersOfEmployeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn arrangementShift;
    }
}