using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCheck2
{
    class Student
    {
        public Student(string name, int scoreM, int scoreP, int scoreE, int attendanceM, int attendanceP, int attendanceE)
        {
            Name = name;
            ScoreM = scoreM;
            ScoreP = scoreP;
            ScoreE = scoreE;
            AttendanceM = attendanceM;
            AttendanceP = attendanceP;
            AttendanceE = attendanceE;
        }

        public string Name { get; set; }
        public int ScoreM { get; set; }
        public int ScoreP { get; set; }
        public int ScoreE { get; set; }
        public int AttendanceM { get; set; }
        public int AttendanceP { get; set; }
        public int AttendanceE { get; set; }

     }
}
