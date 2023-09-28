using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using DEMO42_28_NguyenQuangVinh.Model;

namespace DEMO42_28_NguyenQuangVinh.Utillities
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

        internal static List<Book_28_NguyenQuangVinh> ReadDataExtra()
        {
            List<Book_28_NguyenQuangVinh> books = ReadData();
            var cadJSON = ReadFile("Data/BookStore2_28_NguyenQuangVinh.json");
            books.AddRange(JsonConvert.DeserializeObject<List<Book_28_NguyenQuangVinh>>(cadJSON));
            return books;
        }
    }
}
