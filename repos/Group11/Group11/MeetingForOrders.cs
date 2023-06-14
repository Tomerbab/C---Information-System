using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Group11
{
   public class MeetingForOrders
    {
        private DateTime meetingDT;
        private string orderNum;
        public MeetingForOrders(DateTime meetingDT, string orderNumber, bool is_new)
        {
            this.meetingDT = meetingDT;
            this.orderNum = orderNumber;
            if (is_new)
                this.create_MeetingForOrders();
        }

        // Getter and Setter for meetingDT
        public DateTime getMeetingDT()
        {
            return this.meetingDT;
        }

        public void setmeetingDT(DateTime meetingDT)
        {
            this.meetingDT = meetingDT;
        }
        // Getter and Setter for orderNum
        public string getOrderNum()
        {
            return this.orderNum;
        }

        public void setorderNum(string orderNum)
        {
            this.orderNum = orderNum;
        }

        public void create_MeetingForOrders()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_MeetingForOrder @meetingDT, @orderNum";
            string sqlFormattedDate = this.meetingDT.ToString("yyyy-MM-dd HH:mm:ss.fff");
            c.Parameters.AddWithValue("@meetingDT", sqlFormattedDate);
            c.Parameters.AddWithValue("@orderNum", this.orderNum);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
