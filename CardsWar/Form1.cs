using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardsWar
{
    public partial class Form1 : Form
    {
        private Player player;
        private Computer computer;
        private string[] suits = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        public Form1()
        {
            InitializeComponent();
        }

        private string[] CreateRandomSuits(int count)
        {
            Random rand = new Random();
            string[] tempSuits = new string[suits.Length * count];
            Array.Copy(suits, 0, tempSuits, 0, suits.Length);
            Array.Copy(suits, 0, tempSuits, suits.Length, suits.Length);
            string[] randomSuits = tempSuits.OrderBy(x => rand.Next()).ToArray();

            return randomSuits;
        }

        private void SetScoreLabels()
        {
            labelPlayerScore.Text = "得点: " + player.Score;
            labelComputerScore.Text = "得点: " + computer.Score;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitGame();
        }

        private void InitGame()
        {
            string[] randomSuits = CreateRandomSuits(2);
            string[] playerSuits = new string[suits.Length];
            string[] computerSuits = new string[suits.Length];
            Array.Copy(randomSuits, 0, playerSuits, 0, suits.Length);
            Array.Copy(randomSuits, suits.Length, computerSuits, 0, suits.Length);
            player = new Player(playerSuits, 200, 300);
            player.AddEventHandlerToCards(new EventHandler(cardButton_Click));
            computer = new Computer(computerSuits, 200, 50);
            Controls.AddRange(player.Deck);
            Controls.AddRange(computer.Deck);
            SetScoreLabels();
            buttonReset.Enabled = false;
            labelResult.Text = "カードを選んでください。";
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            Card playerCard = (Card)sender;
            playerCard.Flip();
            Card computerCard = computer.RandomFlip();
            if (playerCard.ToNumber() > computerCard.ToNumber())
            {
                player.Score += 2;
                labelResult.Text = "あなたの勝ちです。次のカードを選んでください。";
            } 
            else if (playerCard.ToNumber() < computerCard.ToNumber())
            {
                computer.Score += 2;
                labelResult.Text = "あなたの負けです。次のカードを選んでください。";
            }
            else
            {
                player.Score += 1;
                computer.Score += 1;
                labelResult.Text = "引き分けです。次のカードを選んでください。";
            }
            SetScoreLabels();

            if (!player.CheckCardRemains())
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            if (player.Score > computer.Score)
            {
                labelResult.Text = "あなたの勝ちです。";
            }
            else if (player.Score < computer.Score)
            {
                labelResult.Text = "あなたの負けです。";
            }
            else
            {
                labelResult.Text = "引き分けです。";
            }
            buttonReset.Enabled = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (Card card in player.Deck)
            {
                Controls.Remove(card);
            }
            foreach (Card card in computer.Deck)
            {
                Controls.Remove(card);
            }
            InitGame();
        }
    }
}
