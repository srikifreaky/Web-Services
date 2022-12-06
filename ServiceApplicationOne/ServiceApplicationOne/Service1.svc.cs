using ServiceApplicationOne;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
namespace ServiceApplicationOne
{
 public class Service1 : IService1
    {
        public List <Employee> EmployeeDetails()
        {
            var EmployeeList = new List <Employee> ();
            String connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"Z:\\WEB SERVICES\\LAB\\ServiceApplicationOne\\ServiceApplicationOne\\App_Data\\EmployeeDetails.mdf\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            SqlCommand com = new SqlCommand("Select EmpId,Name,Salary from Employee;", con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Employee obj = new Employee();
                    obj.EmpId = reader.GetInt32(0);
                    obj.Name = reader.GetString(1);
                    obj.Salary = reader.GetFloat(2);
                    EmployeeList.Add(obj);
                }
            }
            else
            { 
            }
            reader.Close();
            return EmployeeList;
        }
    }
}
