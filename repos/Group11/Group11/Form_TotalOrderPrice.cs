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
    public partial class Form_TotalOrderPrice : Form
    {
        private string totalPrice;
        private double finalPrice;
        private double originalPrice;
        private string employeeID;

        public Form_TotalOrderPrice()
        {
            
            InitializeComponent();
        }
        public Form_TotalOrderPrice(string totalPrice , string employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.totalPrice = totalPrice;
            label_fabricsCost.Text = (Double.Parse(this.totalPrice) * 3).ToString();
            label_fixedCost.Text = "150";
            initPricesToShow();
            comboBox_discount.SelectedIndexChanged += comboBox_SelectedIndexChanged;


        }

        private void initPricesToShow()
        {
            double tempPrice = (Double.Parse(totalPrice) * 3) + Double.Parse(label_fixedCost.Text);
            finalPrice = (tempPrice * 0.83);
            originalPrice = finalPrice;
            label_FinalPrice.Text = finalPrice.ToString();


        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            UpdateFinalPrice();

        }

        private void UpdateFinalPrice()
        {
            // Retrieve the selected value from the ComboBox
            string selectedValue = comboBox_discount.SelectedItem.ToString();
            
            // Update the finalPrice based on the selected value
            if (selectedValue.Equals("0"))
            {
                this.finalPrice = originalPrice;
                label_FinalPrice.Text = this.finalPrice.ToString();
            }
            else if (selectedValue.Equals("10"))
            {
                this.finalPrice = originalPrice * 0.9;
                label_FinalPrice.Text = this.finalPrice.ToString();
            }
            else if (selectedValue.Equals("15"))
            {
                finalPrice = originalPrice * 0.85;
                label_FinalPrice.Text = this.finalPrice.ToString();
            }
            else if (selectedValue.Equals("20"))
            {
                finalPrice = originalPrice * 0.8;
                label_FinalPrice.Text = this.finalPrice.ToString();
            }
            else if (selectedValue.Equals("25"))
            {
                finalPrice = originalPrice * 0.75;
                label_FinalPrice.Text = this.finalPrice.ToString();
            }
            // label_FinalPrice.Text = this.finalPrice.ToString();

        }


        private void checkBoxIsVIP_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxIsVIP.Checked)  // Check if the VIP customer CheckBox is checked
            {
                comboBox_discount.Enabled = true;   // Enable the discount options GroupBox
            }
            else
            {
                comboBox_discount.Enabled = false;  // Disable the discount options GroupBox
            }
        }
        private void Form_TotalOrderPrice_Load(object sender, EventArgs e)
        {

        }

        private void button_EndCalculate_Click(object sender, EventArgs e)
        {
            Form_employeeMain el = new Form_employeeMain(employeeID);
            el.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_discount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_FinalPrice_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxIsVIP_CheckedChanged_1(object sender, EventArgs e)
        {

            comboBox_discount.Visible = checkBoxIsVIP.Checked;
            label_discount.Visible = checkBoxIsVIP.Checked;

        }

        

        //  נעשה פונקציה שתאתחל את כל נתוני חישוב המחיר ואז תשים אותם בלייבלס - מחיר מנוע קבוע - מחיר מוצרים נלויים + מחיר בדים כפול 3
        // פלוס חישוב מעמ
        //הצגת מחיר סופי ואישור
    }
}
