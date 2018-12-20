using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Grade_Book
{
    class GradeBook
    {

        public GradeBook()
        {
            grades = new List<float>();
        }
        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            
            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighGrade = Math.Max(grade, stats.HighGrade);
                stats.LowGrade = Math.Min(grade, stats.LowGrade);
                sum += grade;
            }
            if (grades.Count != 0)
            {
                stats.AvgGrade = sum / grades.Count;
            }
            return stats;
        }



        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        List<float> grades;
    }
}
