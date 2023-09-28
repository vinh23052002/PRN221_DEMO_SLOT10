using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO43_28_NguyenQuangVinh.Model
{
     public class Book_28_NguyenQuangVinh : IBook_28_NguyenQuangVinh
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }

    }
    public class TopicBook: Book_28_NguyenQuangVinh
    {
        public string Topic { get; set; }
    }
}
