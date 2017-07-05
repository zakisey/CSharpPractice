using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCheck2
{
    public partial class Form1 : Form
    {
        private Subject math = new Subject(80, 60, 73);
        private Subject physics = new Subject(50, 50, 65);
        private Subject english = new Subject(100, 70, 77);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitLabels();
        }

        private void InitLabels()
        {
            labelName.Text = "";
            labelResultM.Text = "";
            labelResultP.Text = "";
            labelResultE.Text = "";
            labelCompAvgM.Text = "";
            labelCompAvgP.Text = "";
            labelCompAvgE.Text = "";
            labelTotalM.Text = "/ "  + math.MaxAttendance.ToString();
            labelTotalP.Text = "/ " + physics.MaxAttendance.ToString();
            labelTotalE.Text = "/ " + english.MaxAttendance.ToString();
            labelPassScoreM.Text = math.PassScore.ToString();
            labelPassScoreP.Text = physics.PassScore.ToString();
            labelPassScoreE.Text = english.PassScore.ToString();
            labelAverageM.Text = math.Average.ToString();
            labelAverageP.Text = physics.Average.ToString();
            labelAverageE.Text = english.Average.ToString();
        }

        private void buttonJudge_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int scoreM, scoreP, scoreE, attendanceM, attendanceP, attendanceE;
            int.TryParse(textBoxScoreM.Text, out scoreM);
            int.TryParse(textBoxScoreP.Text, out scoreP);
            int.TryParse(textBoxScoreE.Text, out scoreE);
            int.TryParse(textBoxAttendanceM.Text, out attendanceM);
            int.TryParse(textBoxAttendanceP.Text, out attendanceP);
            int.TryParse(textBoxAttendanceE.Text, out attendanceE);
            Student student = new Student(name, scoreM, scoreP, scoreE, attendanceM, attendanceP, attendanceE);

            labelName.Text = student.Name + "さんの成績";
            labelResultM.Text = math.isPass(student.AttendanceM, student.ScoreM) ? "合格" : "不合格";
            labelResultP.Text = physics.isPass(student.AttendanceP, student.ScoreP) ? "合格" : "不合格";
            labelResultE.Text = english.isPass(student.AttendanceE, student.ScoreE) ? "合格" : "不合格";
            labelCompAvgM.Text = math.isAboveAvg(student.ScoreM) ? "平均点以上" : "平均点未満";
            labelCompAvgP.Text = physics.isAboveAvg(student.ScoreP) ? "平均点以上" : "平均点未満";
            labelCompAvgE.Text = english.isAboveAvg(student.ScoreE) ? "平均点以上" : "平均点未満";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            InitLabels();
            textBoxName.Text = "";
            textBoxScoreM.Text = "";
            textBoxScoreP.Text = "";
            textBoxScoreE.Text = "";
            textBoxAttendanceM.Text = "";
            textBoxAttendanceP.Text = "";
            textBoxAttendanceE.Text = "";
        }

        private void TextBoxScore_Leave(TextBox textBox)
        {
            int score;
            if (!int.TryParse(textBox.Text, out score) && textBox.Text != "")
            {
                MessageBox.Show("無効な入力です。");
                textBox.Focus();
            }
            else if (score < 0 || score > 100)
            {
                MessageBox.Show("得点は0から100の範囲で入力してください。");
                textBox.Focus();
            }
        }

        private void TextBoxAttendance_Leave(TextBox textBox, Subject subject)
        {
            int attendance;
            if (!int.TryParse(textBox.Text, out attendance) && textBox.Text != "")
            {
                MessageBox.Show("無効な入力です。");
                textBox.Focus();
            }
            else if (attendance < 0 || attendance > subject.MaxAttendance)
            {
                MessageBox.Show("出席時数の値が正しくありません。");
                textBox.Focus();
            }
        }

        private void textBoxScoreM_Leave(object sender, EventArgs e)
        {
            TextBoxScore_Leave(textBoxScoreM);
        }

        private void textBoxScoreP_Leave(object sender, EventArgs e)
        {
            TextBoxScore_Leave(textBoxScoreP);
        }

        private void textBoxScoreE_Leave(object sender, EventArgs e)
        {
            TextBoxScore_Leave(textBoxScoreE);
        }

        private void textBoxAttendanceM_Leave(object sender, EventArgs e)
        {
            TextBoxAttendance_Leave(textBoxAttendanceM, math);
        }

        private void textBoxAttendanceP_Leave(object sender, EventArgs e)
        {
            TextBoxAttendance_Leave(textBoxAttendanceP, physics);
        }

        private void textBoxAttendanceE_Leave(object sender, EventArgs e)
        {
            TextBoxAttendance_Leave(textBoxAttendanceE, english);
        }
    }
}
