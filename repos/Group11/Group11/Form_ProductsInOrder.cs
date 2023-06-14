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
    public partial class Form_ProductsInOrder : Form
    {
        string orderNum;
        string customerID;
        public Form_ProductsInOrder()
        {
            InitializeComponent();
            DisplayProducts();
        }
        public Form_ProductsInOrder(string orderNum, string customerID)
        {
            InitializeComponent();
            this.orderNum = orderNum;
            this.customerID = customerID;
            DisplayProducts();
        }

        private void Form_ProductsInOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.ProductsInOrders' table. You can move, or remove it, as needed.
           //this.productsInOrdersTableAdapter.Fill(this.sAD_11DataSet.ProductsInOrders);

        }

        private void DisplayProducts()
        {
            Order O = Program.seekOrder(this.orderNum);
            List<ProductsInOrders> ProductsInOrders = O.getProductsInOrders(); // list of products included in the order
            dataGrid_productsInOrder.DataSource = null;
            dataGrid_productsInOrder.Rows.Clear();

            foreach (ProductsInOrders ProductInOrder in ProductsInOrders)
            {
                    dataGrid_productsInOrder.Rows.Add(
                   ProductInOrder.getOrder().getOrderNum(),
                   ProductInOrder.getProduct().getSerialNumber(),
                   ProductInOrder.getQuantityInOrder(),
                   Program.seekProduct(ProductInOrder.getProduct().getSerialNumber()).getProductName());
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_OrdersHistory f = new Form_OrdersHistory(this.customerID);
            f.Show();
            this.Hide();
        }

        private void dataGrid_productsInOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

