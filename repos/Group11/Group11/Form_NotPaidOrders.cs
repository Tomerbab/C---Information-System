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
    public partial class Form_NotPaidOrders : Form
    {
        private string customerID;
        
        public Form_NotPaidOrders(string customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
            DisplayOrders();
        }

        private void Form_NotPaidOrders_Load(object sender, EventArgs e)
        {

        }

        private void dataGridOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayOrders()
        {
            List<Order> orders = Program.Orders; // list of orders

            dataGridOrders.DataSource = null;
            dataGridOrders.Rows.Clear();

            foreach (Order order in orders)
            {
                if (order.getCustomer().get_customerID().Equals(this.customerID) && order.getPaymentID() == null) // מסנן לפי לקוח נוכחי
                {
                    dataGridOrders.Rows.Add(
                        order.getOrderNum(),
                        order.getPrice(),
                        order.getOrderDT(),
                        order.getOrderStatus(),
                        order.getCustomer().get_customerID());
                }

            }
        }

        private void buttonGoPay_Click(object sender, EventArgs e)
        {
            if (CheckOrderInput())
            {
                Form_addPayment ap = new Form_addPayment(this.customerID, textBox_PayOrderNum.Text); // מעבר למסך הבא עם מספר לקוח ומספר הזמנה
                ap.Show();
                this.Hide();
            }
        }

        private void textBox_PayOrderNum_TextChanged(object sender, EventArgs e)
        {

        }

        private Boolean CheckOrderInput() // בדיקת תקינות קלטים
        {
            if (!checkInDG(textBox_PayOrderNum.Text)|| textBox_PayOrderNum.Text == "")
            {
                MessageBox.Show("ההזמנה לא קיימת", "!שגיאה במספר הזמנה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool checkInDG(string text) // return true if the order belongs to the customer
        {
            foreach (DataGridViewRow row in dataGridOrders.Rows)
            {
                if (row.Cells[0].Value.ToString() == text)
                {
                    return true;
                }
            }
            return false;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form backToCustomer = new Form_CustomerMain(customerID);
            backToCustomer.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form backToCustomer = new Form_CustomerMain(customerID);
            backToCustomer.Show();
            this.Hide();
        }
    }
    }




      