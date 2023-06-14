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
    public partial class Form_customerLogin : Form
    {
        public Form_customerLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private Boolean CheckInput() // בדיקת תקינות קלטים
        {
            if (!Program.checkCustomer(textBox_UserName.Text) || textBox_UserName.Text == "")
            {
                MessageBox.Show("מספר הלקוח שהוזן לא תקין", "!שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Program.seekCustomer(textBox_UserName.Text).get_customerPassword().Equals(textBox_Password.Text) || textBox_Password.Text == "")
            {
                MessageBox.Show("הסיסמה שהוזנה לא תקינה", "!שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Button_Enter_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                string id = textBox_UserName.Text;
                Form_CustomerMain cp = new Form_CustomerMain(id); // מסך הבא עם שרשור מספר לקוח 
                cp.Show();
                this.Hide();
            }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form_customerLogin_Load(object sender, EventArgs e)
        {

        }

        private void CS_back_Click(object sender, EventArgs e)
        {
            Form_Main backToMain = new Form_Main();
            backToMain.Show();
            this.Hide();
        }

        

        private void button_close_Click(object sender, EventArgs e)
        {
            if (textBox_Password.PasswordChar == '\0')
            {
                button_open.BringToFront();
                textBox_Password.PasswordChar = '*';
            }
        }
        private void button_open_Click(object sender, EventArgs e)
        {
            if (textBox_Password.PasswordChar == '*')
            {
                button_close.BringToFront();
                textBox_Password.PasswordChar = '\0';
            }
        }


    }
}

    

