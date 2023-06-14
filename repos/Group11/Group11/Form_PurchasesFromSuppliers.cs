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
    public partial class Form_PurchasesFromSuppliers : Form
    {
        string employeeID;
        public Form_PurchasesFromSuppliers()
        {
            InitializeComponent();
        }
        public Form_PurchasesFromSuppliers(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }

        private void button_MakePurchase_Click(object sender, EventArgs e)
        {
            Form_supplierForPurchase cf = new Form_supplierForPurchase(employeeID);
            cf.Show();
            this.Hide();
        }

        private void button_PurchaseHistory_Click(object sender, EventArgs e)
        {
            Form_PurchasesHistory ph = new Form_PurchasesHistory(employeeID);
            ph.Show();
            this.Hide();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_employeeMain em = new Form_employeeMain(employeeID);
            em.Show();
            this.Hide();
        }
    }
}
