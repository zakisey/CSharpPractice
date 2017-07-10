using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    internal class Player
    {
        public JankenHand Hand { get; set; }

        public Player()
        {
        }
    }
}
