using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Group11
{
    public partial class Form_updateCustomer : Form
    {
        private Customer customer;
        private string employeeID;

        public Form_updateCustomer()
        {
            InitializeComponent();
        }

        public Form_updateCustomer(string id, string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.customer = Program.seekCustomer(id);
            label_UC_ID.Text = customer.get_customerID();
            label_UC_name.Text = customer.get_customerName();
            textBox_UC_email.Text = customer.get_customerEmail();
            textBox_UC_phoneNumber.Text = customer.get_customerPhoneNumber();
            textBox_UC_address.Text = customer.get_customerAddress();
            textBox_UC_password.Text = customer.get_customerPassword();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_updateCustomer_Load(object sender, EventArgs e)
        {

        }


        private bool CheckUpdateCustomerInput() // check the user input 
        {
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            System.Text.RegularExpressions.Regex readEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-]+$");




            if (!readEmail.IsMatch(textBox_UC_email.Text) || textBox_UC_email.Text == "" || textBox_UC_email.Text.Length > 40)
            {
                MessageBox.Show("כתובת אימייל לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!readNumber.IsMatch(textBox_UC_phoneNumber.Text) || textBox_UC_phoneNumber.Text.Length != 10 || textBox_UC_phoneNumber.Text == "")
            {
                MessageBox.Show("מספר טלפון לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_UC_address.Text == "" || textBox_UC_address.Text.Length > 40)
            {
                MessageBox.Show("כתובת לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_UC_password.Text == ""  || textBox_UC_password.Text.Length > 20)
            {
                MessageBox.Show("סיסמא לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button_updateCustomer_Click(object sender, EventArgs e)
        {
            if (CheckUpdateCustomerInput())
            {
                customer.set_customerEmail(textBox_UC_email.Text);
                customer.set_customerPhoneNumber(textBox_UC_phoneNumber.Text);
                customer.set_customerAddress(textBox_UC_address.Text);
                customer.set_customerPassword(textBox_UC_password.Text);
                customer.Update_customer();
                MessageBox.Show("פרטי הלקוח עודכנו במערכת", "הפעולה הושלמה בהצלחה", MessageBoxButtons.OK);
                CrudCustomer backToCrud = new CrudCustomer(employeeID);
                backToCrud.Show();
                this.Hide();
            }

        }

        private void textBox_UC_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_UC_name_Click(object sender, EventArgs e)
        {

        }

        private void textBox_UC_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_UC_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void UE_back_Click(object sender, EventArgs e)
        {
            Form_customerProfile update = new Form_customerProfile(customer.get_customerID(), employeeID);
            update.Show();
            this.Hide();
        }
    }
}
