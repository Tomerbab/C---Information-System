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
    public partial class Form_customerProfile : Form
    {
        private Customer customer;
        private string employeeID;

        public Form_customerProfile()
        {
            InitializeComponent();
        }
        


        public Form_customerProfile(string ID,string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            customer = Program.seekCustomer(ID);
            CP_ID.Text = customer.get_customerID();
            CP_Name.Text = customer.get_customerName();
            CP_Email.Text = customer.get_customerEmail();
            CP_PhoneNumber.Text = customer.get_customerPhoneNumber();
            CP_address.Text = customer.get_customerAddress();
            CP_password.Text = customer.get_customerPassword();

        }

        private void Form_customerProfile_Load(object sender, EventArgs e)
        {

        }

        private void CP_customerID_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_readCustomer back = new Form_readCustomer(employeeID);
            back.Show();
            this.Hide();
        }

        private void button_CP_updateCustomer_Click(object sender, EventArgs e)
        {
           Form_updateCustomer update = new Form_updateCustomer(customer.get_customerID(), employeeID);
            update.Show();
            this.Hide();
        }
    }
}
