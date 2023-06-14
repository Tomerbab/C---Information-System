using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Group11
{
    public class ShiftConstraint
    {

        private Employee employee;
        private Shift shift;
        private string constraintReason;


        public ShiftConstraint(Employee employee, Shift shift, string constraintReason, bool is_new)
        {
            this.employee = employee;
            this.shift = shift;
            this.constraintReason = constraintReason;

            if (is_new)
            {
                this.create_ShiftConstraint();


            }
        }
        public Employee getEmployee()
        {
            return this.employee;
        }


        public void setEmployee(Employee employee)
        {
            this.employee = employee;
        }

        public Shift getShift()
        {
            return shift;
        }


        public void setShift(Shift shift)
        {
            this.shift = shift;
        }

        public string getConstraintReason()
        {
            return constraintReason;
        }
        public void setConstraintReason(string constraintReason)
        {
            this.constraintReason = constraintReason;
        }

        public void create_ShiftConstraint()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_ShiftConstraints @employee, @shiftDate, @shiftType, @constraintReason";
            c.Parameters.AddWithValue("@employee", this.employee.getID());
            string sqlFormattedDate = this.shift.getShiftDate().ToString("yyyy-MM-dd HH:mm:ss.fff");
            c.Parameters.AddWithValue("@ShiftDate", sqlFormattedDate);
            c.Parameters.AddWithValue("@shiftType", this.shift.getShiftType().ToString());
            c.Parameters.AddWithValue("@constraintReason", this.constraintReason);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}
