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
    public partial class Form_chooseShift : Form
    {
        private String employeeID;
        public Form_chooseShift()
        {
            InitializeComponent();
            AddColumns();
            DisplayShifts();
        }

        public Form_chooseShift(String id)
        {
            employeeID= id;
            InitializeComponent();
            AddColumns();
            DisplayShifts();
        }

        private void Form_chooseShift_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.Shifts' table. You can move, or remove it, as needed.
           // this.shiftsTableAdapter.Fill(this.sAD_11DataSet.Shifts);

        }

        private void AddColumns()
        {
            // Set all other columns as read-only
            foreach (DataGridViewColumn column in dataGridView_futureShifts.Columns)
            {
                column.ReadOnly = true;
            }
          /*  if (dataGridView_futureShifts.Rows.Count <= 1)
            {
                dataGridView_futureShifts.ScrollBars = ScrollBars.None;
                dataGridView_futureShifts.DefaultCellStyle.ForeColor = dataGridView_futureShifts.DefaultCellStyle.BackColor;
            }*/
        }


        private void DisplayShifts()
        {
            List<Shift> shifts = Program.Shifts;

            dataGridView_futureShifts.DataSource = null;
            dataGridView_futureShifts.Rows.Clear();

            foreach (Shift shift in shifts)
            {
                DateTime shiftDate = shift.getShiftDate();
                if (shiftDate > DateTime.Today && !checkEmployeeShiftRelation(shift)) // display only future shifts and shift that the employee doesnt have constraint for them\not working in them
                {
                    dataGridView_futureShifts.Rows.Add(
                    shiftDate,
                    shift.getShiftType().ToString(),
                    shift.getNumberOfEmployees());

                }

            }
        }

        private Boolean checkEmployeeShiftRelation(Shift s)
        {
            Employee E = Program.seekEmployee(this.employeeID);
            if (E.checkShift(s) || E.checkShiftConstraint(s))
                return true;
            else
                return false;
        }

        private void dataGridView_futureShifts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView_futureShifts.Columns[e.ColumnIndex].Name == "Column_chooseShift")
                {
                    Employee employee = Program.seekEmployee(employeeID);
                    DateTime shiftDate = (DateTime)dataGridView_futureShifts.Rows[e.RowIndex].Cells[0].Value;
                    ShiftType shiftType = (ShiftType)Enum.Parse(typeof(ShiftType), dataGridView_futureShifts.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Shift shift = Program.seekShift(shiftDate, shiftType);

                    Form_newShiftConstraint f = new Form_newShiftConstraint(employee, shift);
                    f.Show();
                    this.Hide();
                }
        }

        private void button_backToEM_Click(object sender, EventArgs e)
        {
            Form_employeeMain em = new Form_employeeMain(this.employeeID);
            em.Show();
            this.Hide();
        }
    }
}
