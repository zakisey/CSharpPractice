using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmTimer
{
    public partial class Form1 : Form
    {
        private bool isTimerSet = false;
        private int timerHour = 0;
        private int timerMin = 0;
        private int timerSec = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDateLabel();
            SetTimer();
        }

        private void SetDateLabel()
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToLongTimeString();
            labelDate.Text = now.ToString("yyyy年MM月dd日(ddd)");
        }

        private void SetTimer()
        {
            if (timerHour != 0 || timerMin != 0 || timerSec != 0)
            {
                labelStatus.Text = "♪ " + timerHour + ":" + timerMin + ":" + timerSec;
                isTimerSet = true;
            } else
            {
                labelStatus.Text = "";
                isTimerSet = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetDateLabel();

            if (isTimerSet)
            {
                DateTime now = DateTime.Now;
                if (timerHour == now.Hour && timerMin == now.Minute && timerSec == now.Second)
                {
                    timerHour = 0;
                    timerMin = 0;
                    timerSec = 0;
                    SetTimer();
                    MessageBox.Show("時間ですよ！", "アラーム", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            timerHour = 0;
            timerMin = 0;
            timerSec = 0;
            SetTimer();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                timerHour = form2.timerHour;
                timerMin = form2.timerMin;
                timerSec = form2.timerSec;
                SetTimer();
            }
            form2.Dispose();
        }
    }
}
