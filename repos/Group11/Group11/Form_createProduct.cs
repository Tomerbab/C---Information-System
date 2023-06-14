using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Group11
{
    public partial class Form_createProduct : Form
    {
        
        private string employeeID;

        public Form_createProduct()
        {
            InitializeComponent();
            comboBox_CP_color.DataSource = Enum.GetValues(typeof(Color)) ;
            comboBox_CP_category.DataSource = Enum.GetValues(typeof(ProductCategory));
        }

        public Form_createProduct(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
            comboBox_CP_color.DataSource = Enum.GetValues(typeof(Color));
            comboBox_CP_category.DataSource = Enum.GetValues(typeof(ProductCategory));
        }

        private void CP_back_Click(object sender, EventArgs e)
        {
            CrudProduct backToCrud = new CrudProduct(employeeID);
            backToCrud.Show();
            this.Hide();
        }

      

        private void CP_createProduct_Click(object sender, EventArgs e)
        {
            if (CheckProductInput())
            {
                Supplier s = Program.seekSupplier(textBox_CP_supplierNumber.Text);
                foreach (Product product in Program.Products)
                {
                    if (product.getProductName().Equals(textBox_CP_name.Text) && product.getSupplier().Equals(s))
                    {
                        MessageBox.Show("המוצר קיים במערכת", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                Product p = new Product(Convert.ToString(Program.Products.Count + 1), textBox_CP_name.Text, (ProductCategory)comboBox_CP_category.SelectedItem, textBox_CP_company.Text, Double.Parse(textBox_CP_price.Text), (Color)comboBox_CP_color.SelectedItem, int.Parse(textBox_CP_currentQuantity.Text), s, true);
                MessageBox.Show("המוצר נקלט במערכת", "הפעולה הושלמה בהצלחה", MessageBoxButtons.OK);
                CrudSupplier backToCrud = new CrudSupplier(employeeID);
                backToCrud.Show();
                this.Hide();
            }
        }

        private bool CheckProductInput() // check the user input 
        {
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            if (textBox_CP_name.Text == ""  || textBox_CP_name.Text.Length > 60)
            {
                MessageBox.Show("שם מוצר לא תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_CP_company.Text == "" || textBox_CP_company.Text.Length >  20)
            {
                MessageBox.Show("שם חברה לא תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!checkPrice())
            {
                return false;
            }
            if (textBox_CP_currentQuantity.Text == "" || !readNumber.IsMatch(textBox_CP_currentQuantity.Text) || Double.Parse(textBox_CP_currentQuantity.Text) < 0)
            {
                MessageBox.Show("מספר יחידות לא תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Program.checkSupplier(textBox_CP_supplierNumber.Text) || !readNumber.IsMatch(textBox_CP_supplierNumber.Text) || Double.Parse(textBox_CP_supplierNumber.Text) < 0)
            {
                MessageBox.Show("מספר ספק לא תקין", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool checkPrice()
        {
            string pattern = @"\d+(\.\d+)?";
            Regex regex = new Regex(pattern);

            string price = textBox_CP_price.Text;

            if (price == "" || !regex.IsMatch(price))
            {
                MessageBox.Show("מחיר לא תקין", "!שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(price, out double p) || p <= 0)
            {
                MessageBox.Show("מחיר לא תקין", "!שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                // הקלט תקין, ניתן להמשיך
                return true;
            }
        }



        private void Form_createProduct_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
