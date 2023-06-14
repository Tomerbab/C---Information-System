using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group11
{
    public class ProductsInOrders
    {
        Order order;
        Product product;
        int quantityInOrder;

        public ProductsInOrders(Order order, Product product, int quantityInOrder, bool is_new)
        {
            this.order = order;
            this.product = product;
            this.quantityInOrder = quantityInOrder;
            if (is_new)
            {
                this.create_ProductsInOrders();
            }
        }

        public Order getOrder()
        {
            return this.order;
        }
        public Product getProduct()
        {
            return this.product;
        }
        public int getQuantityInOrder()
        {
            return this.quantityInOrder;
        }

        public void setorderNumber(Order order)
        {
            this.order = order;
        }
        public void setProduct(Product product)
        {
            this.product = product;
        }
        public void setQuantityInOrder(int quantityInOrder)
        {
            this.quantityInOrder = quantityInOrder;
        }

        public void create_ProductsInOrders()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_All_ProductsInOrders @orderNumber, @serialNumber, @quantityInOrder";
            c.Parameters.AddWithValue("@purchaseNumber", this.order.getOrderNum());
            c.Parameters.AddWithValue("@serialNumber", this.product.getSerialNumber());
            c.Parameters.AddWithValue("@quantityInPurchase", this.quantityInOrder);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }


    }
