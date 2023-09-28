using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO47_28_NguyenQuangVinh.Model
{
    public interface IBookReader
    {
        void ReadBook();
    }
    public class XMLBookReader : IBookReader
    {
        public void ReadBook()
        {
            Console.WriteLine("Reading Book in XML Format");
        }
    }
    public class JSONBookReader : IBookReader
    {
        public void ReadBook()
        {
            Console.WriteLine("Reading Book in JSON Format");
        }
    }
}
