using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO50_28_NguyenQuangVinh.Model
{
    public interface IDepartment
    {
        int DeptId { get; set; }
        string DeptName { get; set; }
    }

    public class Department_28_NguyenQuangVinh : IDepartment
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }

    public class Engineering: Department_28_NguyenQuangVinh
    {
        public Engineering()
        {
            DeptName = "Engineering";
        }
    }
    public class Marketing: Department_28_NguyenQuangVinh
    {
        public Marketing()
        {
            DeptName = "Marketing";
        }
    }
}
