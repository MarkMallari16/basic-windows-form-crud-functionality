using System.Configuration;
using System.Data.SqlClient;


namespace FirstWinForm.Database
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = ConfigurationManager.
            ConnectionStrings["college_student_management"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
