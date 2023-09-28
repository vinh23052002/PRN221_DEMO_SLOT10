using DEMO43_28_NguyenQuangVinh.Model;
using DEMO43_28_NguyenQuangVinh.Utillities;

namespace DEMO43_28_NguyenQuangVinh
{
    class Program
    {
        static List<Book_28_NguyenQuangVinh> bookList;
        
        static void PrintBooks(List<Book_28_NguyenQuangVinh> bookList)
        {
            Console.WriteLine(" List of Books");
            Console.WriteLine("---------------------------");
            foreach (Book_28_NguyenQuangVinh item in bookList)
            {
                Console.WriteLine($" {item.Title.PadRight(39, ' ')} " +
                    $"{item.Author.PadRight(20, ' ')} {item.Price}");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, press 'yes' to read an extra file, ");
            Console.WriteLine("'topic' to include topic books or any other key for a single file");
            var ans = Console.ReadLine();
            bookList = ((ans.ToLower() != "yes")&& (ans !="topic") )? Utillities_28_NguyenQuangVinh.ReadData() : Utillities_28_NguyenQuangVinh.ReadData();
            PrintBooks(bookList);
        }
    }
}