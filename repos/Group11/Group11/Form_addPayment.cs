using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Group11
{
    public partial class Form_addPayment : Form
    {
        private string orderID;
        private string customerID;
        public Form_addPayment()
        {
            InitializeComponent();
        }

        public Form_addPayment(string customerID, string orderID)
        {
            this.customerID = customerID;
            this.orderID = orderID;
            InitializeComponent();
            PaymentLabel.Text = Program.seekOrder(orderID).getPrice().ToString();
            dateTimePicker_expDate.MinDate = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label_paymentType_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_choosePaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_addPayment_Click(object sender, EventArgs e)
        {

        }



        private void button_addPayment_Click(object sender, EventArgs e)
        {
            if (CheckPaymentInput())
            {
                Payment p = new Payment(Convert.ToString(Program.Payments.Count + 1), textBox_ownerName.Text, textBox_cardNum.Text, dateTimePicker_expDate.Value, textBox_cvv.Text, Double.Parse(PaymentLabel.Text), true);
                Order order = Program.seekOrder(this.orderID);
                Customer c = Program.seekCustomer(this.customerID);
                order.setPaymentID(p.getPaymentID());  // udpdate the payment id in order details
                MessageBox.Show(" !תשלום בוצע בהצלחה");

                string subject = "Dear Customer, Payment Successful";
                string body = "Dear Customer," +
                              "\nThank you for your payment." +
                              "\nThe total amount of your payment is: " + PaymentLabel.Text + "ILS" +
                              "\nWe appreciate your choice to do business with us." +
                              "\nAdi Zak Studio";
                Program.sendEmail(subject, body, c.get_customerEmail());
                Form backToCustomer = new Form_CustomerMain(customerID);
                backToCustomer.Show();
                this.Hide();

            }
        }


        private bool CheckPaymentInput()
        {
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            if (textBox_ownerName.Text.Equals(""))
            {
                MessageBox.Show("שם בעל הכרטיס שהוזן לא תקין", "!שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBox_cardNum.Text.Equals("") || textBox_cardNum.Text.Length != 16 || !readNumber.IsMatch(textBox_cardNum.Text))
            {
                MessageBox.Show("מספר הכרטיס שהוזן לא תקין", "!שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (textBox_cvv.Text.Equals("") || textBox_cvv.Text.Length != 3 || !readNumber.IsMatch(textBox_cvv.Text))
            {
                MessageBox.Show("יש להקיש שלוש ספרות", "!שגיאה ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void Form_addPayment_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ownerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Form_NotPaidOrders np = new Form_NotPaidOrders(this.customerID);
            np.Show();
            this.Hide();
        }
    }
}
