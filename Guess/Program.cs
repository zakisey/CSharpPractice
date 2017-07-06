using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Random rand = new System.Random();
            int ans = rand.Next(100);
            int count = 0;
            while (true)
            {
                count++;
                Console.Write("0から100の間の数値を当ててください。> ");
                string s = Console.ReadLine();
                int guess;
                if (!int.TryParse(s, out guess))
                {
                    Console.WriteLine("不正な値です。");
                    Console.Read();
                    return;
                }
                if (guess == ans)
                {
                    Console.WriteLine("おめでとう。" + count + "回目で当たりました。");
                    Console.WriteLine();
                    break;
                }
                else if (guess > ans)
                {
                    Console.WriteLine("答はもっと小さいです。");
                }
                else
                {
                    Console.WriteLine("答はもっと大きいです。");
                }
                Console.WriteLine();
            }
            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
