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
    public partial class Form_ProductsInPurchasesHistory : Form
    {
        string employeeID;
        string purchaseNumber;
        public Form_ProductsInPurchasesHistory()
        {
            InitializeComponent();
            DisplayProducts();
        }
        public Form_ProductsInPurchasesHistory(string employeeID, string purchaseNumber)
        {
            this.employeeID = employeeID;
            this.purchaseNumber = purchaseNumber;
            InitializeComponent();
            DisplayProducts();
        }

        private void Form_ProductsInPurchasesHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.ProductsInPurchase' table. You can move, or remove it, as needed.
           // this.productsInPurchaseTableAdapter.Fill(this.sAD_11DataSet.ProductsInPurchase);

        }
        private void DisplayProducts()
        {
            Purchase P = Program.seekPurchase(this.purchaseNumber);
            List<ProductsInPurchase> ProductsInPurchaseS = P.getProductsInPurchase(); // list of products included in the purchase
            dataGridView_ProductsInPurchase.DataSource = null;
            dataGridView_ProductsInPurchase.Rows.Clear();

            foreach (ProductsInPurchase ProductsInPurchase in ProductsInPurchaseS)
            {
                dataGridView_ProductsInPurchase.Rows.Add(
               ProductsInPurchase.getPurchase().getPurchaseNumber(),
               ProductsInPurchase.getProduct().getSerialNumber(),
               ProductsInPurchase.getQuantityInPurchase(),
               Program.seekProduct(ProductsInPurchase.getProduct().getSerialNumber()).getProductName());
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_PurchasesFromSuppliers cf = new Form_PurchasesFromSuppliers(employeeID);
            cf.Show();
            this.Hide();
        }
    }
}
