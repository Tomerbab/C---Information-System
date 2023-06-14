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
    public partial class Form_updateSupplier : Form
    {
        private Supplier supplier;
        private string employeeID;

        public Form_updateSupplier()
        {
            InitializeComponent();
        }


        public Form_updateSupplier(String serialNumber,string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            supplier = Program.seekSupplier(serialNumber);
            label_US_ID.Text = supplier.get_SupplierNumber();
            label_US_name.Text = supplier.get_SupplierName();
            textBox_US_address.Text = supplier.get_SupplierAddress();
            textBox_US_phoneNumber.Text = supplier.get_SupplierPhoneNumber();
            textBox_US_email.Text = supplier.get_SupplierEmail();



        }


        private bool CheckUpdateSupplier() // check the user input 
        {
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            System.Text.RegularExpressions.Regex readEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-]+$");
            if (textBox_US_address.Text == "" || textBox_US_address.Text.Length > 60)
            {
                MessageBox.Show("כתובת לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!readNumber.IsMatch(textBox_US_phoneNumber.Text) || textBox_US_phoneNumber.Text.Length != 10 || textBox_US_phoneNumber.Text == "")
            {
                MessageBox.Show("מספר טלפון לא תקין", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!readEmail.IsMatch(textBox_US_email.Text) || textBox_US_email.Text == "" || textBox_US_email.Text.Length > 40)
            {
                MessageBox.Show("כתובת אימייל לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_US_update(object sender, EventArgs e) // button_updateSupplier
        {
            if (CheckUpdateSupplier())
            {
                supplier.set_SupplierAddress(textBox_US_address.Text);
                supplier.set_SupplierPhoneNumber(textBox_US_phoneNumber.Text);
                supplier.set_SupplierEmail(textBox_US_email.Text);

                supplier.Update_supplier();
                MessageBox.Show("פרטי הספק עודכנו במערכת", "הפעולה הושלמה בהצלחה", MessageBoxButtons.OK);
                CrudSupplier backToCrud = new CrudSupplier(employeeID);
                backToCrud.Show();
                this.Hide();
            }
           
        }

        private void Form_updateSupplier_Load(object sender, EventArgs e)
        {

        }

        private void US_back_Click(object sender, EventArgs e)
        {
            Form_supplierProfile back = new Form_supplierProfile(supplier.get_SupplierNumber(), employeeID);
            back.Show();
            this.Hide();
        }
    }
}
