using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO47_28_NguyenQuangVinh.Model
{
    public class BookManager
    {
        public IBookReader bookReader;
        public BookManager(IBookReader reader)
        {
            bookReader = reader;
        }

        public void ReadBooks()
        {
            bookReader.ReadBook();
        }
    }
}
