using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = double.Parse(Console.ReadLine());
            var timeOne = double.Parse(Console.ReadLine());
            var timeTwo = double.Parse(Console.ReadLine());
            var timeThree = double.Parse(Console.ReadLine());
            var vOne = speed * (timeOne / 60.0);
            var vTwo = (speed + (speed * 0.1)) * (timeTwo / 60.0);
            var vThree = ((speed + (speed * 0.1)) - ((speed + (speed * 0.1)) * 0.05)) * (timeThree / 60.0);
            var v = vOne + vTwo + vThree;
            Console.WriteLine("{0:F2}", v);
            Console.WriteLine($"{v}");
        }
    }
}
