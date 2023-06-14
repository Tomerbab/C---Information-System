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
    public partial class Form_ShiftArrangement : Form
    {
        private string employeeID;
        public Form_ShiftArrangement()
        {
            InitializeComponent();
            AddColumns();
            DisplayShifts();

        }
        public Form_ShiftArrangement(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
            AddColumns();
            DisplayShifts();

        }

        private void Form_ShiftArrangement_Load(object sender, EventArgs e)
        {

        }



        private void AddColumns()
        {
            // Set all other columns as read-only
            foreach (DataGridViewColumn column in dataGridShifts.Columns)
            {
                    column.ReadOnly = true;
            }
        }


        private void DisplayShifts()
        {
            List<Shift> shifts = Program.Shifts;

            dataGridShifts.DataSource = null;
            dataGridShifts.Rows.Clear();

            foreach (Shift shift in shifts)
            {
                DateTime shiftDate = shift.getShiftDate();
                if (shiftDate > DateTime.Today) // display only future shifts
                {
                    dataGridShifts.Rows.Add(
                    shiftDate,
                    shift.getShiftType().ToString(),
                    shift.getNumberOfEmployees());

                    }

                }
            }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) // display the option to select a shift and move forward with it
         {
            DateTime shiftDate = (DateTime)dataGridShifts.Rows[e.RowIndex].Cells[0].Value;
            ShiftType shiftType = (ShiftType)Enum.Parse(typeof(ShiftType), dataGridShifts.Rows[e.RowIndex].Cells[1].Value.ToString());
            Shift shift = Program.seekShift(shiftDate, shiftType);
            Form_chooseEmployeesForShift f = new Form_chooseEmployeesForShift(shift, employeeID);
            f.Show();
            this.Hide();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_employeeMain f = new Form_employeeMain(this.employeeID);
            f.Show();
            this.Hide();
        }
    }
}
