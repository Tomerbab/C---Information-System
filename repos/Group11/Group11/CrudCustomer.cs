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
    public partial class CrudCustomer : Form
    {
        private string employeeID;
        public CrudCustomer()
        {
            InitializeComponent();
        }
        public CrudCustomer(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }

        private void readC_Click(object sender, EventArgs e)
        {
            Form_readCustomer f = new Form_readCustomer(employeeID);
            f.Show();
            this.Hide(); 
        }

        private void createCustomer_Click(object sender, EventArgs e)
        {
            Form_createCustomer f = new Form_createCustomer(employeeID);
            f.Show();
            this.Hide();
        }

        private void CrudCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button_CrudCustomer_back_Click(object sender, EventArgs e)
        {
            Form_employeeMain f = new Form_employeeMain(this.employeeID);
            f.Show();
            this.Hide();
        }
    }
}
