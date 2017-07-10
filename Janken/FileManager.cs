using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Janken
{
    static class FileManager
    {
        public static string filePath = "janken_statistics.csv";

        public static List<string> ReadCSV()
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                string[] row;
                List<string> ret = new List<string>();

                while ((line = reader.ReadLine()) != null)
                {
                    ret.Add(line);
                }

                return ret;
            }
        }

        public static void WriteCSV(string s)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.Default))
                writer.WriteLine(s);
        }
    }
}
