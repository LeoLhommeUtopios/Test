﻿namespace Exercice
{
    public class Exercice1
    {
        public int Score { get; set; }
        public int AttendancePercentage { get; set; }

        public char GetGrade()
        {
            if (Score > 90 && AttendancePercentage > 70) return 'A';
            else if (Score > 80 && AttendancePercentage > 60) return 'B';
            else if (Score > 60 && AttendancePercentage > 60) return 'C';
            else return 'F';
        }
    }
}
