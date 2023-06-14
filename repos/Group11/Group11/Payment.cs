using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Group11
{
    public class Payment
    {
        private string paymentID;
        private string ownerName;
        private string creditCardNumber;
        private DateTime expirationDate;
        private string cvv;
        private double amount;

        public Payment(string paymentID, string ownerName, string creditCardNumber, DateTime expirationDate, string cvv, double amount, bool is_new)
        {
            this.paymentID = paymentID;
            this.ownerName = ownerName;
            this.creditCardNumber = creditCardNumber;
            this.expirationDate = expirationDate;
            this.cvv = cvv;
            this.amount = amount;
            if (is_new)
            {
                this.create_payment();
                Program.Payments.Add(this);

            }
        }


        public string getPaymentID()
        {
            return this.paymentID;
        }
        public string getOwnerName()
        {
            return this.ownerName;
        }
        public string getCreditCardNumber()
        {
            return this.creditCardNumber;
        }
        public DateTime getExpirationDate()
        {
            return this.expirationDate;
        }
        public string getcvv()
        {
            return this.cvv;
        }
        public double getAmount()
        {
            return this.amount;
        }
        public void set_paymentID(string paymentID)
        {
            this.paymentID = paymentID;
        }
        public void set_ownerName(string ownerName)
        {
            this.ownerName = ownerName;
        }
        public void set_creditCardNumber(string creditCardNumber)
        {
            this.creditCardNumber = creditCardNumber;
        }
        public void set_expirationDate(DateTime expirationDate)
        {
            this.expirationDate = expirationDate;
        }
        public void set_cvv(string cvv)
        {
            this.cvv = cvv;
        }
        public void set_amount(double amount)
        {
            this.amount = amount;
        }

        public void create_payment()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Payment @paymentID, @ownerName, @creditCardNumber, @expirationDate, @cvv, @amount";
            c.Parameters.AddWithValue("@paymentID", this.paymentID);
            c.Parameters.AddWithValue("@ownerName", this.ownerName);
            c.Parameters.AddWithValue("@creditCardNumber", this.creditCardNumber);
            c.Parameters.AddWithValue("@expirationDate", this.expirationDate);
            c.Parameters.AddWithValue("@cvv", this.cvv);
            c.Parameters.AddWithValue("@amount", this.amount);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}