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
    public partial class Form_employeeProfile : Form
    {
        private Employee employee;
        private string employeeID;

        public Form_employeeProfile()
        {
            InitializeComponent();
        }


        public Form_employeeProfile(string ID,string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            employee = Program.seekEmployee(ID);
            EP_ID.Text = employee.getID();
            EP_name.Text = employee.get_name();
            EP_birthDate.Text = employee.get_employeeBirthDate().ToString();
            EP_email.Text = employee.getEmail();
            EP_phoneNumber.Text = employee.getPhone();
            EP_address.Text = employee.getAddress();
            EP_startDate.Text = employee.getStartDate().ToString();
            EP_hourlySalary.Text = employee.getSalary().ToString();
            string status= "active";
            if (!employee.getstatus())
            {
                status = "inactive";
            }

            EP_status.Text = status;
            EP_password.Text = employee.getPassword();
            EP_type.Text = employee.get_type().ToString();
        }

        private void Form_employeeProfile_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void EP_ID_Click(object sender, EventArgs e)
        {

        }

        private void button_EP_back_Click(object sender, EventArgs e)
        {
            Form_readEmployee back = new Form_readEmployee(employeeID);
            back.Show();
            this.Hide();
        }

        private void button_EP_updateEmployee_Click(object sender, EventArgs e)
        {
            Form_updateEmployee update = new Form_updateEmployee(employee.getID(), employeeID);
            update.Show();
            this.Hide();
        }

        private void EP_startDate_Click(object sender, EventArgs e)
        {

        }
    }
}
