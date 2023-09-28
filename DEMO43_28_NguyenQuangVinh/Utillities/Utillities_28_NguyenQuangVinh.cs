using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using DEMO43_28_NguyenQuangVinh.Model;
using System.IO.Enumeration;

namespace DEMO43_28_NguyenQuangVinh.Utillities
{
    internal class Utillities_28_NguyenQuangVinh
    {
        static string ReadFile(string filename)
        {
            return File.ReadAllText(filename);
        }

        internal static List<Book_28_NguyenQuangVinh> ReadData()
        {
            var cadJSON = ReadFile("Data/BookStore1_28_NguyenQuangVinh.json");
            return JsonConvert.DeserializeObject<List<Book_28_NguyenQuangVinh>>(cadJSON);
        }

        internal static List<Book_28_NguyenQuangVinh> ReadDataExtra(string extra)
        {
            List<Book_28_NguyenQuangVinh> books = ReadData();
            var filename = "Data/BookStore2_28_NguyenQuangVinh.json";
            var cadJSON = ReadFile(filename);
            books.AddRange(JsonConvert.DeserializeObject<List<Book_28_NguyenQuangVinh>>(cadJSON));

            if (extra == "topic")
            {
                filename = "Data/BookStore3_28_NguyenQuangVinh.json";
                cadJSON = ReadFile(filename);
                books.AddRange(JsonConvert.DeserializeObject<List<TopicBook>>(cadJSON));
            }

            return books;
        }
    }
}
