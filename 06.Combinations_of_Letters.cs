using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_CSHarp_12_18_16
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = char.Parse( Console.ReadLine());
            var l2 = char.Parse(Console.ReadLine());
            var l3 = char.Parse(Console.ReadLine());
            var counterOfCombinations = 0;
            for (char i = l1; i <= l2; i++)
            {
                for (char j = l1; j <= l2; j++)
                {
                    for (char k = l1; k <= l2 ; k++)
                    {                       
                        if (l3 == i || l3 == j || l3 == k)
                        {
                            Console.Write("");
                        }
                        else
                        {
                            counterOfCombinations++;
                            Console.Write("{0}{1}{2} ", (char)i, (char)j, (char)k);
                        }                       
                    }
                }
            }
            Console.WriteLine(counterOfCombinations);
        }
    }
}
