using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrackAge
{
    class XMLModify
    {
        public XMLModify()
        {

        }

        public static void XMLAdd(Package pack)
        {
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(typeof(Package));
            string fileName = "Data.xml";
            var path = Path.Combine(Environment.CurrentDirectory, fileName);
            TextWriter textWriter = new StreamWriter(@"D:\Data.xml");
            x.Serialize(textWriter, pack);
            textWriter.Close();
        }
    }
}
