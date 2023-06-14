using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group11
{
    public class ProductsInPurchase
    {
        private Purchase purchase;
        private Product product;
        private int quantityInPurchase;

        public ProductsInPurchase(Purchase purchase, Product product, int quantityInPurchase, bool is_new)
        {
            this.purchase = purchase;
            this.product = product;
            this.quantityInPurchase = quantityInPurchase;
            if (is_new)
            {
                this.create_ProductsInPurchase();
                
            }
        }

        public Purchase getPurchase()
        {
            return this.purchase;
        }
        public Product getProduct()
        {
            return this.product;
        }
        public int getQuantityInPurchase()
        {
            return this.quantityInPurchase;
        }

        public void setPurchase(Purchase purchase)
        {
            this.purchase = purchase;
        }
        public void setProduct(Product product)
        {
            this.product = product;
        }
        public void setQuantityInPurchase(int quantityInPurchase)
        {
            this.quantityInPurchase = quantityInPurchase;
        }

        public void create_ProductsInPurchase()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_ProductInPurchase @purchaseNumber, @serialNumber, @quantityInPurchase";
            c.Parameters.AddWithValue("@purchaseNumber", this.purchase.getPurchaseNumber());
            c.Parameters.AddWithValue("@serialNumber", this.product.getSerialNumber());
            c.Parameters.AddWithValue("@quantityInPurchase", this.quantityInPurchase);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }

}

