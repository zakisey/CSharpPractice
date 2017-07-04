using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initLabel();
        }

        private void initLabel()
        {
            labelDayOfWeek.Text = "";
        }

        public bool isLeapYear(int year)
        {
            if (year % 4 == 0 && year % 100 != 0)
            {
                return true;
            }
            else if (year % 400 == 0)
            {
                return true;
            }
            return false;
        }

        public bool isValidDate(int year, int month, int day)
        {
            List<int> month31 = new List<int> { 1, 3, 5, 7, 8, 10, 12 };
            List<int> month30 = new List<int> { 4, 6, 9, 11 };
            if (month == 2)
            {
                if (isLeapYear(year))
                {
                    return (day >= 1 && day <= 29);
                }
                else
                {
                    return (day >= 1 && day <= 28);
                }
            }
            else if (month31.Contains(month))
            {
                return (day >= 1 && day <= 31);
            }
            else if (month30.Contains(month))
            {
                return (day >= 1 && day <= 30);
            }

            return false;
        }

        public int calcDayOfWeek(int year, int month, int day)
        {
            if (!isValidDate(year, month, day))
            {
                return -1;
            }

            if (month == 1 || month == 2)
            {
                month += 12;
                year -= 1;
            }

            int ret = (5 * year / 4 - year / 100 + year / 400 + (26 * month + 16) / 10 + day) % 7;

            return ret;
        }

        private void buttonDayOfWeekCalc_Click(object sender, EventArgs e)
        {
            int year;
            if (!int.TryParse(textBoxYear.Text, out year))
            {
                labelDayOfWeek.Text = "西暦年エラー";
            }
            else if (year < 0)
            {
                labelDayOfWeek.Text = "西暦年エラー";
            }
            else
            {
                int month = (int)numericUpDownMonth.Value;
                int day = (int)numericUpDownDay.Value;
                int dayOfWeek = calcDayOfWeek(year, month, day);
                if (dayOfWeek == -1)
                {
                    labelDayOfWeek.Text = "あり得ない日付";
                }
                else
                {
                    string[] days = { "日", "月", "火", "水", "木", "金", "土" };

                    labelDayOfWeek.Text = days[dayOfWeek] + "曜日です";
                }
            }
        }
    }
}
