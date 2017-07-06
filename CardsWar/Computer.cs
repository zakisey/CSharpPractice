using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsWar
{
    class Computer : Player
    {
        public Computer(string[] suits, int left, int top) : base(suits, left, top)
        {
            foreach (Card card in Deck)
            {
                card.IsOwnedByPlayer = false;
            }
        }

        public Card RandomFlip()
        {
            Random random = new Random();
            if (!CheckCardRemains())
            {
                Console.WriteLine("a");
                return null;
            }
            while (true)
            {
                int rand = random.Next(Deck.Length);
                Console.Write(rand);
                if (!Deck[rand].IsOpen)
                {
                    Deck[rand].Flip();
                    return Deck[rand];
                }
            }
        }

    }
}
