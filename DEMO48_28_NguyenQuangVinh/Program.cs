using DEMO48_28_NguyenQuangVinh.Model;

namespace DEMO48_28_NguyenQuangVinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee_28_NguyenQuangVinh emp1 = new Employee_28_NguyenQuangVinh(1, "David")
            {
                EmployeeDept = new Engineering()
            };

            Employee_28_NguyenQuangVinh emp2 = new Employee_28_NguyenQuangVinh(2, "John")
            {
                EmployeeDept = new Marketing()
            };
            Console.WriteLine(emp1);
            Console.WriteLine(new string('-',20));
            Console.WriteLine(emp2);
            Console.ReadLine();

        }
    }
}