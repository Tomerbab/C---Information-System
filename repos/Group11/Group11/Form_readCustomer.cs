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
    public partial class Form_readCustomer : Form
    {
        private string employeeID;


        public Form_readCustomer()
        {
            InitializeComponent();
        }
        public Form_readCustomer(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_readCustomer_Load(object sender, EventArgs e)
        {

        }



        private void button_CustomerSearch_Click(object sender, EventArgs e)
        {
            if (textBox_customerIdSearch.Text == "")
            {
                MessageBox.Show("הכנס מספר לקוח !");
                return;

            }
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            if (!readNumber.IsMatch(textBox_customerIdSearch.Text))
            {
                MessageBox.Show("מספר לקוח לא תקין!");
                return;

            }

            if (Program.checkCustomer(textBox_customerIdSearch.Text))
            {
                Form_customerProfile cp = new Form_customerProfile(textBox_customerIdSearch.Text, employeeID);
                cp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("הלקוח לא נמצא , הכנס מספר לקוח תקין");
            }

        }

        private void textBox_customerSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrudCustomer back = new CrudCustomer(employeeID);
            back.Show();
            this.Hide();
        }
    }
}
