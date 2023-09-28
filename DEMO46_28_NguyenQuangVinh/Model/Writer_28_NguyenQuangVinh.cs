using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO46_28_NguyenQuangVinh.Model
{
    public class Writer_28_NguyenQuangVinh:IXMLWriter,IJSONWriter
    {
        public void WriteJSON()
        {
            Console.WriteLine("<message>Writing in XML Format </message>");
        }

        public void WriteXML()
        {
            Console.WriteLine("<message>Writing in JSON Format </message>");
        }
    }
   
}
