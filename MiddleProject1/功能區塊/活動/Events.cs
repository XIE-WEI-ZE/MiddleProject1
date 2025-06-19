using Microsoft.Extensions.Logging;
using MiddleProject1.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject1.功能區塊.活動
{
    internal class Events
    {
       
        public static string getEventName(int eventID)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($" select 　EventName　from  EventDetails where EventID={eventID} ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader.GetString(0);
                    }

                    return "無活動資料";
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return "無活動資料";
            }

        }

        public static string getStatusName(int statusID)
        {
            string connString = Settings.Default.NursingHomeConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"select 　StatusName　from  EventStatus where StatusID={statusID} ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader.GetString(0);
                    }

                    return "未知狀態";
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return "未知狀態";
            }

        }

       
    }
}
