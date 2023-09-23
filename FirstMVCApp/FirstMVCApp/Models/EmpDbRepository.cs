using Microsoft.Data.SqlClient;
using Newtonsoft.Json.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;
using System.Data;

namespace FirstMVCApp.Models
{
    public class EmpDbRepository
    {
        public static List<Employee> GetEmpList()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection con = SqlHelper.CreateConnection())
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand sqlCommand = con.CreateCommand();
                string selectAllEmps = "Select * From emptbl_x";
                sqlCommand.CommandText = selectAllEmps; 
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Employee emp = new Employee
                    {
                        Eno = sqlDataReader.GetInt32(0),
                        Name = sqlDataReader.GetString(1),
                        Salary = sqlDataReader.GetDecimal(2),
                        City = sqlDataReader.GetString(3)
                    };
                    employees.Add(emp);

                }
               

            }
            return employees;
        }
        public static Employee GetEmptyById(int id)
        {
            Employee emp = new Employee();
            using (SqlConnection con = SqlHelper.CreateConnection())
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand sqlCommand = con.CreateCommand();
                string command= "Select eno,name,salary,city from emptbl_x  where eno =@id";
                sqlCommand.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                sqlCommand.CommandText = command;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while(reader.Read())
                {
                    
                    emp.Eno=reader.GetInt32(0);
                    emp.Name = reader.GetString(1);
                    emp.Salary=reader.GetDecimal(2);
                    emp.City=reader.GetString(3);
                }

            }
            return emp;
        }

        public static int AddNewEmp(Employee employee) {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertEmpcmd = cn.CreateCommand();
                String insertNewEmpQuery = "insert into emptbl_x values( @id,@name,@salary,@city )";
                insertEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = employee.Eno;
                insertEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = employee.Name;
                insertEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = employee.City;
                insertEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = employee.Salary;
                insertEmpcmd.CommandText = insertNewEmpQuery;
                query_result = insertEmpcmd.ExecuteNonQuery();
            }
            return query_result;

            }
        public static int UpdateEmp(Employee modifiedEmp) {
            int query_result = 0;

            using (SqlConnection cn = SqlHelper.CreateConnection())

            {

                if (cn.State != ConnectionState.Open)

                {

                    cn.Open();

                }

                SqlCommand updateEmpcmd = cn.CreateCommand();

                String updateEmpQuery = "Update emptbl_x set name=@name, salary=@salary, city=@city where eno=@id";

                updateEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiedEmp.Eno;

                updateEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = modifiedEmp.Name;

                updateEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = modifiedEmp.City;

                updateEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = modifiedEmp.Salary;

                updateEmpcmd.CommandText = updateEmpQuery;

                query_result = updateEmpcmd.ExecuteNonQuery();

            }

            return query_result;
        }

        public static int DeleteEmp(int  id) {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from emptbl_x where eno=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }    

    }
}
