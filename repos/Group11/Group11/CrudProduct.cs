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
    public partial class CrudProduct : Form
    {
        private string employeeID;
        public CrudProduct()
        {
            InitializeComponent();
        }
        public CrudProduct(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }

        private void readProduct_Click(object sender, EventArgs e)
        {
            Form_readProduct f = new Form_readProduct(employeeID);
            f.Show();
            this.Hide();
        }

        private void createProduct_Click(object sender, EventArgs e)
        {
            Form_createProduct f = new Form_createProduct(employeeID);
            f.Show();
            this.Hide();
        }

        private void button_CrudProduct_back_Click(object sender, EventArgs e)
        {
            Form_employeeMain f = new Form_employeeMain(this.employeeID);
            f.Show();
            this.Hide();
        }

        private void CrudProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
