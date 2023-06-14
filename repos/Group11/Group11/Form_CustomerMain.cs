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
    public partial class Form_CustomerMain : Form
    {
       private string id;
        public Form_CustomerMain(string id)
        {
            this.id = id;
            InitializeComponent();
            Customer C = Program.seekCustomer(this.id);
            labelName.Text = C.get_customerName();
            WhichTimeIsIt();

        }

        private void button_payForOrders_Click(object sender, EventArgs e)
        {
           Form_NotPaidOrders npo = new Form_NotPaidOrders(this.id);
            npo.Show();
            this.Hide();
        }

        private void Form_CustomerMain_Load(object sender, EventArgs e)
        {

        }
        public void WhichTimeIsIt()
        {
            DateTime now = DateTime.Now;
            DateTime startTime = DateTime.Today.AddHours(6); // 6 AM
            DateTime noonTime = DateTime.Today.AddHours(12); // 12 PM
            DateTime eveningTime = DateTime.Today.AddHours(18); // 6 PM
            DateTime nightTime = DateTime.Today.AddHours(24); // 12 AM

            if (now >= startTime && now <= noonTime)
            {
                labelHello.Text = "בוקר בנעימים";
            }
            if (now >= noonTime && now <= eveningTime)
            {
                labelHello.Text = "צהריים שקטים";
            }
            if (now >= eveningTime && now <= nightTime)
            {
                labelHello.Text = "ערב רגוע";
            }
            if (now >= nightTime && now <= startTime)
            {
                labelHello.Text = "לילה קסום";
            }
        }
        private void button_ordersHistory_Click(object sender, EventArgs e)
        {
            Form_OrdersHistory npo = new Form_OrdersHistory(this.id);
            npo.Show();
            this.Hide();
        }

        private void CM_back_Click(object sender, EventArgs e)
        {
            Form_customerLogin backToLogin = new Form_customerLogin();
            backToLogin.Show();
            this.Hide();
        }

        private void button_scheduleMeeting(object sender, EventArgs e)
        {
            Form_ScheduleMeeting sm = new Form_ScheduleMeeting(this.id);
            sm.Show();
            this.Hide();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

