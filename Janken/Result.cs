using System.Collections.Generic;

namespace Janken
{
    /// <summary>
    /// じゃんけんの結果を表すクラス
    /// 勝ったメンバーの名前と、勝った手と、引き分けかどうかのフラグをもつ
    /// </summary>
    internal class Result
    {
        public Result()
        {
            this.WinnerNames = new List<string>();
        }

        public List<string> WinnerNames { get; set; }

        public JankenHand WinningHand { get; set; }

        public bool IsDraw { get; set; }

        /// <summary>
        /// じゃんけんの結果を表す文章を返すメソッド
        /// </summary>
        /// <returns>じゃんけんの結果</returns>
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
