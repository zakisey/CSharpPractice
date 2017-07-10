namespace Janken
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class GameManager
    {
        private Player[] players;
        private Computer[] computers;
        private Random random;
        private int pNum;
        private int cNum;

        public GameManager()
        {
            this.random = new Random();
        }

        public void AskMembers()
        {
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("プレイヤーの人数を入力してください。");
                    this.pNum = this.ReadNumber();
                    if (this.pNum >= 0)
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
                    this.cNum = this.ReadNumber();
                    if (this.cNum >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("0以上の数字を入力してください。");
                    }
                }
                if (this.pNum + this.cNum >= 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("合計人数が2人以上になるように入力してください。");
                }
            }
            this.InitMembers();
        }

        private void InitMembers()
        {
            players = new Player[this.pNum];
            computers = new Computer[this.cNum];
            for (int i = 0; i < this.pNum; i++)
            {
                players[i] = new Player();
            }
            for (int i = 0; i < cNum; i++)
            {
                this.computers[i] = new Computer();
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
                if (count == this.pNum + this.cNum && hand != -1)
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
            for (int i = 0; i < this.pNum; i++)
            {
                while (true)
                {
                    Console.WriteLine($"プレイヤー{i}の手を入力してください。");
                    Console.WriteLine("0: グー, 1: チョキ, 2: パー, 3: データを見る");
                    int input = this.ReadNumber();
                    if (input >= 0 && input <= 2)
                    {
                        this.players[i].Hand = (JankenHand)input;
                        break;
                    }
                    else if (input == 3)
                    {
                        this.ShowStatistics();
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
            for (int i = 0; i < this.cNum; i++)
            {
                this.computers[i].SetRandomHand(this.random);
            }
        }

        private void WriteToCSV(int count, int result)
        {
            FileManager.WriteCSV(count + "," + result);
        }

        private string Judge(out bool isDraw)
        {
            bool rFlag = false, sFlag = false, pFlag = false;
            foreach (Player player in this.players)
            {
                rFlag = rFlag || (player.Hand == JankenHand.Rock);
                sFlag = sFlag || (player.Hand == JankenHand.Scissor);
                pFlag = pFlag || (player.Hand == JankenHand.Paper);
            }

            foreach (Computer computer in this.computers)
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
                this.WriteToCSV(this.pNum + this.cNum, -1);
                isDraw = true;
                return "あいこです。";
            }

            string ret = string.Empty;
            for (int i = 0; i < this.pNum; i++)
            {
                if (this.players[i].Hand == winningHand)
                {
                    ret += "プレイヤー" + i + ", ";
                }
            }
            for (int i = 0; i < this.cNum; i++)
            {
                if (this.computers[i].Hand == winningHand)
                {
                    ret += "コンピュータ" + i + ", ";
                }
            }

            ret = ret.TrimEnd(',', ' ');
            ret += $"が{winningHand.DisplayName()}で勝ちました。";

            isDraw = false;

            this.WriteToCSV(this.pNum + cNum, (int)winningHand);
            return ret;
        }

        public bool ShowResult()
        {
            for (int i = 0; i < pNum; i++)
            {
                Console.WriteLine($"プレイヤー{i}: " + this.players[i].Hand.DisplayName());
            }

            for (int i = 0; i < cNum; i++)
            {
                Console.WriteLine($"コンピュータ{i}: " + this.computers[i].Hand.DisplayName());
            }

            bool isDraw;
            string result = this.Judge(out isDraw);
            Console.WriteLine(result);
            return isDraw;
        }

        public bool AskQuit()
        {
            while (true)
            {
                Console.WriteLine("再戦しますか？");
                Console.WriteLine("0: 同じ人数で再戦 1: 人数を変更して再戦 2: 終了");
                int i = this.ReadNumber();
                switch (i)
                {
                    case 0:
                        return false;
                    case 1:
                        this.AskMembers();
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
