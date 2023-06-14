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
    public partial class Form_OrdersHistory : Form
    {
        private string customerID;
        public Form_OrdersHistory(string customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
            DisplayOrders();
        }

        private void Form_OrdersHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet1.Orders' table. You can move, or remove it, as needed.
           // this.ordersTableAdapter1.Fill(this.sAD_11DataSet1.Orders);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayOrders()
        {
            List<Order> orders = Program.Orders; // list of orders

            dataGridOrdersHistory.DataSource = null;
            dataGridOrdersHistory.Rows.Clear();

            foreach (Order order in orders)
            {
                if (order.getCustomer().get_customerID().Equals(this.customerID)) // מסנן לפי לקוח נוכחי
                {
                    dataGridOrdersHistory.Rows.Add(
                        order.getOrderNum(),
                        order.getPrice(),
                        order.getOrderDT(),
                        order.getOrderStatus(),
                        order.getCustomer().get_customerID(),
                        order.getPaymentID());
                }

            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form backToCustomer = new Form_CustomerMain(customerID);
            backToCustomer.Show();
            this.Hide();
        }

        private void dataGridOrdersHistory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridOrdersHistory.CurrentRow != null) // Check if a valid row is double-clicked
            {

                DataGridViewRow selectedRow = dataGridOrdersHistory.CurrentRow; // Get the data from the selected row

                string orderNum = selectedRow.Cells[0].Value.ToString();
                Form_ProductsInOrder cop = new Form_ProductsInOrder(orderNum, customerID);
                cop.Show();
                this.Hide();
            }
        }
    }
}
