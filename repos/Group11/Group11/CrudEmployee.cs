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
    public partial class CrudEmployee : Form
    {
        private string employeeID;
        public CrudEmployee()
        {
            InitializeComponent();
        }
        public CrudEmployee(string employeeID)
        {
            this.employeeID = employeeID;
            InitializeComponent();
        }
        private void readEmployee_Click(object sender, EventArgs e)
        {
            Form_readEmployee f = new Form_readEmployee(employeeID);
            f.Show();
            this.Hide();
        }

        private void createEmployee_Click(object sender, EventArgs e)
        {
            Form_createEmployee f = new Form_createEmployee(employeeID);
            f.Show();
            this.Hide();
        }

        private void CrudEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button_CrudEmployee_back_Click(object sender, EventArgs e)
        {
            Form_employeeMain f = new Form_employeeMain(this.employeeID);
            f.Show();
            this.Hide();
        }
    }
}
