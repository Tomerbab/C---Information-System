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
    public partial class Form_updateEmployee : Form
    {
        private Employee employee;
        private string employeeID;
        public Form_updateEmployee()
        {
            InitializeComponent();

        }

        public Form_updateEmployee(String id , string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            comboBox_UE_status.Items.Add("active");
            comboBox_UE_status.Items.Add("inactive");
            employee = Program.seekEmployee(id);
            UE_ID.Text = employee.getID();
            UE_name.Text = employee.get_name();
            UE_birthDate.Text = employee.get_employeeBirthDate().ToString();
            textBox_UE_email.Text = employee.getEmail();
            textBox_UE_phoneNumber.Text = employee.getPhone();
            textBox_UE_address.Text = employee.getAddress();
            dateTimePicker_UE_startDate.Text = employee.getStartDate().ToString();
            textBox_UE_hourlySalary.Text = employee.getSalary().ToString();
            string status = "active";
            if (!employee.getstatus())
            {
                status = "inactive";
            }
            comboBox_UE_status.SelectedItem = status;
            textBox_UE_password.Text = employee.getPassword();
            comboBox_UE_type.DisplayMember = "Description";
            comboBox_UE_type.ValueMember = "Value";
            comboBox_UE_type.DataSource = Enum.GetValues(typeof(Type)).Cast<Enum>().Select(value => new
            { (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description, value }).OrderBy(item => item.value).ToList();


        }

        private void Form_updateEmployee_Load(object sender, EventArgs e)
        {

        }


        private bool CheckUpdateEmployeeInput()
        {
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            System.Text.RegularExpressions.Regex readEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-]+$");

            if (!readEmail.IsMatch(textBox_UE_email.Text) || textBox_UE_email.Text == "" || textBox_UE_email.Text.Length > 40)
            {
                MessageBox.Show("כתובת אימייל לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!readNumber.IsMatch(textBox_UE_phoneNumber.Text) || textBox_UE_phoneNumber.Text.Length != 10 || textBox_UE_phoneNumber.Text == "")
            {
                MessageBox.Show("מספר טלפון לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_UE_address.Text == "" || textBox_UE_address.Text.Length > 40)
            {
                MessageBox.Show("כתובת לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_UE_hourlySalary.Text == "" || !double.TryParse(textBox_UE_hourlySalary.Text, out _))
            {
                MessageBox.Show("שכר שעתי לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBox_UE_status.SelectedItem == null)
            {
                MessageBox.Show("סטטוס לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_UE_password.Text == "" || textBox_UE_password.Text.Length >20)
            {
                MessageBox.Show("סיסמא לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (comboBox_UE_type.SelectedItem == null)
            {
                MessageBox.Show("בחר סוג עובד", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }




        private void UE_updateEmployee_Click(object sender, EventArgs e)
        {
            if (CheckUpdateEmployeeInput())
            {
                employee.set_email(textBox_UE_email.Text);
                //  employee.set_birthDate(DateTime.Parse(UE_birthDate.Text));
                employee.set_phone(textBox_UE_phoneNumber.Text);
                employee.set_address(textBox_UE_address.Text);
                DateTime selectedStartDate = dateTimePicker_UE_startDate.Value;
                employee.set_startDate(selectedStartDate);
                employee.set_salary(double.Parse(textBox_UE_hourlySalary.Text));
                string selectedStatus = comboBox_UE_status.SelectedItem.ToString();
                if (selectedStatus == "active")
                {
                    employee.set_status(true);
                }
                else
                {
                    employee.set_status(false);
                }
                employee.set_password(textBox_UE_password.Text);
                string s = comboBox_UE_type.Text;
                if (s.IndexOf(" ") != -1)
                {
                    s = s.Remove(s.IndexOf(" "), 1);
                }

                employee.set_type((Type)Enum.Parse(typeof(Type), s));
                employee.Update_employee();
                MessageBox.Show("פרטי העובד עודכנו במערכת", "הפעולה הושלמה בהצלחה", MessageBoxButtons.OK);
                CrudEmployee backToCrud = new CrudEmployee(employeeID);
                backToCrud.Show();
                this.Hide();
            }

        }

        private void UE_back_Click(object sender, EventArgs e)
        {
            Form_employeeProfile back = new Form_employeeProfile(employee.getID(), employeeID);
            back.Show();
            this.Hide();
        }
    }
}
