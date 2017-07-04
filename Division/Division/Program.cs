using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s1, s2;
                int dividend, divisor;
                Console.Write("割られる数> ");
                s1 = Console.ReadLine();
                if (!int.TryParse(s1, out dividend))
                {
                    Console.WriteLine("入力文字列の形式が正しくありません。");
                    Console.Read();
                    return;
                }
                while (true)
                {
                    Console.Write("割る数> ");
                    s2 = Console.ReadLine();
                    if (!int.TryParse(s2, out divisor))
                    {
                        Console.WriteLine("入力文字列の形式が正しくありません。");
                        Console.Read();
                        return;
                    }
                    if (divisor != 0)
                    {
                        break;
                    }
                    Console.WriteLine("0では割れません。再入力してください。");
                }

                Console.Write(dividend + " / " + divisor + " = ");
                int remainder = 0, count = 0;
                do
                {
                    Console.Write(dividend / divisor);
                    if (count == 0)
                    {
                        Console.Write(".");
                    }
                    remainder = dividend % divisor;
                    dividend = remainder * 10;
                    count++;
                } while (remainder != 0 && count <= 50);
                Console.WriteLine();
                Console.WriteLine("処理を続けますか？ 'y' / 'n'");
                string s3 = Console.ReadLine();
                if (s3 == "n")
                {
                    break;
                }
            }
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
