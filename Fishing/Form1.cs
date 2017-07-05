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
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iwashi = new Iwashi(-100, 100, 100, 100);
            iwashi.AddToForm(this);
            TimeElapsed = 0.0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double timeSpan = (double)timer1.Interval / 1000.0;
            TimeElapsed += timeSpan;
            iwashi.Move(timeSpan);
        }
    }
}
