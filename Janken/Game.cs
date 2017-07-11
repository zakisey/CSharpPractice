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

        public Result Judge()
        {
            Result result = new Result();
            result.IsDraw = false;
            bool rFlag = false, sFlag = false, pFlag = false;
            foreach (Player player in this.Players)
            {
                rFlag = rFlag || (player.Hand == JankenHand.Rock);
                sFlag = sFlag || (player.Hand == JankenHand.Scissor);
                pFlag = pFlag || (player.Hand == JankenHand.Paper);
            }

            foreach (Computer computer in this.Computers)
            {
                rFlag = rFlag || (computer.Hand == JankenHand.Rock);
                sFlag = sFlag || (computer.Hand == JankenHand.Scissor);
                pFlag = pFlag || (computer.Hand == JankenHand.Paper);
            }

            if (rFlag && sFlag && !pFlag)
            {
                result.WinningHand = JankenHand.Rock;
            }
            else if (!rFlag && sFlag && pFlag)
            {
                result.WinningHand = JankenHand.Scissor;
            }
            else if (rFlag && !sFlag && pFlag)
            {
                result.WinningHand = JankenHand.Paper;
            }
            else
            {
                result.IsDraw = true;
            }

            for (int i = 0; i < this.Players.Length; i++)
            {
                if (this.Players[i].Hand == result.WinningHand)
                {
                    result.WinnerNames.Add(this.Players[i].Name);
                }
            }

            for (int i = 0; i < this.Computers.Length; i++)
            {
                if (this.Computers[i].Hand == result.WinningHand)
                {
                    result.WinnerNames.Add(this.Computers[i].Name);
                }
            }

            return result;
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
