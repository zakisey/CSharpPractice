using System;

namespace Janken
{
    internal class Computer : Player
    {
        public Computer(string name)
            : base(name)
        {
        }

        public void SetRandomHand(Random random)
        {
            Hand = (JankenHand)random.Next(3);
        }
    }
}
