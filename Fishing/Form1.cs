using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    public partial class Form1 : Form
    {
        private Iwashi iwashi;
        private Utsubo utsubo;
        private Ankou ankou;
        private double timeElapsed;
        private int score;
        private bool isAtDay = true;

        public double TimeElapsed
        {
            get { return timeElapsed; }
            set
            {
                timeElapsed = value;
                labelTime.Text = "残り時間: " + (60 - (int)timeElapsed) + "秒";
                if (timeElapsed % 15 <= 10)
                {
                    IsAtDay = true;
                }
                else
                {
                    IsAtDay = false;
                }
                if (timeElapsed >= 60)
                {
                    timer1.Enabled = false;
                }
            }
        }

        public int Score
        {
            get { return score; }
            set
            {
                score = value;
                labelScore.Text = "得点: " + score;
            }
        }

        public bool IsAtDay
        {
            get { return isAtDay; }
            set
            {
                isAtDay = value;
                if (isAtDay)
                {
                    BackColor = System.Drawing.Color.Aqua;
                }
                else
                {
                    BackColor = System.Drawing.Color.RoyalBlue;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iwashi = new Iwashi(50);
            utsubo = new Utsubo(80);
            ankou = new Ankou(120);
            TimeElapsed = 0.0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double timeSpan = (double)timer1.Interval / 1000.0;
            TimeElapsed += timeSpan;
            iwashi.Move(isAtDay, timeSpan);
            if (iwashi.left > this.Right)
            {
                iwashi.Respawn();
            }
            pictureBoxIwashi.Left = iwashi.left;
            utsubo.Move(isAtDay, timeSpan);
            if (utsubo.left > this.Right)
            {
                utsubo.Respawn();
            }
            pictureBoxUtsubo.Left = utsubo.left;
            ankou.Move(isAtDay, timeSpan);
            if (ankou.left > this.Right)
            {
                ankou.Respawn();
            }
            pictureBoxAnkou.Left = ankou.left;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '1' && e.KeyChar <= '3')
            {
                if(iwashi.TryBite(isAtDay, pictureBoxIwashi.Right - pictureBoxBaitS.Right))
                {
                    Score += int.Parse(e.KeyChar.ToString());
                }
            }
            else if (e.KeyChar >= '7' && e.KeyChar <= '9')
            {
                if (utsubo.TryBite(isAtDay, pictureBoxUtsubo.Right - pictureBoxBaitL.Right))
                {
                    Score += int.Parse(e.KeyChar.ToString());
                }
            }
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                if (ankou.TryBite(isAtDay, pictureBoxAnkou.Right - pictureBoxBaitM.Right))
                {
                    Score += int.Parse(e.KeyChar.ToString());
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
