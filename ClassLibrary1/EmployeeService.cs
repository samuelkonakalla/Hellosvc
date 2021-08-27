using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace ClassLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        public Employee GetEmployee(int id)
        {
            Employee emp = new Employee();
            string con = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection scon = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployee", scon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                scon.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    emp.Id =Convert.ToInt32( dr["Id"]);
                    emp.Name = dr["Name"].ToString();
                    emp.Gender = dr["Gender"].ToString();
                    emp.DateOfBirth =Convert.ToDateTime( dr["DateOfBirth"]);
                }
            }

            return emp;
        }
        public void SaveEmployee(Employee emp)
        {
            string con = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection scon = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployee", scon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", emp.Id);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", emp.DateOfBirth);
                scon.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}
