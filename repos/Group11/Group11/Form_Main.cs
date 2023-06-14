using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
 
        }

        private void Main_Customer_Click(object sender, EventArgs e)
        {
            Form_customerLogin cp= new Form_customerLogin(); // מסך הבא ללקוח 
            cp.Show();
            this.Hide();
        }

        private void Main_Employee_Click(object sender, EventArgs e)
        {
             Form_employeeLogin cp = new Form_employeeLogin(); // מסך הבא לעובד 
            cp.Show();
            this.Hide(); 
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void Welcome_Labal_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
