using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Group11
{
    public class Supplier
    {
        private string SupplierNumber;
        private string SupplierName;
        private string SupplierAddress;
        private string SupplierPhoneNumber;
        private string SupplierEmail;
        private List<Product> Products;


        public Supplier(string SupplierNumber, string SupplierName, string SupplierAddress, string SupplierPhoneNumber, string SupplierEmail, bool is_new)
        {
            this.SupplierNumber = SupplierNumber;
            this.SupplierName = SupplierName;
            this.SupplierAddress = SupplierAddress;
            this.SupplierPhoneNumber = SupplierPhoneNumber;
            this.SupplierEmail = SupplierEmail;
            Products = new List<Product>();
            if (is_new)
            {
                this.create_supplier();
                Program.Suppliers.Add(this);

            }
        }

        public string get_SupplierNumber()
        {
            return this.SupplierNumber;
        }

        public string get_SupplierName()
        {
            return this.SupplierName;
        }
        public string get_SupplierAddress()
        {
            return this.SupplierAddress;
        }

        public string get_SupplierPhoneNumber()
        {
            return this.SupplierPhoneNumber;
        }

        public string get_SupplierEmail()
        {
            return this.SupplierEmail;
        }
        public void set_SupplierNumber(string supplierNumber)
        {
            this.SupplierNumber = supplierNumber;
        }
        public void set_SupplierName(string supplierName)
        {
            this.SupplierName = supplierName;
        }
        public void set_SupplierAddress(string supplierAddress)
        {
            this.SupplierAddress = supplierAddress;
        }
        public void set_SupplierPhoneNumber(string supplierPhoneNumber)
        {
            this.SupplierPhoneNumber = supplierPhoneNumber;
        }

        public void set_SupplierEmail(string supplierEmail)
        {
            this.SupplierEmail = supplierEmail;
        }

        public List<Product> getProducts()
        {
            return this.Products;
        }
        public void addProduct(Product P)
        {
            if (this.get_SupplierNumber().Equals(P.getSupplier().get_SupplierNumber()))
                this.Products.Add(P);
        }

        public void create_supplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_supplier @SupplierNumber, @SupplierName, @SupplierAddress, @SupplierPhoneNumber, @SupplierEmail";
            c.Parameters.AddWithValue("@SupplierNumber", this.SupplierNumber);
            c.Parameters.AddWithValue("@SupplierName", this.SupplierName);
            c.Parameters.AddWithValue("@SupplierAddress", this.SupplierAddress);
            c.Parameters.AddWithValue("@SupplierPhoneNumber", this.SupplierPhoneNumber);
            c.Parameters.AddWithValue("@SupplierEmail", this.SupplierEmail);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_supplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Supplier @SupplierNumber, @SupplierAddress, @SupplierPhoneNumber, @SupplierEmail";
            c.Parameters.AddWithValue("@SupplierNumber", this.SupplierNumber);
            c.Parameters.AddWithValue("@SupplierAddress", this.SupplierAddress);
            c.Parameters.AddWithValue("@SupplierPhoneNumber", this.SupplierPhoneNumber);
            c.Parameters.AddWithValue("@SupplierEmail", this.SupplierEmail);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}

