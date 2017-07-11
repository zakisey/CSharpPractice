namespace Janken
{
    internal enum JankenHand
    {
        Rock, Scissor, Paper
    }

    internal static class JankenHandExt
    {
        public static string DisplayName(this JankenHand hand)
        {
            string[] s = { "グー", "チョキ", "パー" };
            return s[(int)hand];
        }
    }

    /// <summary>
    /// じゃんけんのプレイヤー(人間)を表すクラス
    /// </summary>
    internal class Player
    {
        public Player(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public JankenHand Hand { get; set; }
    }
}
