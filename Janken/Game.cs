using System;

namespace Janken
{
    internal class Game
   {
        private Random random;

        public Game(int playersNum, int computersNum)
        {
            this.InitPlayers(playersNum);
            this.InitComputers(computersNum);
            this.random = new Random();
        }

        public Player[] Players { get; set; }

        public Computer[] Computers { get; set; }

        public void SetComputerHands()
        {
            foreach (Computer computer in this.Computers)
            {
                computer.SetRandomHand(this.random);
            }
        }

        public int GetTotalMembersNum()
        {
            return this.Players.Length + this.Computers.Length;
        }

        public Result Judge()
        {
            bool[] handFlags = this.CheckHands();

            Result result = new Result();
            result.IsDraw = false;
            if (handFlags[0] && handFlags[1] && !handFlags[2])
            {
                result.WinningHand = JankenHand.Rock;
            }
            else if (!handFlags[0] && handFlags[1] && handFlags[2])
            {
                result.WinningHand = JankenHand.Scissor;
            }
            else if (handFlags[0] && !handFlags[1] && handFlags[2])
            {
                result.WinningHand = JankenHand.Paper;
            }
            else
            {
                result.IsDraw = true;
            }

            foreach (Player player in this.Players)
            {
                if (player.Hand == result.WinningHand)
                {
                    result.WinnerNames.Add(player.Name);
                }
            }

            foreach (Computer computer in this.Computers)
            {
                if (computer.Hand == result.WinningHand)
                {
                    result.WinnerNames.Add(computer.Name);
                }
            }

            return result;
        }

        private bool[] CheckHands()
        {
            bool[] ret = new bool[] { false, false, false };
            foreach (Player player in this.Players)
            {
                ret[0] = ret[0] || (player.Hand == JankenHand.Rock);
                ret[1] = ret[1] || (player.Hand == JankenHand.Scissor);
                ret[2] = ret[2] || (player.Hand == JankenHand.Paper);
            }

            foreach (Computer computer in this.Computers)
            {
                ret[0] = ret[0] || (computer.Hand == JankenHand.Rock);
                ret[1] = ret[1] || (computer.Hand == JankenHand.Scissor);
                ret[2] = ret[2] || (computer.Hand == JankenHand.Paper);
            }

            return ret;
        }

        private void InitPlayers(int playersNum)
        {
            this.Players = new Player[playersNum];
            for (int i = 0; i < playersNum; i++)
            {
                this.Players[i] = new Player("プレイヤー" + i);
            }
        }

        private void InitComputers(int computersNum)
        {
            this.Computers = new Computer[computersNum];
            for (int i = 0; i < computersNum; i++)
            {
                this.Computers[i] = new Computer("コンピュータ" + i);
            }
        }
    }
}
