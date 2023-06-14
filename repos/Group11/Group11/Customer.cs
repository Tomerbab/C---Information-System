using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group11
{
    public class Customer
    {

        private string customerID;
        private string customerName;
        private string customerEmail;
        private string customerPhoneNumber;
        private string customerAddress;
        private string customerPassword;
        private List<Order> Orders;
        private List<Meeting> Meetings;

        public Customer(string customerID, string customerName, string customerEmail, string customerPhoneNumber, string customerAddress, string customerPassword, bool is_new)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.customerPhoneNumber = customerPhoneNumber;
            this.customerAddress = customerAddress;
            this.customerPassword = customerPassword;
            Meetings = new List<Meeting>();
            Orders = new List<Order>();
            if (is_new)
            {
                this.create_customer();
                Program.Customers.Add(this);

            }
        }

        public string get_customerID()
        {
            return this.customerID;
        }

        public string get_customerName()
        {
            return this.customerName;
        }

        public string get_customerEmail()
        {
            return this.customerEmail;
        }
        public string get_customerPhoneNumber()
        {
            return this.customerPhoneNumber;
        }
        public string get_customerAddress()
        {
            return this.customerAddress;
        }
        public string get_customerPassword()
        {
            return this.customerPassword;
        }

        public void set_customerID(string customerID)
        {
            this.customerID = customerID; 
        }
        public void set_customerName(string customerName)
        {
            this.customerName = customerName; 
        }
        public void set_customerEmail(string customerEmail)
        {
            this.customerEmail = customerEmail; 
        }
        public void set_customerPhoneNumber(string customerPhoneNumber)
        {
            this.customerPhoneNumber = customerPhoneNumber; 
        }
        public void set_customerAddress(string customerAddress)
        {
            this.customerAddress = customerAddress; 
        }
        public void set_customerPassword(string customerPassword)
        {
            this.customerPassword = customerPassword; 
        }
        public void addOrder(Order o) // add Order to the Orders list
        {
            if (this.get_customerID().Equals(o.getCustomer().get_customerID())) 
                Orders.Add(o);
        }

        public List<Order> getOrders() // return Orders list
        {
            return this.Orders;
        }
        public void addMeeting(Meeting m) // add Meeting to the Meetings list
        {
            if (this.get_customerID().Equals(m.getCustomer().get_customerID()))
                Meetings.Add(m);
        }

        public List<Meeting> getMeetings() // return Meetings list
        {
            return this.Meetings;
        }
        public void create_customer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Customer @customerID, @customerName, @customerEmail, @customerPhoneNumber, @customerAddress, @customerPassword";
            c.Parameters.AddWithValue("@customerID", this.customerID);
            c.Parameters.AddWithValue("@customerName", this.customerName);
            c.Parameters.AddWithValue("@customerEmail", this.customerEmail);
            c.Parameters.AddWithValue("@customerPhoneNumber", this.customerPhoneNumber);
            c.Parameters.AddWithValue("@customerAddress", this.customerAddress);
            c.Parameters.AddWithValue("@customerPassword", this.customerPassword);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_customer()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Customer @customerID, @customerEmail, @customerPhoneNumber, @customerAddress, @customerPassword";
            c.Parameters.AddWithValue("@customerID", this.customerID);
            c.Parameters.AddWithValue("@customerEmail", this.customerEmail);
            c.Parameters.AddWithValue("@customerPhoneNumber", this.customerPhoneNumber);
            c.Parameters.AddWithValue("@customerAddress", this.customerAddress);
            c.Parameters.AddWithValue("@customerPassword", this.customerPassword);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}
