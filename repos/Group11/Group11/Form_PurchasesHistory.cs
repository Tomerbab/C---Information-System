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
    public partial class Form_PurchasesHistory : Form
    {
        string employeeID;
        public Form_PurchasesHistory()
        {
            InitializeComponent();
        }
        public Form_PurchasesHistory(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }

        private void Form_PurchasesHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.Purchases' table. You can move, or remove it, as needed.
            this.purchasesTableAdapter.Fill(this.sAD_11DataSet.Purchases);

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_PurchasesFromSuppliers cf = new Form_PurchasesFromSuppliers(employeeID);
            cf.Show();
            this.Hide();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView_PurchasesHistory.CurrentRow != null) // Check if a valid row is double-clicked
            {

                DataGridViewRow selectedRow = dataGridView_PurchasesHistory.CurrentRow; // Get the data from the selected row

                string purchaseNumber = selectedRow.Cells[0].Value.ToString();
                Form_ProductsInPurchasesHistory ph = new Form_ProductsInPurchasesHistory(employeeID, purchaseNumber);
                ph.Show();
                this.Hide();
            }
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
