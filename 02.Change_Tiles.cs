using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var buget = double.Parse(Console.ReadLine());
            var floorW = double.Parse(Console.ReadLine());
            var floorH = double.Parse(Console.ReadLine());
            var plochkaA = double.Parse(Console.ReadLine());
            var plochkaAh = double.Parse(Console.ReadLine());
            var plochkaPrice = double.Parse(Console.ReadLine());
            var worker = double.Parse(Console.ReadLine());
            var vFloor = floorW * floorH;
            var vPlochka = plochkaA * plochkaAh / 2.0;
            var plochkaNeed = vFloor / vPlochka;
            var fira = Math.Ceiling(plochkaNeed) + 5;
            var sum = fira * plochkaPrice + worker;
            if (sum <= buget)
            {
                var diff = buget - sum;
                Console.WriteLine("{0:F2} lv left.", diff);
            }
            else
            {
                var diff = sum - buget;
                Console.WriteLine(diff );
            }
        }
    }
}
