namespace Janken
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// じゃんけんの統計データをCSV形式で読み書きするためのクラス
    /// </summary>
    internal static class FileManager
    {
        private static string FilePath = "janken_statistics.csv";

        /// <summary>
        /// 統計データをCSVファイルから読み込む
        /// </summary>
        /// <returns>CSVファイルのデータを一行ずつ格納したリスト</returns>
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

        /// <summary>
        /// じゃんけんの結果をCSVファイルに書き込む
        /// </summary>
        /// <param name="s">CSVファイルに書き込む文</param>
        public static void WriteCSV(string s)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, true, Encoding.Default))
            {
                writer.WriteLine(s);
            }
        }
    }
}
