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
    public partial class Form_MeetingHours : Form
    {
        private int day;
        private int month;
        private int year;
        private string id;


        public Form_MeetingHours()
        {
            InitializeComponent();
        }

        public Form_MeetingHours(int day, int month, int year, string id)
        {
            this.day = day;
            this.month = month;
            this.year = year;
            this.id = id;
            InitializeComponent();
            addAvailableHours();
        }


        private void Form_MeetingHours_Load(object sender, EventArgs e)
        {

        }

        private void addAvailableHours()
        {
            if (Program.hourAvailable(year, month, day, 9))
            {
                comboBox_chooseMeetingHours.Items.Add("09:00");
            }
            if (Program.hourAvailable(year, month, day, 12))
            {
                comboBox_chooseMeetingHours.Items.Add("12:00");
            }
            if (Program.hourAvailable(year, month, day, 14))
            {
                comboBox_chooseMeetingHours.Items.Add("14:00");
            }
            if (Program.hourAvailable(year, month, day, 17))
            {
                comboBox_chooseMeetingHours.Items.Add("17:00");
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                // Retrieve the selected time from the ComboBox
                string selectedHour = comboBox_chooseMeetingHours.SelectedItem.ToString();
                Customer C = Program.seekCustomer(id);
                Employee E = Program.seekEmployee("1");
                DateTime meetingDT = new DateTime(year, month, day, int.Parse(selectedHour.Split(':')[0]), 0, 0);
                Meeting M = new Meeting(meetingDT, E, C, textBox_location.Text, null, true);
                MessageBox.Show("הפגישה נקבעה בהצלחה לתאריך" + " " + this.day + "." + this.month + "." + this.year + " בשעה " + selectedHour);
                string subject = "Dear Customer, Schedule Meeting Successful";
                string body = "Dear Customer, " +
                              "your appointment has been successfully scheduled in the system on" + " " + this.day + "." + this.month + "." + this.year + " at " + selectedHour + " in " + textBox_location.Text + "." +
                              "\nWe appreciate your choice to do business with us." +
                              "\nAdi Zak Studio";
                Program.sendEmail(subject, body, C.get_customerEmail());
                Form_CustomerMain cm = new Form_CustomerMain(id);
                cm.Show();
                this.Hide();
            }
        }

        private bool checkInput()
        {
            if (comboBox_chooseMeetingHours.SelectedItem == null)
            {
                MessageBox.Show("בחר שעה לפגישה", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_location.Text == "")
            {
                MessageBox.Show("אנא הכנס מיקום", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
            
        }

        private void comboBox_chooseMeetingHours_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_location_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form_ScheduleMeeting sm = new Form_ScheduleMeeting(id);
            sm.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


