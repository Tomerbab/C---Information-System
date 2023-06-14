using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group11
{
    public partial class UserControl_Days : UserControl
    {
        private int day;
        private int month;
        private int year;
        private string id;


        public UserControl_Days()
        {
            InitializeComponent();
        }

        private void UserControl_Days_Load(object sender, EventArgs e)
        {

        }

      private void UserControlDays_Click(object sender, EventArgs e)
        {
            DateTime currentDate = new DateTime(year, month, day);
            DateTime Now = DateTime.Now;
            if (currentDate.DayOfWeek != DayOfWeek.Friday && currentDate.DayOfWeek != DayOfWeek.Saturday && !Program.fullyBooked(year, month, day) && currentDate > Now)
            {
                Form_MeetingHours f = new Form_MeetingHours(day, month, year, id);
                Form formSchedule = FindForm();
                if (formSchedule != null)
                {
                    formSchedule.Hide(); // הסתרת הטופס הקודם
                }
                f.Show();
            }
            else
            {
                MessageBox.Show("לא מתקיימות פגישות ביום זה", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void days(int numberDay,int month,int year, string id)
        {
            this.day = numberDay;
            this.month = month;
            this.year = year;
            ID_Days.Text = numberDay + "";
            this.id = id;
        }
    }
}
