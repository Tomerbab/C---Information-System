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
    public partial class Form_readEmployee : Form
    {
        private string employeeID;
        public Form_readEmployee()
        {
            InitializeComponent();
        }

        public Form_readEmployee(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }

        private void button_EmployeeSearch_Click(object sender, EventArgs e)
        {

            if (textBox_employeeIdSearch.Text == "")
            {
                MessageBox.Show("הכנס מספר עובד!");
                return;
            }
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            if (!readNumber.IsMatch(textBox_employeeIdSearch.Text))
            {
                MessageBox.Show("מספר עובד לא תקין!");
                return;

            }
            if (checkEmployee(textBox_employeeIdSearch.Text))
            {
                Form_employeeProfile cp = new Form_employeeProfile(textBox_employeeIdSearch.Text, employeeID);
                cp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("העובד לא נמצא , הכנס מספר עובד תקין");
            }
        }



        public bool checkEmployee(String id)
        {
            if (Program.seekEmployee(id) != null)
            {
                return true;
            }

            return false;
        }



        private void Form_readEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button_backFromReadEmployee_Click(object sender, EventArgs e)
        {
            CrudEmployee back = new CrudEmployee(employeeID);
            back.Show();
            this.Hide();
        }
    }
}
