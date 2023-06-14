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
    public partial class Form_updateProduct : Form
    {
        private Product product;
        private string employeeID;
        public Form_updateProduct()
        {
            InitializeComponent();
        }

        public Form_updateProduct (string serialNumber, string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            product = Program.seekProduct(serialNumber);
            UP_serialNumber.Text = product.getSerialNumber();
            UP_name.Text = product.getProductName();
            UP_category.Text = product.getCategory().ToString();
            UP_comany.Text = product.getComapny();
            UP_color.Text = product.getColor().ToString();
            textBox_UP_price.Text = product.getPrice().ToString();
            textBox_UP_currentQuantity.Text = product.getCurrentQuantity().ToString();
            UP_supplierNumber.Text = product.getSupplier().get_SupplierNumber();
        }
        private void UP_back_Click(object sender, EventArgs e)
        {
            Form_productProfile back = new Form_productProfile(product.getSerialNumber(), employeeID);
            back.Show();
            this.Hide();
        }

        private void UP_updateProduct_Click(object sender, EventArgs e)
        {

            if (CheckUpdateProductInput())
            {
                product.set_currentQuantity(int.Parse(textBox_UP_currentQuantity.Text));
                product.set_price(double.Parse(textBox_UP_price.Text));
                product.Update_product();
                MessageBox.Show("פרטי המוצר עודכנו במערכת", "הפעולה הושלמה בהצלחה", MessageBoxButtons.OK);
                CrudProduct backToCrud = new CrudProduct(employeeID);
                backToCrud.Show();
                this.Hide();
            }
        }

        private bool CheckUpdateProductInput()
        {
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            if (!checkPrice())
            {
                return false;
            }
            if ( textBox_UP_currentQuantity.Text=="" || !readNumber.IsMatch(textBox_UP_currentQuantity.Text) || Double.Parse(textBox_UP_currentQuantity.Text) < 0)
            {
                MessageBox.Show("כמות לא תקינה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool checkPrice()
        {
            string pattern = @"\d+(\.\d+)?";
            Regex regex = new Regex(pattern);

            string price = textBox_UP_price.Text;

            if (price == "" || !regex.IsMatch(price))
            {
                MessageBox.Show("מחיר לא תקין", "!שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(price, out double p)  || p <= 0)
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

        private void Form_updateProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
