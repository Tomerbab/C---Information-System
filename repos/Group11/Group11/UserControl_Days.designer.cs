namespace Group11
{
    partial class UserControl_Days
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ID_Days = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_Days
            // 
            this.ID_Days.AutoSize = true;
            this.ID_Days.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ID_Days.Location = new System.Drawing.Point(3, 0);
            this.ID_Days.Name = "ID_Days";
            this.ID_Days.Size = new System.Drawing.Size(0, 20);
            this.ID_Days.TabIndex = 0;
            // 
            // UserControl_Days
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ID_Days);
            this.Name = "UserControl_Days";
            this.Size = new System.Drawing.Size(133, 99);
            this.Load += new System.EventHandler(this.UserControl_Days_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_Days;
    }
}
