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
    public partial class Form_readSupplier : Form
    {
        private string employeeID;
        public Form_readSupplier()
        {
            InitializeComponent();
        }

        public Form_readSupplier(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }
        private void Form_readSupplier_Load(object sender, EventArgs e)
        {

        }



        private void button_SupplierSearch_Click(object sender, EventArgs e)
        {
            if (textBox_supplierIdSearch.Text == "")
            {
                MessageBox.Show("הכנס מספר ספק!");
            }
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            if (!readNumber.IsMatch(textBox_supplierIdSearch.Text))
            {
                MessageBox.Show("מספר ספק לא תקין!");
                return;

            }
            if (Program.checkSupplier(textBox_supplierIdSearch.Text))
            {
                Form_supplierProfile cp = new Form_supplierProfile(textBox_supplierIdSearch.Text, employeeID);
                cp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("הספק לא נמצא , הכנס מספר ספק תקין");
            }

        }

        private void button_backFromReadSupplier_Click(object sender, EventArgs e)
        {
            CrudSupplier back = new CrudSupplier(employeeID);
            back.Show();
            this.Hide();
        }
    }
}
