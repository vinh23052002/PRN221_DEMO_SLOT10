namespace DEMO41_28_NguyenQuangVinh { 

using System;
using System.IO;
    using DEMO41_28_NguyenQuangVinh.Model;
    using Newtonsoft.Json;

     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" List of Books");
            Console.WriteLine(" -------------------------");
            var cadJSON = File.ReadAllText("Data/BookStore_28_NguyenQuangVinh.json");
            var bookList = JsonConvert.DeserializeObject<Book_28_NguyenQuangVinh[]>(cadJSON);
            foreach(var item in bookList)
            {
                Console.WriteLine($" {item.Title.PadRight(39, ' ')} " +
                    $"{item.Author.PadRight(15, ' ')} {item.Price}");


            }
            Console.ReadLine();
        }
    }
}