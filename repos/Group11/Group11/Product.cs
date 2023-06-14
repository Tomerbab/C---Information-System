using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Group11
{
    public class Product
    {
        private string serialNumber;
        private string productName;
        private ProductCategory category;
        private string comapny;
        private double price;
        private Color color;
        private int currentQuantity;
        private Supplier supplier;
        private List<ProductsInPurchase> ProductsInPurchases;
        private List<ProductsInOrders> ProductsInOrders;


        public Product(string serialNumber, string productName, ProductCategory category, string comapny, double price, Color color, int currentQuantity, Supplier supplier, bool is_new)
        {
            this.serialNumber = serialNumber;
            this.productName = productName;
            this.category = category;
            this.comapny = comapny;
            this.price = price;
            this.color = color;
            this.currentQuantity = currentQuantity;
            this.supplier = supplier;
            ProductsInOrders = new List<ProductsInOrders>();
            ProductsInPurchases = new List<ProductsInPurchase>();
            Supplier S = Program.seekSupplier(this.supplier.get_SupplierNumber());
            S.addProduct(this);
            if (is_new)
            {
                this.create_product();
                Program.Products.Add(this);

            }
        }


        public string getSerialNumber()
        {
            return this.serialNumber;
        }
        public string getProductName()
        {
            return this.productName;
        }
        public ProductCategory getCategory()
        {
            return this.category;
        }
        public string getComapny()
        {
            return this.comapny;
        }
        public double getPrice()
        {
            return this.price;
        }
        public Color getColor()
        {
            return this.color;
        }
        public int getCurrentQuantity()
        {
            return this.currentQuantity;
        }
        public Supplier getSupplier()
        {
            return this.supplier;
        }
        public void set_serialNumber(string serialNumber)
        {
            this.serialNumber = serialNumber;
        }
        public void set_productName(string productName)
        {
            this.productName = productName;
        }
        public void set_category(ProductCategory category)
        {
            this.category = category;
        }
        public void set_comapny(string comapny)
        {
            this.comapny = comapny;
        }
        public void set_price(double price)
        {
            this.price = price;
        }
        public void set_color(Color color)
        {
            this.color = color;
        }
        public void set_currentQuantity(int currentQuantity)
        {
            this.currentQuantity = currentQuantity;
            Update_product();
        }
        public void set_supplier(Supplier supplier)
        {
            this.supplier = supplier;
        }

        public void addProductsInPurchases(ProductsInPurchase p)
        {
            if (p.getProduct().getSerialNumber().Equals(this.getSerialNumber()))
            {
                ProductsInPurchases.Add(p);
            }
        }

        public List<ProductsInPurchase> getProductsInPurchase()
        {
            return this.ProductsInPurchases;
        }

        public void addProductsInOrders(ProductsInOrders p)
        {
            if (p.getProduct().getSerialNumber().Equals(this.getSerialNumber()))
            {
                ProductsInOrders.Add(p);
            }
        }

        public List<ProductsInOrders> getProductsInOrders()
        {
            return this.ProductsInOrders;
        }
        public void create_product()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_Product @serialNumber, @productName, @category, @comapny, @price, @color, @currentQuantity, @supplierNumber";
            c.Parameters.AddWithValue("@serialNumber", this.serialNumber);
            c.Parameters.AddWithValue("@productName", this.productName);
            c.Parameters.AddWithValue("@category", this.category.ToString());
            c.Parameters.AddWithValue("@comapny", this.comapny);
            c.Parameters.AddWithValue("@price", this.price);
            c.Parameters.AddWithValue("@color", this.color.ToString());
            c.Parameters.AddWithValue("@currentQuantity", this.currentQuantity);
            c.Parameters.AddWithValue("@supplierNumber", this.supplier.get_SupplierNumber());

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_product()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_Product @serialNumber,  @price, @currentQuantity";
            c.Parameters.AddWithValue("@serialNumber", this.serialNumber);
            c.Parameters.AddWithValue("@price", this.price);
            c.Parameters.AddWithValue("@currentQuantity", this.currentQuantity);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
