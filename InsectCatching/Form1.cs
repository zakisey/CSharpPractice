using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsectCatching
{
    public partial class Form1 : Form
    {
        const int maxCount = 60;
        private int count;
        private int score;
        private Insect[] insects;
                
        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                labelScore.Text = "得点: " + score;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                labelTime.Text = "残り時間: " + (maxCount - count);
                insects[count].Activate();
                
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void InitInsects()
        {
            Random random = new Random();
            insects = new Insect[maxCount + 1];
            for (int i = 0; i < insects.Length; i++)
            {
                int rand = random.Next(3);
                if (rand == 0)
                {
                    insects[i] = new Tonbo(this);
                }
                else if (rand == 1)
                {
                    insects[i] = new Butterfly(this);
                }
                else
                {
                    insects[i] = new Kabuto(this);
                }
                insects[i].Inactivate();
                insects[i].AddEventHandler(new EventHandler(picture_Click));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < count + 1; i++)
            {
                insects[i].Move();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Count += 1;
            if (Count == maxCount)
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            button1.Enabled = true;
            foreach (Insect insect in insects)
            {
                insect.Inactivate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitInsects();
            Count = 0;
            Score = 0;
            insects[0].Activate();
            timer1.Enabled = true;
            timer2.Enabled = true;
            button1.Enabled = false;
        }

        private void picture_Click(object sender, EventArgs e)
        {
            Score += 1;
            ((PictureBox)sender).Enabled = false;
            ((PictureBox)sender).Visible = false;
        }
    }
}
