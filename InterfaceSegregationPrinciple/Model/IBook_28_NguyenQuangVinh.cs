using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO44_28_NguyenQuangVinh.Model
{
     interface IBook_28_NguyenQuangVinh
    {
        string Title { get; set; }
        string Author { get; set; }
        string Price { get; set; }
    }

    interface ITopic
    {
        string Topic { get; set; }
    }
    interface IDuration
    {
        string Duration { get; set; }
    }
}
