using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initLabels();
        }

        private void initTextBoxes()
        {
            textBoxAttendanceM.Text = "0.0";
            textBoxAttendanceP.Text = "0.0";
            textBoxAttendanceE.Text = "0.0";
            textBoxScoreM.Text = "0";
            textBoxScoreE.Text = "0";
            textBoxScoreP.Text = "0";
        }

        private void initLabels()
        {
            labelResultE.Text = "";
            labelResultM.Text = "";
            labelResultP.Text = "";
            labelCompAvgE.Text = "";
            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
        }

        private void buttonJudge_Click(object sender, EventArgs e)
        {
            const int avgM = 73;
            const int avgP = 65;
            const int avgE = 77;
            double attendanceM, attendanceP, attendanceE;
            int scoreM, scoreP, scoreE;
            if (!double.TryParse(textBoxAttendanceM.Text, out attendanceM) || !int.TryParse(textBoxScoreM.Text, out scoreM))
            {
                labelResultM.Text = "エラー";
                labelCompAvgM.Text = "エラー";
            }
            else
            {
                labelResultM.Text = judgeResult(attendanceM, scoreM);
                labelCompAvgM.Text = judgeAvg(scoreM, avgM);
            }
            if (!double.TryParse(textBoxAttendanceP.Text, out attendanceP) || !int.TryParse(textBoxScoreP.Text, out scoreP))
            {
                labelResultP.Text = "エラー";
                labelCompAvgP.Text = "エラー";
            }
            else
            {
                labelResultP.Text = judgeResult(attendanceP, scoreP);
                labelCompAvgP.Text = judgeAvg(scoreP, avgP);
            }
            if (!double.TryParse(textBoxAttendanceE.Text, out attendanceE) || !int.TryParse(textBoxScoreE.Text, out scoreE))
            {
                labelResultE.Text = "エラー";
                labelCompAvgE.Text = "エラー";
            }
            else
            {
                labelResultE.Text = judgeResult(attendanceE, scoreE);
                labelCompAvgE.Text = judgeAvg(scoreE, avgE);
            }


        }

        private string judgeAvg(int score, int avg)
        {
            if (score >= avg)
            {
                return "平均点以上";
            } else
            {
                return "平均点未満";
            }
        }

        // 出席率と得点から結果を判定して返す 
        private string judgeResult(double attendance, int score)
        {
            if (attendance > 100 || attendance < 0 || score > 100 || score < 0)
            {
                return "エラー";
            }
            else if (attendance >= 80 && attendance <= 100)
            {
                if (score >= 80 && score <= 100)
                {
                    return "A判定";
                }
                else if (score >= 70)
                {
                    return "B判定";
                }
                else if (score >= 60)
                {
                    return "C判定";
                }
                else
                {
                    return "不合格";
                }
            }
            else
            {
                return "不合格";
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            initLabels();
            initTextBoxes();
        }
    }
}
