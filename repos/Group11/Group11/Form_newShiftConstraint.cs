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
    public partial class Form_newShiftConstraint : Form
    {
        private Employee employee;
        private Shift shift;
        public Form_newShiftConstraint()
        {
            InitializeComponent();
        }

        public Form_newShiftConstraint(Employee e, Shift s)
        {
            InitializeComponent();
            employee = e;
            shift = s;
            label_newSC_date.Text = shift.getShiftDate().ToString();
            label_newSC_type.Text = shift.getShiftType().ToString();
        }

        private void Form_newShiftConstraint_Load(object sender, EventArgs e)
        {

        }

        private void button_addShiftConstraint_Click(object sender, EventArgs e)
        {
            if (textBox_newSC_reason.Text.Equals(""))
            {
                MessageBox.Show("נא להזין סיבה", "!שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ShiftConstraint sc = new ShiftConstraint(employee, shift, textBox_newSC_reason.Text, true);
                this.employee.addShiftConstraints(sc); // adding the shiftConstraint into the employee shiftConstraints list
                this.shift.addShiftConstraints(sc);// adding the shiftConstraint into the shift shiftConstraints list
                MessageBox.Show("האילוץ נוסף בהצלחה", "הפעולה הושלמה", MessageBoxButtons.OK);
                Form_employeeMain backToEmployeeMain = new Form_employeeMain(employee.getID());
                backToEmployeeMain.Show();
                this.Hide();
            }
        }

        private void textBox_newSC_reason_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChooseShift_Click(object sender, EventArgs e)
        {
            Form_chooseShift cs = new Form_chooseShift(this.employee.getID());
            cs.Show();
            this.Hide();
        }
    }
}

