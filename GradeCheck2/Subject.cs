using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCheck2
{
    class Subject
    {
        public Subject(int maxAttendance, int passScore, int average)
        {
            MaxAttendance = maxAttendance;
            PassScore = passScore;
            Average = average;
        }

        public int MaxAttendance { get; set; }
        public int PassScore { get; set; }
        public int Average { get; set; }

        public bool isPass(int attendance, int score)
        {
            double attendanceRate = (double)attendance / MaxAttendance;
            return (attendanceRate > 0.8 && score >= PassScore);
        }

        public bool isAboveAvg(int score)
        {
            return (score > Average);
        }
     }
}
