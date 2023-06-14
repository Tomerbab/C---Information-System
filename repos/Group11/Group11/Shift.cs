using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Group11
{
    public class Shift
    {
        private DateTime shiftDate;
        private ShiftType shiftType;
        private int numberOfEmployees;
        private List<Employee> EmployeesShift;
        private List<ShiftConstraint> ShiftConstraints;

        public Shift(DateTime ShiftDate, ShiftType shiftType, int num, bool is_new)
        {
            this.shiftDate = ShiftDate;
            this.shiftType = shiftType;
            this.numberOfEmployees = num;
            ShiftConstraints = new List<ShiftConstraint>();
            EmployeesShift = new List<Employee>();
            if (is_new)
            {
                this.create_Shift();
                Program.Shifts.Add(this); 

            }
        }
        // Getter for shiftDate
        public DateTime getShiftDate()
        {
            return shiftDate;
        }

        // Setter for shiftDate
        public void setShiftDate(DateTime shiftDate)
        {
            this.shiftDate = shiftDate;
            Update_Shift();
        }

        // Getter for shiftType
        public ShiftType getShiftType()
        {
            return shiftType;
        }

        // Setter for shiftType
        public void setShiftType(ShiftType shiftType)
        {
            this.shiftType = shiftType;
            Update_Shift();
        }

        // Getter for numberOfEmployees
        public int getNumberOfEmployees()
        {
            return numberOfEmployees;
        }

        // Setter for numberOfEmployees
        public void setNumberOfEmployees(int numberOfEmployees)
        {
            this.numberOfEmployees = numberOfEmployees;
            Update_Shift();
        }

        public void addEmployeeToShift(Employee e)  // add employee to the employees list
        {
            EmployeesShift.Add(e);
        }

        public List<Employee> getEmployees() // return employees list
        {
            return this.EmployeesShift;
        }

        public void addShiftConstraints(ShiftConstraint sc) // add ShiftConstraint to the ShiftConstraint list
        {
            if (sc.getShift().getShiftDate() == this.getShiftDate() && sc.getShift().getShiftType().ToString().Equals(this.getShiftType().ToString()))
                ShiftConstraints.Add(sc);
        }

        public List<ShiftConstraint> getShiftConstraints() // return the ShiftConstraint list
        {
            return this.ShiftConstraints;
        }

        public void create_Shift() // create a shift object and add to the dataBase
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Shift @shiftDate, @shiftType, @numberOfEmployees";
            string sqlFormattedDate = this.shiftDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            c.Parameters.AddWithValue("@ShiftDate", this.shiftDate);
            c.Parameters.AddWithValue("@shiftType", this.shiftType);
            c.Parameters.AddWithValue("@numberOfEmployees", this.numberOfEmployees);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void Update_Shift() // update a shift object in the dataBase
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Shift @shiftDate, @shiftType, @numberOfEmployees";
            string sqlFormattedDate = this.shiftDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            c.Parameters.AddWithValue("@shiftDate", sqlFormattedDate);
            c.Parameters.AddWithValue("@shiftType", this.shiftType.ToString());
            c.Parameters.AddWithValue("@numberOfEmployees", this.numberOfEmployees);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
