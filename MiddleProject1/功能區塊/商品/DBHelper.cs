using System.Configuration;

namespace MiddleProject1
{
    public static class DBHelper
    {
        public static string GetConnectionString()
        {
            // 預設 Windows 驗證（Integrated Security）
            return "Data Source=localhost;Initial Catalog=NursingHome;Integrated Security=True;";

            // SQL 驗證範例（未啟用）
            // return "Data Source=localhost;Initial Catalog=NursingHome;User ID=sa;Password=12345678;";
        }
    }
}
