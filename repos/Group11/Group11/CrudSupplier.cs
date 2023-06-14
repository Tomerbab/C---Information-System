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
    public partial class CrudSupplier : Form
    {
        private string employeeID;
        public CrudSupplier()
        {
            InitializeComponent();
        }
        public CrudSupplier(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }


        private void createSupplier_Click(object sender, EventArgs e)
        {
            Form_createSupplier f = new Form_createSupplier(employeeID);
            f.Show();
            this.Hide();
            
        }

        private void readSupplier_Click(object sender, EventArgs e)
        {
            Form_readSupplier f = new Form_readSupplier(employeeID);
            f.Show();
            this.Hide();
        }
        private void CrudSupplier_Load(object sender, EventArgs e)
        {

        }

        private void button_CrudSupplier_back_Click(object sender, EventArgs e)
        {
            Form_employeeMain f = new Form_employeeMain(this.employeeID);
            f.Show();
            this.Hide();
        }
    }
}
