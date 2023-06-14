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
    public partial class Form_createSupplier : Form
    {
        private string employeeID;
        public Form_createSupplier()
        {
            InitializeComponent();
        }
        public Form_createSupplier(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }


        private bool CheckCreateSupplier() // check the user input 
        {
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            System.Text.RegularExpressions.Regex readEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-]+$");
            if (textBox_CS_name.Text == "" || textBox_CS_name.Text.Length > 20)
            {
                MessageBox.Show("אנא הכנס שם ספק", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_CS_address.Text == "" || textBox_CS_address.Text.Length > 60)
            {
                MessageBox.Show("כתובת לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!readNumber.IsMatch(textBox_CS_phoneNumber.Text) || textBox_CS_phoneNumber.Text.Length != 10 || textBox_CS_phoneNumber.Text == "")
            {
                MessageBox.Show("מספר טלפון לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!readEmail.IsMatch(textBox_CS_email.Text) || textBox_CS_address.Text == "" || textBox_CS_email.Text.Length > 40)
            {
                MessageBox.Show("כתובת אימייל לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_CC_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CC_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CC_phoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CC_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CC_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CC_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_CC_create_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

       
        private void button_CS_create_Click(object sender, EventArgs e)
        {
            if (CheckCreateSupplier())
            {
                foreach (Supplier supplier in Program.Suppliers)
                {
                    if (supplier.get_SupplierPhoneNumber().Equals(textBox_CS_phoneNumber.Text))
                    {
                        MessageBox.Show("הספק קיים במערכת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                Supplier s = new Supplier(Convert.ToString(Program.Suppliers.Count + 1), textBox_CS_name.Text, textBox_CS_address.Text, textBox_CS_phoneNumber.Text, textBox_CS_email.Text, true);
                MessageBox.Show("הספק נקלט במערכת.", "הפעולה הושלמה בהצלחה", MessageBoxButtons.OK);
                CrudSupplier backToCrud = new CrudSupplier(employeeID);
                backToCrud.Show();
                this.Hide();
            }
        }

        private void Form_createSupplier_Load(object sender, EventArgs e)
        {

        }

        private void CS_back_Click(object sender, EventArgs e)
        {
            CrudSupplier backToCrud = new CrudSupplier(employeeID);
            backToCrud.Show();
            this.Hide();
        }
    }
}
