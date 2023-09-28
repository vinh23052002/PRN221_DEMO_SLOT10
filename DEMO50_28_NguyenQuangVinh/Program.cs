using DEMO50_28_NguyenQuangVinh.Model;
using Microsoft.Extensions.DependencyInjection;

namespace DEMO50_28_NguyenQuangVinh
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<Employee_28_NguyenQuangVinh>()
                .AddTransient<MarketingProvider>()
                .AddTransient<DefaultDepartmentProvider>()
                .BuildServiceProvider();

            DepartmentProvider.Current = serviceProvider.GetService<MarketingProvider>();

            Employee_28_NguyenQuangVinh emp1 = serviceProvider.GetService<Employee_28_NguyenQuangVinh>();
            emp1.EmployeeId = 1;
            emp1.EmployeeName = "Jack";
            emp1.EmployeeDept = DepartmentProvider.Current.Department;

            Employee_28_NguyenQuangVinh emp2 = serviceProvider.GetService<Employee_28_NguyenQuangVinh>();
            emp2.EmployeeId = 2;
            emp2.EmployeeName = "Rose";
            emp2.EmployeeDept = DepartmentProvider.Current.Department;

            Console.WriteLine(emp1);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(emp2);
            Console.ReadLine();
        }
    }
}