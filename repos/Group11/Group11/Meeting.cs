using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group11
{
   public class Meeting
    {
        private DateTime meetingDT;
        private Employee employee;
        private Customer customer;
        private string location;
        private string meetingSummery;
        private List<Order> Orders;

        public Meeting(DateTime meetingDT, Employee employee, Customer customer, string location, string meetingSummery, bool is_new)
        {
            this.meetingDT = meetingDT;
            this.employee = employee;
            this.customer = customer;
            this.location = location;
            this.meetingSummery = meetingSummery;
            Orders = new List<Order>();
            Customer C = Program.seekCustomer(this.customer.get_customerID());
            C.addMeeting(this);
            Employee E = Program.seekEmployee(this.employee.getID());
            E.addMeeting(this);
            if (is_new)
            {
                this.create_meeting();
                Program.Meetings.Add(this);
            }
        }


        public DateTime getMeetingDT()
        {
            return this.meetingDT;
        }
        public Employee getEmployee()
        {
            return this.employee;
        }
        public Customer getCustomer()
        {
            return this.customer;
        }
        public string getLocation()
        {
            return this.location;
        }
        public string getMeetingSummery()
        {
            return this.meetingSummery;
        }

        public void setMeetingDT(DateTime meetingDT)
        {
            this.meetingDT = meetingDT;
        }
        public void setEmployee(Employee employee)
        {
            this.employee = employee;
        }
        public void setCustomer(Customer customer)
        {
            this.customer = customer;
        }

        public void setLocation(string location)
        {
            this.location = location;
        }
        public void setMeetingSummery(string meetingSummery)
        {
            this.meetingSummery = meetingSummery;
        }

        public void addOrder(Order o) // add order to the orders list
        {
                Orders.Add(o);
        }

        public List<Order> getOrders() // return the orders list
        {
            return this.Orders;
        }

        

        public void create_meeting()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Meeting @meetingDT, @employee, @customer, @location, @meetingSummery";
            c.Parameters.AddWithValue("@meetingDT", this.meetingDT.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            c.Parameters.AddWithValue("@employee", this.employee.getID());
            c.Parameters.AddWithValue("@customer", this.customer.get_customerID());
            c.Parameters.AddWithValue("@location", this.location);
            c.Parameters.AddWithValue("@meetingSummery", string.IsNullOrEmpty(this.meetingSummery) ? DBNull.Value : (object)this.meetingSummery);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
    }