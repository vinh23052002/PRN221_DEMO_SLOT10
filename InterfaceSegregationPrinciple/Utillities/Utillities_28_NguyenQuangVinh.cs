using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using DEMO44_28_NguyenQuangVinh.Model;
using System.IO.Enumeration;

namespace DEMO44_28_NguyenQuangVinh.Utillities
{
    internal class Utillities_28_NguyenQuangVinh
    {
        internal static List<Video> ReadData(string fileID)
        {
            var filename ="Data/BookStore"+ fileID+"_28_NguyenQuangVinh.json";
            var cadJSON = ReadFile(filename);
            return JsonConvert.DeserializeObject<List<Video>>(cadJSON);
        }

        internal static string ReadFile(string filename)
        {
            return File.ReadAllText(filename);  
        }
    }
}
