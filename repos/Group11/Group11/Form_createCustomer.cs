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
    public partial class Form_createCustomer : Form
    {
        private string employeeID;

        public Form_createCustomer()
        {
            InitializeComponent();
        }

        public Form_createCustomer(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_createCustomer_Load(object sender, EventArgs e)
        {

        }

        private bool CheckCreateCustomerInput() // check the user input 
        {
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            System.Text.RegularExpressions.Regex readEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-]+$");
            if (textBox_CC_name.Text == "" || textBox_CC_name.Text.Length > 20)
            {
                MessageBox.Show("שם לא תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!readEmail.IsMatch(textBox_CC_email.Text) || textBox_CC_email.Text == "" || textBox_CC_email.Text.Length > 40)
            {
                MessageBox.Show("איימיל לא תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!readNumber.IsMatch(textBox_CC_phoneNumber.Text) || textBox_CC_phoneNumber.Text.Length != 10 || textBox_CC_phoneNumber.Text == "")
            {
                MessageBox.Show("מספר טלפון לא תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_CC_address.Text == "" || textBox_CC_address.Text.Length > 40)
            {
                MessageBox.Show("כתובת לא תקינה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_CC_password.Text == "" || textBox_CC_password.Text.Length > 20)
            {
                MessageBox.Show("סיסמה לא תקינה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void button_CC_create_Click(object sender, EventArgs e)
        {
            if (CheckCreateCustomerInput())
            {
                foreach (Customer customer in Program.Customers)
                {
                    if (customer.get_customerPhoneNumber().Equals(textBox_CC_phoneNumber.Text))
                    {
                        MessageBox.Show("הלקוח קיים במערכת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                Customer c = new Customer(Convert.ToString(Program.Customers.Count + 1), textBox_CC_name.Text, textBox_CC_email.Text, textBox_CC_phoneNumber.Text, textBox_CC_address.Text, textBox_CC_password.Text, true);//יצירת לקוח חדש
                MessageBox.Show("הלקוח נקלט במערכת.", "הפעולה הושלמה בהצלחה", MessageBoxButtons.OK);
                CrudCustomer backToCrud = new CrudCustomer(employeeID);
                backToCrud.Show();
                this.Hide();
            }
        }



        private void CC_back_Click(object sender, EventArgs e)
        {
            CrudCustomer backToCrud = new CrudCustomer(employeeID);
            backToCrud.Show();
            this.Hide();
        }

        private void textBox_CC_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
