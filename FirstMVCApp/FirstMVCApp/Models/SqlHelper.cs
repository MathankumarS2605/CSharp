using Microsoft.Data.SqlClient;

namespace FirstMVCApp.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()
        {
            var connString = @"server=200411LTP2851\SQLEXPRESS;database=sham;integrated security=true;Encrypt=false";
            SqlConnection sqlConnection = new SqlConnection(connString);
            return sqlConnection;
        }  
    }
}
