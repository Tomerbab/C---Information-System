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
    public partial class Form_readProduct : Form
    {
        private string employeeID;

        public Form_readProduct()
        {
            InitializeComponent();
        }

        public Form_readProduct(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }

        public bool checkProduct(string serialNumber)
        {
            if (Program.seekProduct(serialNumber) != null)
            {
                return true;
            }

            return false;
        }
        private void button_ProductSearch_Click(object sender, EventArgs e)
        {
            if (textBox_productSerialNumberSearch.Text == "")
            {
                MessageBox.Show("הכנס מספר מוצר");
                return;
            }
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            if (!readNumber.IsMatch(textBox_productSerialNumberSearch.Text))
            {
                MessageBox.Show("מספר מוצר לא תקין!");
                return;

            }
            if (checkProduct(textBox_productSerialNumberSearch.Text))
            {
                Form_productProfile cp = new Form_productProfile(textBox_productSerialNumberSearch.Text, employeeID);
                cp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("המוצר לא נמצא , הכנס מספר מוצר תקין");
            }

        }

        private void Form_readProduct_Load(object sender, EventArgs e)
        {

        }

        private void button_backFromReadProduct_Click(object sender, EventArgs e)
        {
            CrudProduct back = new CrudProduct(employeeID);
            back.Show();
            this.Hide();
        }
    }
}
