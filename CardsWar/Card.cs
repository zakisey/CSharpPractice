using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CardsWar
{
    class Card : Button
    {
        public int width = 50;
        public int height = 70;
        private Color colorFront = Color.White;
        private Color colorBack = Color.Black;
        private bool isOpen;

        public string Suit { get; set; }
        public bool IsOpen
        {
            get
            {
                return isOpen;
            }
            set
            {
                isOpen = value;
                Text = isOpen ? Suit : "";
                BackColor = isOpen ? colorFront : colorBack;
                Enabled = (!isOpen && IsOwnedByPlayer);
            }
        }
        public bool IsOwnedByPlayer { get; set; }

        public Card(string _suit, bool _isOwnedByPlayer)
        {
            Width = width;
            Height = height;
            Suit = _suit;
            IsOwnedByPlayer = _isOwnedByPlayer;
            IsOpen = false;
        }

        public void Flip()
        {
            IsOpen = !IsOpen;
        }

        public int ToNumber()
        {
            switch (Suit)
            {
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return int.Parse(Suit);
            }
        }
    }
}
