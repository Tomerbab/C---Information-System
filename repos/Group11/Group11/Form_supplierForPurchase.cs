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
    public partial class Form_supplierForPurchase : Form
    {
        private string employeeID;

        public Form_supplierForPurchase()
        {
            InitializeComponent();
        }

        public Form_supplierForPurchase(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }
        private void Form_supplierForPurchase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sAD_11DataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.sAD_11DataSet.Suppliers);

        }

        private void button_chooseSupplier_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                Form_productsForPurchase pfp = new Form_productsForPurchase(textBox_supplierNum.Text, employeeID);
                pfp.Show();
                this.Hide();
            }
        }

        private Boolean CheckInput() // בדיקת תקינות קלטים
        {
            if (!Program.checkSupplier(textBox_supplierNum.Text) || textBox_supplierNum.Text == "")
            {
                MessageBox.Show("המספר שהוזן לא תקין", "!שגיאה במספר ספק", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void supplierDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_PurchasesFromSuppliers cf = new Form_PurchasesFromSuppliers(employeeID);
            cf.Show();
            this.Hide();
        }
    }
}
