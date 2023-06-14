namespace Group11
{
    partial class Form_chooseEmployeesForShift
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_chooseEmployeesForShift));
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sAD_11DataSet = new Group11.SAD_11DataSet();
            this.employeesTableAdapter = new Group11.SAD_11DataSetTableAdapters.EmployeesTableAdapter();
            this.button_arrangementShift = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridView_employeesForShift = new System.Windows.Forms.DataGridView();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeehourlySalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employeesForShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.sAD_11DataSet;
            // 
            // sAD_11DataSet
            // 
            this.sAD_11DataSet.DataSetName = "SAD_11DataSet";
            this.sAD_11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // button_arrangementShift
            // 
            this.button_arrangementShift.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_arrangementShift.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_arrangementShift.ForeColor = System.Drawing.Color.White;
            this.button_arrangementShift.Location = new System.Drawing.Point(12, 508);
            this.button_arrangementShift.Name = "button_arrangementShift";
            this.button_arrangementShift.Size = new System.Drawing.Size(108, 44);
            this.button_arrangementShift.TabIndex = 1;
            this.button_arrangementShift.Text = "הוסף עובד";
            this.button_arrangementShift.UseVisualStyleBackColor = false;
            this.button_arrangementShift.Click += new System.EventHandler(this.button_arrangementShift_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_back.Font = new System.Drawing.Font("Adobe Heiti Std R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_back.ForeColor = System.Drawing.Color.White;
            this.button_back.Location = new System.Drawing.Point(1518, 508);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(77, 41);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "חזרה";
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dataGridView_employeesForShift
            // 
            this.dataGridView_employeesForShift.AllowUserToAddRows = false;
            this.dataGridView_employeesForShift.AllowUserToDeleteRows = false;
            this.dataGridView_employeesForShift.AutoGenerateColumns = false;
            this.dataGridView_employeesForShift.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_employeesForShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employeesForShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeBirthDateDataGridViewTextBoxColumn,
            this.employeeEmailDataGridViewTextBoxColumn,
            this.employeePhoneNumberDataGridViewTextBoxColumn,
            this.employeeAddressDataGridViewTextBoxColumn,
            this.employeeStartDateDataGridViewTextBoxColumn,
            this.employeehourlySalaryDataGridViewTextBoxColumn,
            this.employeeStatusDataGridViewTextBoxColumn,
            this.employeePasswordDataGridViewTextBoxColumn,
            this.employeeTypeDataGridViewTextBoxColumn});
            this.dataGridView_employeesForShift.DataSource = this.employeesBindingSource1;
            this.dataGridView_employeesForShift.Location = new System.Drawing.Point(12, 146);
            this.dataGridView_employeesForShift.Name = "dataGridView_employeesForShift";
            this.dataGridView_employeesForShift.Size = new System.Drawing.Size(1583, 356);
            this.dataGridView_employeesForShift.TabIndex = 3;
            this.dataGridView_employeesForShift.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_employeesForShift_CellContentClick);
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.sAD_11DataSet;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(12, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1583, 22);
            this.pictureBox2.TabIndex = 125;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 126;
            this.pictureBox1.TabStop = false;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "employeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "employeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // employeeBirthDateDataGridViewTextBoxColumn
            // 
            this.employeeBirthDateDataGridViewTextBoxColumn.DataPropertyName = "employeeBirthDate";
            this.employeeBirthDateDataGridViewTextBoxColumn.HeaderText = "employeeBirthDate";
            this.employeeBirthDateDataGridViewTextBoxColumn.Name = "employeeBirthDateDataGridViewTextBoxColumn";
            this.employeeBirthDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeeEmailDataGridViewTextBoxColumn
            // 
            this.employeeEmailDataGridViewTextBoxColumn.DataPropertyName = "employeeEmail";
            this.employeeEmailDataGridViewTextBoxColumn.HeaderText = "employeeEmail";
            this.employeeEmailDataGridViewTextBoxColumn.Name = "employeeEmailDataGridViewTextBoxColumn";
            this.employeeEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeePhoneNumberDataGridViewTextBoxColumn
            // 
            this.employeePhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "employeePhoneNumber";
            this.employeePhoneNumberDataGridViewTextBoxColumn.HeaderText = "employeePhoneNumber";
            this.employeePhoneNumberDataGridViewTextBoxColumn.Name = "employeePhoneNumberDataGridViewTextBoxColumn";
            this.employeePhoneNumberDataGridViewTextBoxColumn.Width = 120;
            // 
            // employeeAddressDataGridViewTextBoxColumn
            // 
            this.employeeAddressDataGridViewTextBoxColumn.DataPropertyName = "employeeAddress";
            this.employeeAddressDataGridViewTextBoxColumn.HeaderText = "employeeAddress";
            this.employeeAddressDataGridViewTextBoxColumn.Name = "employeeAddressDataGridViewTextBoxColumn";
            this.employeeAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // employeeStartDateDataGridViewTextBoxColumn
            // 
            this.employeeStartDateDataGridViewTextBoxColumn.DataPropertyName = "employeeStartDate";
            this.employeeStartDateDataGridViewTextBoxColumn.HeaderText = "employeeStartDate";
            this.employeeStartDateDataGridViewTextBoxColumn.Name = "employeeStartDateDataGridViewTextBoxColumn";
            this.employeeStartDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeehourlySalaryDataGridViewTextBoxColumn
            // 
            this.employeehourlySalaryDataGridViewTextBoxColumn.DataPropertyName = "employeehourlySalary";
            this.employeehourlySalaryDataGridViewTextBoxColumn.HeaderText = "employeehourlySalary";
            this.employeehourlySalaryDataGridViewTextBoxColumn.Name = "employeehourlySalaryDataGridViewTextBoxColumn";
            this.employeehourlySalaryDataGridViewTextBoxColumn.Width = 120;
            // 
            // employeeStatusDataGridViewTextBoxColumn
            // 
            this.employeeStatusDataGridViewTextBoxColumn.DataPropertyName = "employeeStatus";
            this.employeeStatusDataGridViewTextBoxColumn.HeaderText = "employeeStatus";
            this.employeeStatusDataGridViewTextBoxColumn.Name = "employeeStatusDataGridViewTextBoxColumn";
            // 
            // employeePasswordDataGridViewTextBoxColumn
            // 
            this.employeePasswordDataGridViewTextBoxColumn.DataPropertyName = "employeePassword";
            this.employeePasswordDataGridViewTextBoxColumn.HeaderText = "employeePassword";
            this.employeePasswordDataGridViewTextBoxColumn.Name = "employeePasswordDataGridViewTextBoxColumn";
            // 
            // employeeTypeDataGridViewTextBoxColumn
            // 
            this.employeeTypeDataGridViewTextBoxColumn.DataPropertyName = "employeeType";
            this.employeeTypeDataGridViewTextBoxColumn.HeaderText = "employeeType";
            this.employeeTypeDataGridViewTextBoxColumn.Name = "employeeTypeDataGridViewTextBoxColumn";
            // 
            // Form_chooseEmployeesForShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1618, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView_employeesForShift);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_arrangementShift);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_chooseEmployeesForShift";
            this.Text = "Form_chooseEmployeesForShift";
            this.Load += new System.EventHandler(this.Form_chooseEmployeesForShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_11DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employeesForShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SAD_11DataSet sAD_11DataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private SAD_11DataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Button button_arrangementShift;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridView_employeesForShift;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeehourlySalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeTypeDataGridViewTextBoxColumn;
    }
}