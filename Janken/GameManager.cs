﻿namespace Janken
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// ゲームの進行のためのクラス
    /// プロンプトを表示し、ユーザからの入力を受け取る
    /// </summary>
    internal class GameManager
    {
        private Game game;

        public GameManager()
        {
        }

        /// <summary>
        /// メインループ
        /// </summary>
        public void PlayGame()
        {
            this.InitGame();
            do
            {
                Result result;
                do
                {
                    this.AskPlayerHands();
                    this.game.SetComputerHands();
                    result = this.game.Judge();
                    this.WriteToCSV(result);
                    this.ShowResult(result);

                }

                while (result.IsDraw);
            }
            while (this.AskContinue());
        }

        private void InitGame()
        {
            var nums = this.AskMembersNum();
            this.game = new Game(nums.Item1, nums.Item2);
        }

        private Tuple<int, int> AskMembersNum()
        {
            int pNum = this.AskNumber("プレイヤー");
            int cNum = this.AskNumber("コンピュータ");
            while (pNum + cNum < 2)
            {
                Console.WriteLine("合計人数が2人以上になるように入力してください。");
                pNum = this.AskNumber("プレイヤー");
                cNum = this.AskNumber("コンピュータ");
            }

            return new Tuple<int, int>(pNum, cNum);
        }

        private int AskNumber(string entityName)
        {
            Console.WriteLine($"{entityName}の人数を入力してください。");
            int ret = this.ReadNumber();
            while (ret < 0)
            {
                Console.WriteLine("0以上の数字を入力してください。");
                ret = this.ReadNumber();
            }

            return ret;
        }

        private int[] GetHandData(List<string> l)
        {
            int[] handData = new int[] { 0, 0, 0 };
            foreach (string s in l)
            {
                string[] row = s.Split(',');
                int count = int.Parse(row[0]);
                int hand = int.Parse(row[1]);
                if (count == this.game.GetTotalMembersNum() && hand != -1)
                {
                    handData[hand] += 1;
                }
            }

            return handData;
        }

        private void ShowWinRate(int[] handData)
        {
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

                Console.WriteLine($"{this.game.GetTotalMembersNum()}人でのじゃんけんでのこれまでの勝率は、\n" +
                    $"グー: {winRate[0].ToString("F")} %, " +
                    $"チョキ: {winRate[1].ToString("F")} %, " +
                    $"パー: {winRate[2].ToString("F")} % です。\n");
            }
        }

        private void ShowStatistics()
        {
            List<string> l = FileManager.ReadCSV();
            int[] handData = GetHandData(l);
            this.ShowWinRate(handData);
        }

        private void AskPlayerHands()
        {
            foreach (Player player in this.game.Players)
            {
                while (true)
                {
                    Console.WriteLine($"{player.Name}の手を入力してください。");
                    Console.WriteLine("0: グー, 1: チョキ, 2: パー, 3: データを見る");
                    int input = this.ReadNumber();
                    if (input >= 0 && input <= 2)
                    {
                        player.Hand = (JankenHand)input;
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

        private void WriteToCSV(Result result)
        {
            if (!result.IsDraw)
            {
                FileManager.WriteCSV(this.game.GetTotalMembersNum() + "," + (int)result.WinningHand);
            }
        }

        private void ShowHands()
        {
            foreach (Player player in this.game.Players)
            {
                Console.WriteLine(player.Name + ": " + player.Hand.DisplayName());
            }

            foreach (Computer computer in this.game.Computers)
            {
                Console.WriteLine(computer.Name + ": " + computer.Hand.DisplayName());
            }
        }

        private void ShowResult(Result result)
        {
            this.ShowHands();
            Console.WriteLine(result.GetString());
        }

        /// <summary>
        /// じゃんけんゲームを終えるかどうかの判定をし、判定結果を返す
        /// </summary>
        /// <returns>じゃんけんゲームを終える場合、true. それ以外の場合、false</returns>
        private bool AskContinue()
        {
            while (true)
            {
                Console.WriteLine("再戦しますか？");
                Console.WriteLine("0: 同じ人数で再戦 1: 人数を変更して再戦 2: 終了");
                int i = this.ReadNumber();
                switch (i)
                {
                    case 0:
                        return true;
                    case 1:
                        this.InitGame();
                        return true;
                    case 2:
                        return false;
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
