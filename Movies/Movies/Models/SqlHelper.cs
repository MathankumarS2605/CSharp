using Microsoft.Data.SqlClient;

namespace Movies.Models
{
    public class SqlHelper
    {
        public static SqlConnection getSqlConnection()
        {
           
            var strCon = @"server=200411LTP2851\SQLEXPRESS;database=sham;integrated security=true;Encrypt=false";
            SqlConnection con = new SqlConnection(strCon);
            return con;

        }


    }
}
