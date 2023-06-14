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
    public partial class Form_productsForPurchase : Form
    {
        private string employeeID;
        private string supplierNumber;
        private string productsForEmaill;
    

        public Form_productsForPurchase()
        {
            InitializeComponent();
            AddColumns();
        }

        public Form_productsForPurchase(string supplierNumber, string employeeID)
        {
            this.employeeID = employeeID;
            this.supplierNumber = supplierNumber;
            InitializeComponent();
            AddColumns();
            DisplaySupplierProducts();
        }

        private void Form_productsForPurchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.sAD_11DataSet.Products);

        }

        private void AddColumns()
        {
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Select";
            checkboxColumn.Name = "checkboxColumn";
            dataGridView_ProductsForPurchase.Columns.Add(checkboxColumn);

            DataGridViewTextBoxColumn numberColumn = new DataGridViewTextBoxColumn();
            numberColumn.HeaderText = "Qunatity";
            numberColumn.Name = "QunaitytColumn";
            dataGridView_ProductsForPurchase.Columns.Add(numberColumn);

            dataGridView_ProductsForPurchase.Columns["checkboxColumn"].ReadOnly = false;
            dataGridView_ProductsForPurchase.Columns["QunaitytColumn"].ReadOnly = false;

            // Set all other columns as read-only
            foreach (DataGridViewColumn column in dataGridView_ProductsForPurchase.Columns)
            {
                if (column.Name != "checkboxColumn" && column.Name != "QunaitytColumn")
                {
                    column.ReadOnly = true;
                }
            }
        }

        private void DisplaySupplierProducts()
        {
            List<Product> products = Program.Products; // list of products

            dataGridView_ProductsForPurchase.DataSource = null;
            dataGridView_ProductsForPurchase.Rows.Clear();

            foreach (Product product in products)
            {
                if (product.getSupplier().get_SupplierNumber().Equals(this.supplierNumber))
                {
                    dataGridView_ProductsForPurchase.Rows.Add(
                        product.getSerialNumber(),
                        product.getProductName(),
                        product.getCategory(),
                        product.getComapny(),
                        product.getPrice(),
                        product.getColor(),
                        product.getCurrentQuantity());

                }

            }
        }

        private void button_endPurchase_Click(object sender, EventArgs e)
        {
            if (checkBoxes())
            {
                double totalPrice = 0.0;
                foreach (DataGridViewRow row in dataGridView_ProductsForPurchase.Rows) // run over the rows in datagrid
                {

                    DataGridViewCheckBoxCell checkboxCell = row.Cells["checkboxColumn"] as DataGridViewCheckBoxCell; //if the checkbox is checked
                    if (Convert.ToBoolean(checkboxCell.Value) == true)
                    {

                        DataGridViewTextBoxCell quantityTB = row.Cells["QunaitytColumn"] as DataGridViewTextBoxCell; // Get the value from the quantity checkBox
                        int quantityValue = int.Parse(quantityTB.Value.ToString());
                        double priceValue = Convert.ToDouble(row.Cells[4].Value);
                        totalPrice += (quantityValue) * (priceValue);
                        string serialNumber = (row.Cells[0]).Value.ToString();
                        updateProductsCurrentQuantity(serialNumber, quantityValue);
                    }
                }
                createPurchase(totalPrice); // calculate total price inside
                MessageBox.Show("הרכישה בוצעה בהצלחה!", "אישור רכישה", MessageBoxButtons.OK);
                sendEmailToSupplier();
                Form_employeeMain backToemployee = new Form_employeeMain(employeeID);
                backToemployee.Show();
                this.Hide();
            }
        }

        private bool checkBoxes()
        {
            bool isAnyChecked = false;
            bool isAnyTextBoxEmpty = false;
            System.Text.RegularExpressions.Regex readNumber = new System.Text.RegularExpressions.Regex("^[0-9]*$");

            foreach (DataGridViewRow row in dataGridView_ProductsForPurchase.Rows)
            {
                DataGridViewCheckBoxCell checkboxCell = row.Cells["checkboxColumn"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkboxCell.Value) == true)
                {
                    isAnyChecked = true;
                    DataGridViewTextBoxCell textBoxCell = row.Cells["QunaitytColumn"] as DataGridViewTextBoxCell;
                    if (textBoxCell.Value == null || string.IsNullOrEmpty(textBoxCell.Value.ToString()) || !readNumber.IsMatch(textBoxCell.Value.ToString()))
                    {
                        isAnyTextBoxEmpty = true;
                        break;
                    }
                }
            }

            if (isAnyChecked)
            {
                if (isAnyTextBoxEmpty)
                {
                    MessageBox.Show("נא להזין כמות לרכישה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("נא לבחור מוצר לרכישה", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void sendEmailToSupplier()
        {
            Supplier s = Program.seekSupplier(supplierNumber);
            string subject = "New Purchase From Adi Zak Studio";
            string body = "Dear Supplier," +
                          "\nThe list of products in the purchase:" + productsForEmaill +
                          "\nAdi Zak Studio";
            Program.sendEmail(subject, body, s.get_SupplierEmail());
        }

        private void addProductToEmail(Product p, ProductsInPurchase pip)
        {

            productsForEmaill += "\nSerial number: " + p.getSerialNumber() + " , Product Name: " + p.getProductName() + " , Quatitiy: " + pip.getQuantityInPurchase();
        }

        private void createProductsInPurchase(Purchase purchase)  //creates new object pordcut in purchase with the values form DG and adding to each other lists.
        {
            foreach (DataGridViewRow row in dataGridView_ProductsForPurchase.Rows) // run over the rows in datagrid
            {
                DataGridViewCheckBoxCell checkboxCell = row.Cells["checkboxColumn"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(checkboxCell.Value) == true)      //if the checkbox is checked
                {
                    DataGridViewTextBoxCell quantityTB = row.Cells["QunaitytColumn"] as DataGridViewTextBoxCell;
                    string productSerialNumber = (row.Cells[0]).Value.ToString();
                    int quantityValue = int.Parse(quantityTB.Value.ToString());
                    Product P = Program.seekProduct(productSerialNumber);
                    ProductsInPurchase pip = new ProductsInPurchase(purchase, P, quantityValue, true);
                    Product product = Program.seekProduct(productSerialNumber);
                    product.addProductsInPurchases(pip); // adding ProductsInPurchase to ProductsInPurchases list
                    purchase.addProductsInPurchase(pip); // adding ProductsInPurchase to ProductsInPurchases list
                    addProductToEmail(product, pip); //Adding the product to the body of the email to the supplier
                }
            }
        }

        private void updateProductsCurrentQuantity(string prodcutID, int quantityValue) // update the new quantity of the products after purchase
        {
            foreach (Product product in Program.Products)
            {
                if (product.getSerialNumber().Equals(prodcutID))
                {
                    int newQuantity = product.getCurrentQuantity() + quantityValue;
                    product.set_currentQuantity(newQuantity);
                }
            }
        }

        private void createPurchase(double totalPrice) // creating the purchase object
        {
            foreach (Employee employee in Program.Employees)
            {
                if (employee.getID().Equals(employeeID))
                {
                    Purchase p = new Purchase(Convert.ToString(Program.Purchases.Count + 1), DateTime.Now, totalPrice, employee, true);
                    createProductsInPurchase(p);
                }
            }
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_supplierForPurchase cp = new Form_supplierForPurchase(this.employeeID);
            cp.Show();
            this.Hide();
        }

        private void button_Back_Click_1(object sender, EventArgs e)
        {
            Form_supplierForPurchase cp = new Form_supplierForPurchase(this.employeeID);
            cp.Show();
            this.Hide();
        }

        private void dataGridView_ProductsForPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
