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
    public partial class Form_createEmployee : Form
    {
        private string employeeID;
        public Form_createEmployee()
        {
            InitializeComponent();
            comboBox_CE_status.Items.Add("active");
            comboBox_CE_status.Items.Add("inactive");
            comboBox_CE_status.SelectedIndex = 0;
            comboBox_CE_type.DataSource = Enum.GetValues(typeof(Type));
        }
        public Form_createEmployee(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
            comboBox_CE_status.Items.Add("active");
            comboBox_CE_status.Items.Add("inactive");
            comboBox_CE_status.SelectedIndex = 0;
            comboBox_CE_type.DisplayMember = "Description";
            comboBox_CE_type.ValueMember = "Value";
            comboBox_CE_type.DataSource = Enum.GetValues(typeof(Type)).Cast<Enum>().Select(value => new
            { (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description, value }).OrderBy(item => item.value).ToList();

        }
    

        private void Form_createEmployee_Load(object sender, EventArgs e)
        {

        }


        private bool CheckCreateEmployee() // check the user input 
        {
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            System.Text.RegularExpressions.Regex readEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-]+$");
            if (textBox_CE_name.Text == "" || textBox_CE_name.Text.Length > 20)
            {
                MessageBox.Show("שם לא תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!readEmail.IsMatch(textBox_CE_email.Text) || textBox_CE_email.Text == "" || textBox_CE_email.Text.Length > 40)
            {
                MessageBox.Show("כתובת אימייל לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!readNumber.IsMatch(textBox_CE_phoneNumber.Text) || textBox_CE_phoneNumber.Text.Length != 10 || textBox_CE_phoneNumber.Text == "")
            {
                MessageBox.Show("מספר טלפון לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_CE_address.Text == "" || textBox_CE_address.Text.Length > 40)
            {
                MessageBox.Show("כתובת לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_CE_hourlySalary.Text == "" || !double.TryParse(textBox_CE_hourlySalary.Text, out _))
            {
                MessageBox.Show("שכר עבודה לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBox_CE_status.SelectedItem == null)
            {
                MessageBox.Show("סטטוס לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_CE_password.Text == "" || textBox_CE_password.Text.Length >20)
            {
                MessageBox.Show("סיסמא לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBox_CE_type.SelectedItem == null)
            {
                MessageBox.Show("בחר סוג עובד", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void CE_createEmployee_Click(object sender, EventArgs e)
        {
            if (CheckCreateEmployee())
            {
                foreach (Employee employee in Program.Employees)
                {
                    if (employee.getPhone().Equals(textBox_CE_phoneNumber.Text))
                    {
                        MessageBox.Show("העובד קיים במערכת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                Boolean status;
                string selectedStatus = comboBox_CE_status.SelectedItem.ToString();
                if (selectedStatus == "active")
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                string s = comboBox_CE_type.Text;
                if (s.IndexOf(" ") != -1)
                {
                    s = s.Remove(s.IndexOf(" "), 1);
                }
                Employee c = new Employee(Convert.ToString(Program.Employees.Count + 1), textBox_CE_name.Text, dateTimePicker_CE_birthDate.Value, textBox_CE_email.Text, textBox_CE_phoneNumber.Text, textBox_CE_address.Text, dateTimePicker_CE_startDate.Value,
                    Double.Parse(textBox_CE_hourlySalary.Text), status, textBox_CE_password.Text, (Type)Enum.Parse(typeof(Type), s), true);//יצירת עובד חדש
                MessageBox.Show("העובד נקלט במערכת", "הפעולה הושלמה בהצלחה", MessageBoxButtons.OK);
                CrudEmployee backToCrud = new CrudEmployee(employeeID);
                backToCrud.Show();
                this.Hide();
            }

        }


        private void CE_back_Click(object sender, EventArgs e)
        {
            CrudEmployee backToCrud = new CrudEmployee(employeeID);
            backToCrud.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
