using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group11
{
    public class Purchase
    {
        private string purchaseNumber;
        private DateTime purchaseDT;
        private double totalPrice;
        private Employee employee;
        private List<ProductsInPurchase> ProductsInPurchases;



        public Purchase(string purchaseNumber, DateTime purchaseDT, double totalPrice, Employee employee, bool is_new)
        {
            this.purchaseNumber = purchaseNumber;
            this.purchaseDT = purchaseDT;
            this.totalPrice = totalPrice;
            this.employee = employee;
            ProductsInPurchases = new List<ProductsInPurchase>();
            Employee E = Program.seekEmployee(this.employee.getID());
            E.addPurchase(this);
            if (is_new)
            {
                this.create_Purchase();
                Program.Purchases.Add(this);
            }
        }


        public string getPurchaseNumber()
        {
            return this.purchaseNumber;
        }
        public DateTime getPurchaseDT()
        {
            return this.purchaseDT;
        }
        public double getTotalPrice()
        {
            return this.totalPrice;
        }
        public Employee getEmployee()
        {
            return this.employee;
        }


        public void setPurchaseNumber(string purchaseNumber)
        {
            this.purchaseNumber = purchaseNumber;
        }
        public void setPurchaseDT(DateTime purchaseDT)
        {
            this.purchaseDT = purchaseDT;
        }
        public void setTotalPrice(double totalPrice)
        {
            this.totalPrice = totalPrice;
        }
        public void setEmployee(Employee employee)
        {
            this.employee = employee;
        }


        public void addProductsInPurchase(ProductsInPurchase p)
        {
            if (p.getPurchase().getPurchaseNumber().Equals(this.getPurchaseNumber()))
            {
                ProductsInPurchases.Add(p);
            }
        }

        public List<ProductsInPurchase> getProductsInPurchase()
        {
            return this.ProductsInPurchases;
        }

        public void create_Purchase()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Purchase @purchaseNumber, @purchaseDT, @totalPrice, @employee";
            c.Parameters.AddWithValue("@purchaseNumber", this.purchaseNumber);
            c.Parameters.AddWithValue("@purchaseDT", this.purchaseDT);
            c.Parameters.AddWithValue("@totalPrice", this.totalPrice);
            c.Parameters.AddWithValue("@employee", this.employee.getID());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }

}
