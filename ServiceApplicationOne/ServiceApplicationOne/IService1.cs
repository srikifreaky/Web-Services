using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
namespace ServiceApplicationOne
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List <Employee> EmployeeDetails();
    }
    [DataContract]
    public class Employee
    {
        string name;
        int empid;
        double salary;
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public int EmpId
        {
            get { return empid; }
            set { empid = value; }
        }
        [DataMember]
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}