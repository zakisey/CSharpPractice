using System;

namespace Janken
{
    /// <summary>
    /// じゃんけんに参加するコンピュータを表すクラス
    /// </summary>
    internal class Computer : Player
    {
        public Computer(string name)
            : base(name)
        {
        }

        /// <summary>
        /// ランダムな手をコンピュータに与える
        /// </summary>
        /// <param name="random">Random型のインスタンス</param>
        public void SetRandomHand(Random random)
        {
            Hand = (JankenHand)random.Next(3);
        }
    }
}
