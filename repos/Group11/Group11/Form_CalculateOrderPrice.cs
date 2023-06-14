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
    public partial class Form_CalculateOrderPrice : Form
    {
        private double dimensionsPrice;
        private string productName_Cell;
        private string color_Cell;
        private string price_Cell;
        private string totalPrice;
        private string employeeID;
        public Form_CalculateOrderPrice()
        {
            InitializeComponent();
        }
        public Form_CalculateOrderPrice(string productName_Cell, string color_Cell, string price_Cell, string totalPrice ,string employeeID)
        {
            this.employeeID = employeeID;
            this.productName_Cell = productName_Cell;
            this.color_Cell = color_Cell;
            this.price_Cell = price_Cell;
            this.totalPrice = totalPrice;
            InitializeComponent();
            fabricName.Text = this.productName_Cell;
            fabricColor.Text = this.color_Cell;
            fabricPrice.Text = this.price_Cell;
        }

        private void Form_CalculateOrderPrice_Load(object sender, EventArgs e)
        {

        }

        private void button_ShowPrice_Click(object sender, EventArgs e)
        {
            if (checkDimensions())
            {
                this.dimensionsPrice = (Double.Parse(textBox_Length.Text) + Double.Parse(textBox_Width.Text)) * Double.Parse(price_Cell);
                label_ShowPrice.Text = dimensionsPrice.ToString();

            }
        }

        private bool checkDimensions()
        {
            string pattern = @"\d+(\.\d+)?";
            Regex regex = new Regex(pattern);

            string lengthText = textBox_Length.Text;
            string widthText = textBox_Width.Text;

            if (lengthText == "" || widthText == "" || !regex.IsMatch(lengthText) || !regex.IsMatch(widthText))
            {
                MessageBox.Show("המידות שהכנסת לא תקינות", "!שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(lengthText, out double length) || !Double.TryParse(widthText, out double width) || length <= 0 || width <= 0)
            {
                MessageBox.Show("המידות שהכנסת לא תקינות", "!שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                // הקלט תקין, ניתן להמשיך
                return true;
            }
        }


        private void button_AddToOrderPrice_Click(object sender, EventArgs e)
        {
            if (checkDimensions())
            {
                this.dimensionsPrice = (Double.Parse(textBox_Length.Text) + Double.Parse(textBox_Width.Text)) * Double.Parse(price_Cell);
                this.totalPrice = (Double.Parse(this.totalPrice) + this.dimensionsPrice).ToString();
                Form_ChooseFabricForOrder cffo = new Form_ChooseFabricForOrder(this.totalPrice, employeeID);
                cffo.Show();
                this.Hide();

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form_ChooseFabricForOrder cffo = new Form_ChooseFabricForOrder(this.totalPrice, employeeID);
            cffo.Show();
            this.Hide();
        }
    }
}
