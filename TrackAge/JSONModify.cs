using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace TrackAge
{
    class JSONModify
    {
        
        public static void JSONAdd(Package pack)
        {
            string filePath = @"C:\Users\User\Documents\Data.json";
            string[] json = new string[1];
            json[0] = JsonConvert.SerializeObject(pack, Formatting.Indented);
            File.AppendAllLines(filePath, json);
        }

        public static List<Package> JSONtoObject()
        {
            List<Package> packages = new List<Package>();

            packages = JsonConvert.DeserializeObject<Package>

            return packages;
        }
    }
}
