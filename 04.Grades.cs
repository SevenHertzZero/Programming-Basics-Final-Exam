using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = int.Parse(Console.ReadLine());
            var sum1 = 0.0;
            var sum2 = 0.0;
            var sum3 = 0.0;
            var sum4 = 0.0;
            var sumA = 0.0;
            for (int i = 1; i <= students; i++)
            {
                var gradeOfaStudent = double.Parse(Console.ReadLine());
                sumA += gradeOfaStudent;
                if (gradeOfaStudent >= 2.00 && gradeOfaStudent <= 2.99)
                {
                    sum1 += 1;
                }
                if (gradeOfaStudent >= 3.00 && gradeOfaStudent <= 3.99)
                {
                    sum2 += 1;
                }
                if (gradeOfaStudent >= 4.00 && gradeOfaStudent <= 4.99)
                {
                    sum3 += 1;
                }
                if (gradeOfaStudent >= 5.00)
                {
                    sum4 += 1;
                }
            }
            var p1 = sum4 / students * 100;
            var p2 = sum3 / students * 100;
            var p3 = sum2 / students * 100;
            var p4 = sum1 / students * 100;
            var qvarage = sumA / students;
            Console.WriteLine("Top students: {0:F2}%\nBetween 4.00 and 4.99: {1:F2}%\nBetween 3.00 and 3.99: {2:F2}%\nFail: {3:F2}%\nAverage: {4:F2}", p1, p2, p3, p4,qvarage);
        }
    }
}
