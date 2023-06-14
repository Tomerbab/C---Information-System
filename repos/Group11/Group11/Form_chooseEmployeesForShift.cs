using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Group11
{
    public partial class Form_chooseEmployeesForShift : Form
    {
        private Shift shift;
        private string employeeID;
        public Form_chooseEmployeesForShift()
        {
            InitializeComponent();
        }

        public Form_chooseEmployeesForShift(Shift s ,string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.shift = s;
            AddColumns();
            DisplayEmployees();

        }


        private void Form_chooseEmployeesForShift_Load(object sender, EventArgs e)
        {
        }

        private void button_arrangementShift_Click(object sender, EventArgs e)
        {
            if (checkBoxes())
            {
                for (int i = dataGridView_employeesForShift.RowCount - 1; i >= 0; i--)
                {
                    DataGridViewRow row = dataGridView_employeesForShift.Rows[i];
                    if (Convert.ToBoolean(row.Cells["addToShift"].Value))
                    {
                        string firstColumnValue = row.Cells[0].Value.ToString();
                        Employee employee = Program.seekEmployee(firstColumnValue);
                        SqlCommand c = new SqlCommand();
                        c.CommandText = "EXECUTE dbo.SP_add_ShiftWorkers @employeeID, @shiftDate, @shiftType";
                        c.Parameters.AddWithValue("@employeeID", firstColumnValue);
                        string sqlFormattedDate = this.shift.getShiftDate().ToString("yyyy-MM-dd HH:mm:ss.fff");
                        c.Parameters.AddWithValue("@shiftDate", sqlFormattedDate);
                        string Type = this.shift.getShiftType().ToString();
                        c.Parameters.AddWithValue("@shiftType", Type);
                        SQL_CON SC = new SQL_CON();
                        SC.execute_non_query(c);
                        shift.setNumberOfEmployees(shift.getNumberOfEmployees() + 1); // number of employees in a shift increase by one 
                        shift.addEmployeeToShift(employee); // adding employee to the shift list
                        employee.addShiftToEmployee(shift); // adding shift to the employee list
                        MessageBox.Show(" עובד " + firstColumnValue + " נוסף בהצלחה למשמרת ");
                    }
                }
                Form_ShiftArrangement ShiftArrangement = new Form_ShiftArrangement(employeeID);
                ShiftArrangement.Show();
                this.Hide();
            }
        }

        private bool checkBoxes()
        {
            foreach (DataGridViewRow row in dataGridView_employeesForShift.Rows) // run over the rows in datagrid
            {

                DataGridViewCheckBoxCell checkboxCell = row.Cells["addToShift"] as DataGridViewCheckBoxCell; //if the checkbox is checked
                if (Convert.ToBoolean(checkboxCell.Value) == true)
                {
                    return true;
                }
            }
            MessageBox.Show(" יש לבחור עובד", "בחירת עובד", MessageBoxButtons.OK);
            return false;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_ShiftArrangement ShiftArrangement = new Form_ShiftArrangement(employeeID);
            ShiftArrangement.Show();
            this.Hide();
        }

        
        private void AddColumns()
        {
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Select";
            checkboxColumn.Name = "addToShift";
            dataGridView_employeesForShift.Columns.Add(checkboxColumn);

            dataGridView_employeesForShift.Columns["addToShift"].ReadOnly = false;

            // Set all other columns as read-only
            foreach (DataGridViewColumn column in dataGridView_employeesForShift.Columns)
            {
                if (column.Name != "addToShift")
                {
                    column.ReadOnly = true;
                }
            }
        }
        

        private void DisplayEmployees()
        {
            List<Employee> employees = Program.Employees; 

            dataGridView_employeesForShift.DataSource = null;
            dataGridView_employeesForShift.Rows.Clear();

            foreach (Employee employee in employees)
            {
                if (!employee.checkShiftConstraint(shift) && !employee.checkShift(shift))// display only employees that is not working in this shift and dont have constraint for the shift
                {
                    dataGridView_employeesForShift.Rows.Add(
                    employee.getID(),
                    employee.get_name(),
                    employee.get_employeeBirthDate(),
                    employee.getEmail(),
                    employee.getPhone(),
                    employee.getAddress(),
                    employee.getStartDate(),
                    employee.getSalary(),
                    employee.getstatus(),
                    employee.getPassword(),
                    employee.get_type().ToString());

                }

            }
        }

        private void button_displayEmployees_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_employeesForShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

