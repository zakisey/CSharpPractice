using System.Collections.Generic;

namespace Janken
{
    internal class Result
    {
        public Result()
        {
            this.WinnerNames = new List<string>();
        }

        public List<string> WinnerNames { get; set; }

        public JankenHand WinningHand { get; set; }

        public bool IsDraw { get; set; }

        public string GetString()
        {
            string ret = string.Empty;
            if (this.IsDraw)
            {
                ret = "あいこです。";
            }
            else
            {
                foreach (string name in this.WinnerNames)
                {
                    ret += $"{name}, ";
                }

                ret = ret.TrimEnd(',', ' ') + $"が{this.WinningHand.DisplayName()}で勝ちました。";
            }

            return ret;
        }
    }
}
