using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Group11
{
    public partial class Form_employeeMain : Form
    {
        String employeeID;

        public Form_employeeMain()
        {
            InitializeComponent();
        }

        public Form_employeeMain(String id)
        {
            InitializeComponent();
            employeeID = id;
            Employee E = Program.seekEmployee(this.employeeID);
            labelName.Text = E.get_name();
            WhichTimeIsIt();
        }

        private void HomePage_Load(object sender, EventArgs e)
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
        private bool isUserManager()
        {
            Employee emp = Program.seekEmployee(this.employeeID);
                if ( emp.get_type().ToString().Equals("manager"))
                    return true;
            
            return false;
        }

        private void button_crudSupplier(object sender, EventArgs e)
        {
            if (!isUserManager())
            {
                MessageBox.Show("אין לך הרשאה לבצע פעולה זו", "גישה נדחתה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CrudSupplier back = new CrudSupplier(this.employeeID);
            back.Show();
            this.Hide();
        }

        private void button_crudCustomer_Click(object sender, EventArgs e)
        {
            if (!isUserManager())
            {
                MessageBox.Show("אין לך הרשאה לבצע פעולה זו", "גישה נדחתה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CrudCustomer back = new CrudCustomer(this.employeeID);
            back.Show();
            this.Hide();
        }

        private void button_crudEmployee_Click(object sender, EventArgs e)
        {

            if (!isUserManager())
            {
                MessageBox.Show("אין לך הרשאה לבצע פעולה זו", "גישה נדחתה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CrudEmployee back = new CrudEmployee(this.employeeID);
            back.Show();
            this.Hide();
        }

        private void button_crudProduct_Click(object sender, EventArgs e)
        {
            if (!isUserManager())
            {
                MessageBox.Show("אין לך הרשאה לבצע פעולה זו", "גישה נדחתה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CrudProduct back = new CrudProduct(this.employeeID);
            back.Show();
            this.Hide();
        }


        private void button_addShiftConstraint_Click(object sender, EventArgs e)
        {
            Form_chooseShift cs = new Form_chooseShift(employeeID);
            cs.Show();
            this.Hide();
        }

        private void button_shiftArrangement_Click(object sender, EventArgs e)
        {
            if (!isUserManager())
            {
                MessageBox.Show("אין לך הרשאה לבצע פעולה זו", "גישה נדחתה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form_ShiftArrangement cs = new Form_ShiftArrangement(this.employeeID);
            cs.Show();
            this.Hide();
        }

        private void button_newPurchase_Click(object sender, EventArgs e)
        {
            if (!isUserManager() || !isUserAssistant())
            {
                MessageBox.Show("אין לך הרשאה לבצע פעולה זו", "גישה נדחתה", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form_PurchasesFromSuppliers cf = new Form_PurchasesFromSuppliers(employeeID);
            cf.Show();
            this.Hide();
        }

        private bool isUserAssistant()
        {
            Employee emp = Program.seekEmployee(this.employeeID);
            if (emp.get_type().ToString().Equals("manager") || emp.get_type().ToString().Equals("sewing manager"))
                    return true;
            return false;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Form_employeeLogin el = new Form_employeeLogin();
            el.Show();
            this.Hide();
        }

        private void buttonGoToCalculate_Click(object sender, EventArgs e)
        {
            Form_ChooseFabricForOrder cf = new Form_ChooseFabricForOrder("0", employeeID);
            cf.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
