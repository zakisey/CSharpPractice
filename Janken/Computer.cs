using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janken
{
    class Computer : Player
    {
        public Computer()
        {
        }

        public void SetRandomHand(Random random)
        {
            Hand = (JankenHand)random.Next(3);
        }
    }
}
