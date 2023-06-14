using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Group11
{
    public class Employee
    {
        private string employeeID;
        private string employeeName;
        private DateTime employeeBirthDate;
        private string employeeEmail;
        private string employeePhoneNumber;
        private string employeeAddress;
        private DateTime employeeStartDate;
        private double employeeHourlySalary;
        private Boolean employeeStatus;
        private string employeePassword;
        private Type employeeType;
        private List<Shift> shifts;
        private List<ShiftConstraint> ShiftConstraints;
        private List<Meeting> Meetings;
        private List<Purchase> Purchases;

        public Employee(string id, string name, DateTime birthDate, string email, string phone, string address, DateTime startDate, double salary,
                        Boolean status, string password, Type type, bool is_new)
        {
            this.employeeID = id;
            this.employeeName = name;
            this.employeeBirthDate = birthDate;
            this.employeeEmail = email;
            this.employeePhoneNumber = phone;
            this.employeeAddress = address;
            this.employeeStartDate = startDate;
            this.employeeHourlySalary = salary;
            this.employeeStatus = status;
            this.employeePassword = password;
            this.employeeType = type;
            shifts = new List<Shift>();
            ShiftConstraints = new List<ShiftConstraint>();
            Meetings = new List<Meeting>();
            Purchases = new List<Purchase>();
            if (is_new)
            {
                this.create_employee();
                Program.Employees.Add(this);

            }

        }


        public string getID()
        {
            return this.employeeID;
        }
        public string get_name()
        {
            return this.employeeName;
        }
        public DateTime get_employeeBirthDate()
         {
            return this.employeeBirthDate;
          }

        public string getEmail()
        {
            return this.employeeEmail;
        }
        public string getPhone()
        {
            return this.employeePhoneNumber;
        }
        public string getPassword()
        {
            return this.employeePassword;
        }
        public string getAddress()
        {
            return this.employeeAddress;
        }
        public DateTime getStartDate()
        {
            return this.employeeStartDate;
        }
        public double getSalary()
        {
            return this.employeeHourlySalary;
        }
        public Boolean getstatus()
        {
            return this.employeeStatus;
        }
        public Type get_type()
        {
            return this.employeeType;
        }


        public void set_ID(string ID)
        {
            this.employeeID = ID; 
        }
        public void set_name(string name)
        {
            this.employeeName = name; 
        }

        public void set_birthDate(DateTime birthDate)
        {
            this.employeeBirthDate = birthDate;
        }
        public void set_email(string email)
        {
            this.employeeEmail = email; 
        }
        public void set_phone(string phone)
        {
            this.employeePhoneNumber = phone; 
        }
        public void set_address(string address)
        {
            this.employeeAddress = address; 
        }
        public void set_startDate(DateTime date)
        {
            this.employeeStartDate = date; 
        }
        public void set_salary(double salary)
        {
            this.employeeHourlySalary = salary; 
        }
        public void set_status(Boolean status)
        {
            this.employeeStatus = status; 
        }
        public void set_password(string password)
        {
            this.employeePassword = password; 
        }
        public void set_type(Type type)
        {
            this.employeeType = type; 
        }

        public void addShiftToEmployee(Shift s) // add shift to the shifts list
        {
            this.shifts.Add(s);
        }

        public List<Shift> getShifts() // return shifts list
        {
            return this.shifts;
        }

        public bool checkShift(Shift s) // check if a shift is exist in the shifts list
        {
            foreach (Shift shift in shifts)
            {
                if (s == shift)
                {
                    return true;
                }
            }
            return false;
        }

        public bool checkShiftConstraint(Shift s) // check if a ShiftConstraint is exist in the ShiftConstraint list
        {
            foreach (ShiftConstraint sc in ShiftConstraints)
            {
                if (sc.getShift().getShiftDate() == s.getShiftDate() && sc.getShift().getShiftType().ToString().Equals(s.getShiftType().ToString())) // if the shift s have the same date and type like a shift in the shiftConstraints list
                {
                    return true;
                }
            }
            return false;
        }

        public void addShiftConstraints(ShiftConstraint sc) // add ShiftConstraint to the shifts list
        {
            if (this.getID().Equals(sc.getEmployee().getID()))
                ShiftConstraints.Add(sc);
        }

        public List<ShiftConstraint> getShiftConstraints() // return ShiftConstraint list
        {
            return this.ShiftConstraints;
        }

        public void addMeeting(Meeting m) // add Meeting to the Meetings list
        {
            if (this.getID().Equals(m.getEmployee().getID()))
                Meetings.Add(m);
        }

        public List<Meeting> getMeetings() // return Meetings list
        {
            return this.Meetings;
        }

        public void addPurchase(Purchase P) // add Purchase to the Purchases list
        {
            if (this.getID().Equals(P.getEmployee().getID()))
                Purchases.Add(P);
        }

        public List<Purchase> getPurchase() // return Purchase list
        {
            return this.Purchases;
        }

     
        public void create_employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Employee @id, @name,@birthDate, @email, @phone, @address, @startDate, @salary, @status, @password, @type";
            c.Parameters.AddWithValue("@id", this.employeeID);
            c.Parameters.AddWithValue("@name", this.employeeName);
            string sqlFormattedDate = this.employeeBirthDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            c.Parameters.AddWithValue("@birthDate", sqlFormattedDate);
            c.Parameters.AddWithValue("@email", this.employeeEmail);
            c.Parameters.AddWithValue("@phone", this.employeePhoneNumber);
            c.Parameters.AddWithValue("@address", this.employeeAddress);
            string sqlFormattedDateStart = this.employeeBirthDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            c.Parameters.AddWithValue("@startDate", sqlFormattedDateStart);
            c.Parameters.AddWithValue("@salary", this.employeeHourlySalary.ToString());
            c.Parameters.AddWithValue("@password", this.employeePassword);
            c.Parameters.AddWithValue("@status", this.employeeStatus);
            c.Parameters.AddWithValue("@type", this.employeeType.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_employee()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Employee @employeeID, @employeeEmail, @employeePhoneNumber, @employeeAddress, @employeeStartDate, @employeeHourlySalary, @employeeStatus, @employeePassword, @employeeType";
            c.Parameters.AddWithValue("@employeeID", this.employeeID);
            c.Parameters.AddWithValue("@employeeEmail", this.employeeEmail);
            c.Parameters.AddWithValue("@employeePhoneNumber", this.employeePhoneNumber);
            c.Parameters.AddWithValue("@employeeAddress", this.employeeAddress);
            c.Parameters.AddWithValue("@employeeStartDate", this.employeeStartDate.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            c.Parameters.AddWithValue("@employeeHourlySalary", this.employeeHourlySalary);
            c.Parameters.AddWithValue("@employeeStatus", this.employeeStatus);
            c.Parameters.AddWithValue("@employeePassword", this.employeePassword);
            c.Parameters.AddWithValue("@employeeType", this.employeeType.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
