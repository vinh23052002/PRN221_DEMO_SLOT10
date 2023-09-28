namespace DEMO42_28_NguyenQuangVinh
{
    using DEMO42_28_NguyenQuangVinh.Model;
    using DEMO42_28_NguyenQuangVinh.Utillities;
    using System;
    using System.Collections.Generic;   
    class Program
    {
        static List<Book_28_NguyenQuangVinh> bookList;
        static void PrintBooks(List<Book_28_NguyenQuangVinh> bookList)
        {
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
            Console.WriteLine("or any other key for a single file");
            var ans = Console.ReadLine();
            bookList = (ans.ToLower() != "yes") ? Utillities_28_NguyenQuangVinh.ReadData() : Utillities_28_NguyenQuangVinh.ReadDataExtra();
            PrintBooks(bookList);
        }
    }
}