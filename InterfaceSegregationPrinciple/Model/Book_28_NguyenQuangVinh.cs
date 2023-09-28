using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO44_28_NguyenQuangVinh.Model
{
     public class Book_28_NguyenQuangVinh : IBook_28_NguyenQuangVinh
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }

    }
    public class TopicBook: IBook_28_NguyenQuangVinh,ITopic
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }
        public string Topic { get; set; }
    }
    
    class Video: IBook_28_NguyenQuangVinh, ITopic,IDuration
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Price { get; set; }
        public string Topic { get; set; }
        public string Duration { get; set; }
    }
}
