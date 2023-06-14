using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group11
{
    public class Order
    {
        private string orderNum;
        private double price;
        private DateTime orderDT;
        private OrderStatus orderStatus;
        private Customer customer;
        private string paymentID;
        private List<ProductsInOrders> ProductsInOrders;
        private List<Meeting> Meetings;

        public Order(string orderNum, double price, DateTime orderDT, OrderStatus orderStatus, Customer customer, string paymentID, bool is_new)
        {
            this.orderNum = orderNum;
            this.price = price;
            this.orderDT = orderDT;
            this.orderStatus = orderStatus;
            this.customer = customer;
            this.paymentID = paymentID;
            ProductsInOrders = new List<ProductsInOrders>();
            Meetings = new List<Meeting>();
            Customer C = Program.seekCustomer(this.customer.get_customerID());
            C.addOrder(this);
            if (is_new)
            {
                this.create_order();
                Program.Orders.Add(this);

            }
        }

        public String getOrderNum()
        {
            return this.orderNum;
        }

        public void setOrderNum(String orderNum)
        {
            this.orderNum = orderNum;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public DateTime getOrderDT()

        {
            return orderDT;
        }

        public void setOrderDT(DateTime orderDT)
        {
            this.orderDT = orderDT;
        }

        public OrderStatus getOrderStatus()
        {
            return orderStatus;
        }

        public void setOrderStatus(OrderStatus orderStatus)
        {
            this.orderStatus = orderStatus;
        }

        public Customer getCustomer()
        {
            return customer;
        }

        public void setCustomer(Customer customer)
        {
            this.customer = customer;
        }

        public String getPaymentID()
        {
            return paymentID;
           
        }

        public void setPaymentID(String paymentID)
        {
            this.paymentID = paymentID;
            update_order();
        }

        public void addProductsInOrders(ProductsInOrders p)
        {
            if (p.getOrder().getOrderNum().Equals(this.getOrderNum()))
            {
                ProductsInOrders.Add(p);
            }
        }

        public List<ProductsInOrders> getProductsInOrders()
        {
            return this.ProductsInOrders;
        }

        public void addMeeting(Meeting m) // add meeting to the meetings list
        {
            Meetings.Add(m);
        }

        public List<Meeting> getMeetings() // return the meetings list
        {
            return this.Meetings;
        }

        private void create_order()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Order @orderNum, @price, @orderDT, @orderStatus, @customerID, @paymentID";
            c.Parameters.AddWithValue("@orderNum", this.orderNum);
            c.Parameters.AddWithValue("@price", this.price);
            string sqlFormattedDate = this.orderDT.ToString("yyyy-MM-dd HH:mm:ss.fff");
            c.Parameters.AddWithValue("@orderDT", sqlFormattedDate);
            c.Parameters.AddWithValue("@orderStatus", this.orderStatus.ToString());
            c.Parameters.AddWithValue("@customerID", this.customer.get_customerID());
            c.Parameters.AddWithValue("@paymentID", this.paymentID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        private void update_order()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Order @orderNum, @price, @orderStatus,@paymentID";
            c.Parameters.AddWithValue("@orderNum", this.orderNum);
            c.Parameters.AddWithValue("@price", this.price);
            c.Parameters.AddWithValue("@orderStatus", this.orderStatus.ToString());
            c.Parameters.AddWithValue("@paymentID", this.paymentID);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }

   
}







