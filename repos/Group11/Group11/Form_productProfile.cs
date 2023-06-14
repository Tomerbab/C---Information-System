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
    public partial class Form_productProfile : Form
    {
        private Product product;
        private string employeeID;
        public Form_productProfile()
        {
            InitializeComponent();
        }

        public Form_productProfile(string serialNumber, string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            product = Program.seekProduct(serialNumber);
            PP_SerialNumber.Text = product.getSerialNumber();
            PP_name.Text = product.getProductName();
            PP_category.Text = product.getCategory().ToString();
            PP_Company.Text = product.getComapny();
            PP_Price.Text = product.getPrice().ToString();
            PP_Color.Text = product.getColor().ToString();
            PP_currentQuantity.Text = product.getCurrentQuantity().ToString();
            PP_SupplierNumber.Text = product.getSupplier().get_SupplierNumber();
        }
        private void Form_productProfile_Load(object sender, EventArgs e)
        {

        }

        private void button_PP_back_Click(object sender, EventArgs e)
        {
            Form_readProduct back = new Form_readProduct(employeeID);
            back.Show();
            this.Hide();
        }

        private void button_PP_updateProduct_Click(object sender, EventArgs e)
        {
            Form_updateProduct update = new Form_updateProduct(product.getSerialNumber(), employeeID);
            update.Show();
            this.Hide();
        }
    }
}
