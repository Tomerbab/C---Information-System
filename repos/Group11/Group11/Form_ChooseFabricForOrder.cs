using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11
{
    public partial class Form_ChooseFabricForOrder : Form
    {
        private string totalPrice;
        private string employeeID;
        public Form_ChooseFabricForOrder()
        {
            this.totalPrice = "0";
            InitializeComponent();
            DisplayFabrics();
        }
        public Form_ChooseFabricForOrder(string totalPrice , string employeeID)
        {
            this.employeeID = employeeID;
            this.totalPrice = totalPrice;
            InitializeComponent();
            DisplayFabrics();
        }
        private void Form_ChooseFabricForOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.Products' table. You can move, or remove it, as needed.
           // this.productsTableAdapter.Fill(this.sAD_11DataSet.Products);

        }

        private void DisplayFabrics()
        {
            List<Product> products = Program.Products; // list of products
            dataGridViewFabrics.DataSource = null;
            dataGridViewFabrics.Rows.Clear();

            foreach (Product product in products)
            {
                if (product.getCategory().ToString().Equals("fabric"))
                {
                    dataGridViewFabrics.Rows.Add(
                    product.getProductName(),
                    product.getCategory(),
                    product.getComapny(),
                    product.getPrice(),
                    product.getColor());
                }
            }
        }

        private void dataGridViewFabrics_DoubleClick(object sender, EventArgs e) // נלחץ פעמיים על מוצר בטבלה
        {

            if (dataGridViewFabrics.CurrentRow != null) // Check if a valid row is double-clicked
            {

                DataGridViewRow selectedRow = dataGridViewFabrics.CurrentRow; // Get the data from the selected row

                string productName_Cell = selectedRow.Cells[0].Value.ToString();
                string color_Cell = selectedRow.Cells[4].Value.ToString();
                string price_Cell = selectedRow.Cells[3].Value.ToString();
                Form_CalculateOrderPrice cop = new Form_CalculateOrderPrice(productName_Cell, color_Cell, price_Cell , this.totalPrice,employeeID);
                cop.Show();
                this.Hide();
                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_shoeTotalPrice_Click(object sender, EventArgs e)
        {
            if (this.totalPrice.Equals("0"))
            {
                MessageBox.Show("לא נבחרו מוצרים", "!שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form_TotalOrderPrice top = new Form_TotalOrderPrice(this.totalPrice, employeeID);
                top.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_employeeMain f = new Form_employeeMain(employeeID);
            f.Show();
            this.Hide();
        }

        private void dataGridViewFabrics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
