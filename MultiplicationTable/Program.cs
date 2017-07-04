using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   * * * 九九の表 * * *");
            Console.WriteLine("   |  1  2  3  4  5  6  7  8  9");
            Console.WriteLine("--------------------------------");
            for (int row = 1; row < 10; row++)
            {
                Console.Write(row + "  |");
                for (int col = 1; col < 10; col++)
                {
                    string space;
                    if (row * col >= 10)
                    {
                        space = " ";
                    }
                    else
                    {
                        space = "  ";
                    }
                    Console.Write(space + row * col);
                }
                Console.WriteLine();
            }
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
