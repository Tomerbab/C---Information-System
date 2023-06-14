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
    public partial class Form_employeeLogin : Form
    {
        public Form_employeeLogin()
        {
            InitializeComponent();
        }

        private Boolean CheckInput() // בדיקת תקינות קלטים
        {
            if (!Program.checkEmployee(textBox_employeeID.Text) || textBox_employeeID.Text == "")
            {
                MessageBox.Show("המספר משתמש שהוזן לא תקין", "!שגיאה ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Program.seekEmployee(textBox_employeeID.Text).getPassword().Equals(textBox_employeePassword.Text) || textBox_employeePassword.Text == "")
            {
                MessageBox.Show("הסיסמה שהוזנה לא תקין", "!שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Form_employeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void button_employeeEnter_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                Form_employeeMain em = new Form_employeeMain(textBox_employeeID.Text);
                em.Show();
                this.Hide();
            }

        }

        private void BackTomain_Click(object sender, EventArgs e)
        {
            Form_Main backToMain = new Form_Main();
            backToMain.Show();
            this.Hide();
        }

        private void button_closeEmployee_Click(object sender, EventArgs e)
        {
            if (textBox_employeePassword.PasswordChar == '\0')
            {
                button_openEmployee.BringToFront();
                textBox_employeePassword.PasswordChar = '*';
            }
        }

        private void button_openEmployee_Click(object sender, EventArgs e)
        {
            if (textBox_employeePassword.PasswordChar == '*')
            {
                button_closeEmployee.BringToFront();
                textBox_employeePassword.PasswordChar = '\0';
            }
        }
    }
}
