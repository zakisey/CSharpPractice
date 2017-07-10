namespace Janken
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal static class FileManager
    {
        private static string FilePath = "janken_statistics.csv";

        public static List<string> ReadCSV()
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
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
            using (StreamWriter writer = new StreamWriter(FilePath, true, Encoding.Default))
            {
                writer.WriteLine(s);
            }
        }
    }
}
