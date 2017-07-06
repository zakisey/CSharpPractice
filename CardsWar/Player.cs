using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsWar
{
    class Player
    {
        public Card[] Deck { get; set; }
        public int Score { get; set; }
        public Player(string[] suits, int left, int top)
        {
            Deck = CreateDeck(suits, left, top);
            Score = 0;
        }

        private Card[] CreateDeck(string[] suits, int left, int top)
        {
            Card[] _deck = new Card[suits.Length];
            for (int i = 0; i < suits.Length; i++)
            {
                Card card = new Card(suits[i], true);
                card.Location = new System.Drawing.Point(left + card.Width * i, top);
                _deck[i] = card;
            }
            return _deck;
        }

        public void AddEventHandlerToCards(EventHandler eh)
        {
            foreach (Card card in Deck)
            {
                card.Click += eh;
            }
        }

        public bool CheckCardRemains()
        {
            foreach (Card card in Deck)
            {
                if (!card.IsOpen)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
