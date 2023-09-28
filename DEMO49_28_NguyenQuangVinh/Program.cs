using DEMO49_28_NguyenQuangVinh.Model;
using Microsoft.Extensions.DependencyInjection;

namespace DEMO49_28_NguyenQuangVinh
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IDepartment,Marketing>()
                .AddTransient<Employee_28_NguyenQuangVinh>()
                .BuildServiceProvider();

            Employee_28_NguyenQuangVinh emp1 = serviceProvider.GetService<Employee_28_NguyenQuangVinh>();   
            emp1.EmployeeId = 1;
            emp1.EmployeeName = "Jack";
            emp1.AssignDepartment(serviceProvider.GetService<IDepartment>());

            Employee_28_NguyenQuangVinh emp2 = serviceProvider.GetService<Employee_28_NguyenQuangVinh>();
            emp2.AssignDepartment(serviceProvider.GetService<IDepartment>());
            emp2.EmployeeId = 2;
            emp2.EmployeeName = "Rose";

            Console.WriteLine(emp1);
            Console.WriteLine(new string('-',20));
            Console.WriteLine(emp2);
            Console.ReadLine();
        }
    }
}