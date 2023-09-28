using DEMO47_28_NguyenQuangVinh.Model;

namespace DEMO47_28_NguyenQuangVinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookManager bm;
            Console.WriteLine("Please, select readign type (XML or JSON)");
            var ans = Console.ReadLine();
            if(ans.ToLower()=="xml")
            {
                bm = new BookManager(new XMLBookReader());
            }
            else
            {
                bm = new BookManager(new JSONBookReader());
            }
            bm.ReadBooks();
            Console.ReadLine();
        }
    }
}