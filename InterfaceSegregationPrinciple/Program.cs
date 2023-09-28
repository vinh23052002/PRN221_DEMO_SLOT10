using  DEMO44_28_NguyenQuangVinh.Model;
using DEMO44_28_NguyenQuangVinh.Utillities; 

namespace InterfaceSegregationPrinciple
{

    class Program
    {
        static List<Video> bookList;

        static void PrintBooks(List<Video> bookList)
        {
            Console.WriteLine(" List of Books");
            Console.WriteLine("---------------------------");
            foreach (var item in bookList)
            {
                Console.WriteLine($" {item.Title.PadRight(36, ' ')} " +
                    $"{item.Author.PadRight(20, ' ')} {item.Price}"+" "+
                    $"{item.Topic?.PadRight(12,' ')}" +
                    $"{item.Duration ?? ""}");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string id = string.Empty;
            Console.Title = "Interface Segregation Principle";
            do
            {
                Console.WriteLine("File no. to read: 1/2/3-Enter(exis): ");
                id = Console.ReadLine();
                if ("123".Contains(id) && !String.IsNullOrEmpty(id))
                {
                    bookList = Utillities_28_NguyenQuangVinh.ReadData(id);
                    PrintBooks(bookList);
                }

            } while (!String.IsNullOrWhiteSpace(id));
        }
    }
}