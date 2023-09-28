using DEMO46_28_NguyenQuangVinh.Model;
using Microsoft.Extensions.DependencyInjection;

namespace DEMO46_28_NguyenQuangVinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Di_ServiceCollection Class";
            var services = new ServiceCollection();
            services.AddTransient<IXMLWriter, Writer_28_NguyenQuangVinh>();
            services.AddScoped<IJSONWriter, Writer_28_NguyenQuangVinh>();   
            var provider = services.BuildServiceProvider();

            Console.WriteLine("Dependency Injection Demo");
            Console.WriteLine("Mapping Interfaces to instance classses");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Please, select message format (1):XML | (2):JSON");
            var res = Console.ReadLine();
            if (res == "1")
            {
                var XMLInstance = provider.GetService<IXMLWriter>();
                XMLInstance.WriteXML();
            }
            else
            {
                var JSONInstance = provider.GetService<IJSONWriter>();
                JSONInstance.WriteJSON();   
            }
            var registerdXMLServices = provider.GetServices<IXMLWriter>();
            foreach (var svc in registerdXMLServices)
            {
                Console.WriteLine($"Service Name: { svc.ToString()}");
            }
            Console.WriteLine(new string('*', 20));
            foreach (var svc in services)
            {
                Console.WriteLine($"Type: {svc.ImplementationType}\n +" +
                    $"Lifetime: {svc.Lifetime}"+
                    $"Service Type:{svc.ServiceType}");
            }
            Console.ReadLine();
        }
    }
}