using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Grade_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Het gemiddelde van de punten: "+ stats.AvgGrade);
            Console.WriteLine("Hoogst behaalde score: " + stats.HighGrade);
            Console.WriteLine("Laagst behaalde score: " + stats.LowGrade);



         
        }
    }
}
