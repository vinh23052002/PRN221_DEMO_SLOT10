using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO49_28_NguyenQuangVinh.Model
{
    public class Employee_28_NguyenQuangVinh
    {
        public int EmployeeId;
        public string EmployeeName;
        public IDepartment EmployeeDept;

        public Employee_28_NguyenQuangVinh() { }

        public Employee_28_NguyenQuangVinh(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
        }

        public void AssignDepartment(IDepartment dept)
        {
            EmployeeDept = dept ?? throw new ArgumentException("Null");
        }

        public override string ToString()
        {
            return $"EmpID:{EmployeeId},Emp Name:{EmployeeName},Department:{EmployeeDept.DeptName}";
        }
    }
}
