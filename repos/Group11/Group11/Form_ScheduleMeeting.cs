using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Group11
{
    public partial class Form_ScheduleMeeting : Form
    {
        int month;
        int year;
        string id;

        public Form_ScheduleMeeting(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form_ScheduleMeeting_Load(object sender, EventArgs e)
        {
            displayDays();
        }


        private void displayDays()
        {
            dayContainer.Controls.Clear();
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_Date.Text = monthName + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1); // get the first day of the month
            int days = DateTime.DaysInMonth(year, month); // get the count of days of the month
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1; // convert the startOfTheMonth to int

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControl_Blank UCBlank = new UserControl_Blank();
                dayContainer.Controls.Add(UCBlank);
            }
            for (int i = 1; i < days; i++)
            {
                UserControl_Days UCDays = new UserControl_Days();
                UCDays.days(i, month, year, id);
                UCDays.BackColor = System.Drawing.Color.White;
                changeColorIfUnavailable(UCDays, year, month, i);
                dayContainer.Controls.Add(UCDays);
            }
        }

        private void changeColorIfUnavailable(UserControl_Days UCDays, int year, int month, int i)
        {
            DateTime DT = new DateTime(year, month, i);
            if (DT.DayOfWeek == DayOfWeek.Friday || DT.DayOfWeek == DayOfWeek.Saturday || Program.fullyBooked(year, month, i) || DT < DateTime.Now)
            {
                UCDays.BackColor = System.Drawing.Color.Silver; // שינוי צבע הרקע לאפור
            }
        }



        private void button_Next_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();
            month++;
            if (month > 12) // Check if the month exceeds December
            {
                month = 1;
                year++;
            }
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            label_Date.Text = monthName + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1); // get the first day of the month
            int days = DateTime.DaysInMonth(year, month); // get the count of days of the month


            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1; // convert the startOfTheMonth to int

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControl_Blank UCBlank = new UserControl_Blank();
                dayContainer.Controls.Add(UCBlank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControl_Days UCDays = new UserControl_Days();
                UCDays.days(i, month, year, id);
                UCDays.BackColor = System.Drawing.Color.White;
                changeColorIfUnavailable(UCDays, year, month, i);
                dayContainer.Controls.Add(UCDays);

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button_Previous_Click(object sender, EventArgs e)
        {

            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            Boolean error = false;
            if (month != 1)
            {
                int previousYear = year; // שמירת ערך השנה הנוכחית במשתנה נוסף
                int previousMonth = month - 1;

                if ((previousYear < currentYear) || (previousYear == currentYear && previousMonth < currentMonth))
                {
                    error = true;
                    MessageBox.Show("לא ניתן לקבוע פגישה למועד שחלף", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (month == 1)
            {
                int previousYear = year - 1; // שמירת ערך השנה הנוכחית במשתנה נוסף

                if ((previousYear < currentYear) || (previousYear == currentYear && 12 < currentMonth))
                {
                    error = true;
                    MessageBox.Show("לא ניתן לקבוע פגישה למועד שחלף", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!error)
            {

                month--;
                if (month < 1) // Check if the month becomes less than January
                {
                    month = 12;
                    year--;
                }
                dayContainer.Controls.Clear();
                string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
                label_Date.Text = monthName + " " + year;
                DateTime startOfTheMonth = new DateTime(year, month, 1); // get the first day of the month
                int days = DateTime.DaysInMonth(year, month); // get the count of days of the month


                int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1; // convert the startOfTheMonth to int

                for (int i = 1; i < dayOfTheWeek; i++)
                {
                    UserControl_Blank UCBlank = new UserControl_Blank();
                    dayContainer.Controls.Add(UCBlank);
                }
                for (int i = 1; i <= days; i++)
                {
                    UserControl_Days UCDays = new UserControl_Days();
                    UCDays.days(i, month, year, id);
                    UCDays.BackColor = System.Drawing.Color.White;
                    changeColorIfUnavailable(UCDays, year, month, i);
                    dayContainer.Controls.Add(UCDays);

                }

            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form_CustomerMain cm = new Form_CustomerMain(id);
            cm.Show();
            this.Hide();
        }

        private void userControl_Days11_Load(object sender, EventArgs e)
        {

        }
    }
}






