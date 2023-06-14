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
    public partial class Form_supplierProfile : Form
    {
        private Supplier supplier;
        private string employeeID;
        public Form_supplierProfile(string id, string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            supplier = Program.seekSupplier(id);
            SP_ID.Text = supplier.get_SupplierNumber();
            SP_name.Text = supplier.get_SupplierName();
            SP_address.Text = supplier.get_SupplierAddress();
            SP_phoneNumber.Text = supplier.get_SupplierPhoneNumber();
            SP_email.Text = supplier.get_SupplierEmail();
        }

        private void SP_id_Click(object sender, EventArgs e)
        {

        }

        private void Form_supplierProfile_Load(object sender, EventArgs e)
        {

        }

        private void button_SP_back_Click(object sender, EventArgs e)
        {
            Form_readSupplier back = new Form_readSupplier(employeeID);
            back.Show();
            this.Hide();
        }

        private void button_CP_supplierUpdate_Click(object sender, EventArgs e)
        {
            Form_updateSupplier update = new Form_updateSupplier(supplier.get_SupplierNumber(), employeeID);
            update.Show();
            this.Hide();
        }
    }
}
