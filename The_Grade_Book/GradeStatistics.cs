using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Grade_Book
{
    class GradeStatistics
    {
        public GradeStatistics()
        {
            HighGrade = 0;
            LowGrade = float.MaxValue;
        }
        public float AvgGrade;
        public float HighGrade;
        public float LowGrade;
    }
}
