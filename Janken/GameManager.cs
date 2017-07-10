using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janken
{
    class GameManager
    {
        private Player[] players;
        private Computer[] computers;
        private Random random;
        private int pNum;
        private int cNum;

        public GameManager()
        {
            random = new Random();
        }

        public void AskMembers()
        {
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("プレイヤーの人数を入力してください。");
                    pNum = ReadNumber();
                    if (pNum >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("0以上の数字を入力してください。");
                    }
                }
                while (true)
                {
                    Console.WriteLine("コンピュータの人数を入力してください。");
                    cNum = ReadNumber();
                    if (cNum >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("0以上の数字を入力してください。");
                    }
                }
                if (pNum + cNum >= 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("合計人数が2人以上になるように入力してください。");
                }
            }
            InitMembers();
        }

        private void InitMembers()
        {
            players = new Player[pNum];
            computers = new Computer[cNum];
            for (int i = 0; i < pNum; i++)
            {
                players[i] = new Player();
            }
            for (int i = 0; i < cNum; i++)
            {
                computers[i] = new Computer();
            }
        }

        private void ShowStatistics()
        {
            List<string> l = FileManager.ReadCSV();
            int[] handData = new int[] { 0, 0, 0 };
            foreach (string s in l)
            {
                string[] row = s.Split(',');
                int count = int.Parse(row[0]);
                int hand = int.Parse(row[1]);
                if (count == pNum + cNum && hand != -1)
                {
                    handData[hand] += 1;
                }
            }
            
            int total = handData[0] + handData[1] + handData[2];


            if (total == 0)
            {
                Console.WriteLine("データがありません。");
            }
            else
            {
                double[] winRate = new double[3];
                for (int i = 0; i < winRate.Length; i++)
                {
                    winRate[i] = (double)handData[i] / (double)total * 100;
                }
                Console.WriteLine($"{pNum + cNum}人でのじゃんけんでのこれまでの勝率は、\n" +
                    $"グー: {winRate[0].ToString("F")} %, " +
                    $"チョキ: {winRate[1].ToString("F")} %, " +
                    $"パー: {winRate[2].ToString("F")} % です。\n");
            }
        }

        public void AskPlayerHands()
        {
            for (int i = 0; i < pNum; i++)
            {
                while (true)
                {
                    Console.WriteLine($"プレイヤー{i}の手を入力してください。");
                    Console.WriteLine("0: グー, 1: チョキ, 2: パー, 3: データを見る");
                    int input = ReadNumber();
                    if (input >= 0 && input <= 2)
                    {
                        players[i].Hand = (JankenHand)input;
                        break;
                    }
                    else if (input == 3)
                    {
                        ShowStatistics();
                    }
                    else
                    {
                        Console.WriteLine("0から3の整数を入力してください。");
                    }
                }
            }
        }

        public void SetComputerHands()
        {
            for (int i = 0; i < cNum; i++)
            {
                computers[i].SetRandomHand(random);
            }
        }

        private void WriteToCSV(int count, int result)
        {
            FileManager.WriteCSV(count + "," + result);
        }

        private string Judge(out bool isDraw)
        {
            bool rFlag = false, sFlag = false, pFlag = false;
            foreach (Player player in players)
            {
                rFlag = rFlag || (player.Hand == JankenHand.Rock);
                sFlag = sFlag || (player.Hand == JankenHand.Scissor);
                pFlag = pFlag || (player.Hand == JankenHand.Paper);
            }
            foreach (Computer computer in computers)
            {
                rFlag = rFlag || (computer.Hand == JankenHand.Rock);
                sFlag = sFlag || (computer.Hand == JankenHand.Scissor);
                pFlag = pFlag || (computer.Hand == JankenHand.Paper);
            }
            JankenHand winningHand;
            if (rFlag && sFlag && !pFlag)
            {
                winningHand = JankenHand.Rock;
            }
            else if (!rFlag && sFlag && pFlag)
            {
                winningHand = JankenHand.Scissor;
            }
            else if (rFlag && !sFlag && pFlag)
            {
                winningHand = JankenHand.Paper;
            }
            else
            {
                WriteToCSV(pNum + cNum, -1);
                isDraw = true;
                return "あいこです。";
            }

            string ret = "";
            for (int i = 0; i < pNum; i++)
            {
                if (players[i].Hand == winningHand)
                {
                    ret += "プレイヤー" + i + ", ";
                }
            }
            for (int i = 0; i < cNum; i++)
            {
                if (computers[i].Hand == winningHand)
                {
                    ret += "コンピュータ" + i + ", ";
                }
            }

            ret = ret.TrimEnd(',', ' ');
            ret += $"が{winningHand.DisplayName()}で勝ちました。";

            isDraw = false;

            WriteToCSV(pNum + cNum, (int)winningHand);
            return ret;
        }

        public bool ShowResult()
        {
            for (int i = 0; i < pNum; i++)
            {
                Console.WriteLine($"プレイヤー{i}: " + players[i].Hand.DisplayName());
            }
            for (int i = 0; i < cNum; i++)
            {
                Console.WriteLine($"コンピュータ{i}: " + computers[i].Hand.DisplayName());
            }
            bool isDraw;
            string result = Judge(out isDraw);
            Console.WriteLine(result);
            return isDraw;
        }

        public bool AskQuit()
        {
            while (true)
            {
                Console.WriteLine("再戦しますか？");
                Console.WriteLine("0: 同じ人数で再戦 1: 人数を変更して再戦 2: 終了");
                int i = ReadNumber();
                switch (i)
                {
                    case 0:
                        return false;
                    case 1:
                        AskMembers();
                        return false;
                    case 2:
                        return true;
                    default:
                        Console.WriteLine("0から2の整数を入力してください。");
                        break;
                }
            }
        }

        private int ReadNumber()
        {
            var s = Console.ReadLine();
            int i;
            if (!int.TryParse(s, out i))
            {
                return -1;
            }

            return i;
        }
    }
}
