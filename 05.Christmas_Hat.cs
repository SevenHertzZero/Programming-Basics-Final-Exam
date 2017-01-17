using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(@"{0}/|\{0}", new string('.',n*2 - 1));
            Console.WriteLine(@"{0}\|/{0}", new string('.', n*2 - 1));
            Console.WriteLine(@"{0}***{0}", new string('.', n*2 - 1));
            var dots = ((n * 4) - 4)/2;
            var ldash = 1;
            var rdash = 1;
            for (int m = 1; m <= n * 2 - 1; m++)
            {
                Console.WriteLine("{0}*{1}*{2}*{0}", new string('.', dots), new string('-', ldash), new string('-', rdash));
                dots -= 1;
                ldash++;
                rdash++;             
            }
            Console.WriteLine("{0}", new string('*', n * 4 + 1));
            for (int i = 1; i <= n * 2; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine("{0}", new string('*', n * 4 + 1));
        }
    }
}
