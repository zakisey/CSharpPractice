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
    public partial class Form2 : Form
    {
        public int timerHour = 0;
        internal int timerMin = 0;
        internal int timerSec = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            numericUpDownAlmHour.Value = now.Hour;
            numericUpDownAlmMnt.Value = now.Minute;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonAlarm.Checked)
            {
                timerHour = (int)numericUpDownAlmHour.Value;
                timerMin = (int)numericUpDownAlmMnt.Value;
                timerSec = 0;
            }
            else if (radioButtonTimer.Checked)
            {
                DateTime now = DateTime.Now;
                now = now.AddMinutes((double)numericUpDownTimMnt.Value);
                now = now.AddSeconds((double)numericUpDownTimSec.Value);
                timerHour = now.Hour;
                timerMin = now.Minute;
                timerSec = now.Second;
            }
        }

        private void numericUpDownAlmHour_ValueChanged(object sender, EventArgs e)
        {
            radioButtonAlarm.Checked = true;
        }

        private void numericUpDownAlmMnt_ValueChanged(object sender, EventArgs e)
        {
            radioButtonAlarm.Checked = true;
        }

        private void numericUpDownTimMnt_ValueChanged(object sender, EventArgs e)
        {
            radioButtonTimer.Checked = true;
        }

        private void numericUpDownTimSec_ValueChanged(object sender, EventArgs e)
        {
            radioButtonTimer.Checked = true;
        }
    }
}
