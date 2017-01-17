using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var broiHrizntemi = int.Parse(Console.ReadLine());
            var broiRozi = int.Parse(Console.ReadLine());
            var broiLaleta = int.Parse(Console.ReadLine());
            var sezon = Console.ReadLine();
            var praznik = Console.ReadLine();
            var aranjirane = 2;
            if (sezon == "Spring")
            {
                var price = broiHrizntemi * 2.00 + broiRozi * 4.10 + broiLaleta * 2.50;
                var allFlowers = broiHrizntemi + broiLaleta + broiRozi;
                if (praznik == "Y")
                {
                    var holydayPrice = price + (price * 0.15);
                    if (broiLaleta > 7 && allFlowers <= 20)
                    {
                        var priceBuket = holydayPrice - (holydayPrice * 0.05);
                        Console.WriteLine("{0:F2}", priceBuket + aranjirane);
                    }
                    else if (broiLaleta > 7 && allFlowers > 20)
                    {
                        var discountFive = holydayPrice - (holydayPrice * 0.05);
                        var discountTwenty = discountFive - (discountFive * 0.2);
                        Console.WriteLine("{0:F2}", discountTwenty + aranjirane);
                    }
                    else if (broiLaleta <= 7 && allFlowers > 20)
                    {
                        var discountTwenty = holydayPrice - (holydayPrice * 0.2);
                        Console.WriteLine("{0:F2}", discountTwenty + aranjirane);
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}", holydayPrice + aranjirane);
                    }
                }
                else if (praznik == "N")
                {
                    if (broiLaleta > 7 && allFlowers <= 20)
                    {
                        var priceBuket = price - (price * 0.05);
                        Console.WriteLine("{0:F2}", priceBuket + aranjirane);
                    }
                    else if (broiLaleta > 7 && allFlowers > 20)
                    {
                        var discountFive = price - (price * 0.05);
                        var discountTwenty = discountFive - (discountFive * 0.2);
                        Console.WriteLine("{0:F2}", discountTwenty + aranjirane);
                    }
                    else if (broiLaleta <= 7 && allFlowers > 20)
                    {
                        var discountTwenty = price - (price * 0.2);
                        Console.WriteLine("{0:F2}", discountTwenty + aranjirane);
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}", price + aranjirane);
                    }
                }
            }
            else if (sezon == "Summer")
            {
                var price = broiHrizntemi * 2.00 + broiRozi * 4.10 + broiLaleta * 2.50; 
                var allFlowers = broiHrizntemi + broiLaleta + broiRozi;
                if (praznik == "Y")
                {
                    var holydayPrice = price + (price * 0.15);
                    if (allFlowers <= 20)
                    {
                        Console.WriteLine("{0:F2}", holydayPrice + aranjirane);
                    }
                    else if (allFlowers > 20)
                    {
                        var discountTwenty = holydayPrice - (holydayPrice * 0.2);
                        Console.WriteLine("{0:F2}", discountTwenty + aranjirane);
                    }
                }
                else if (praznik == "N")
                {
                    if (allFlowers <= 20)
                    {
                        Console.WriteLine("{0:F2}", price + aranjirane);
                    }
                    else if (allFlowers > 20)
                    {
                        var discountTwenty = price - (price * 0.2);
                        Console.WriteLine("{0:F2}", discountTwenty + aranjirane);
                    }
                }
            }
            else if (sezon == "Autumn")
            {
                var price = broiHrizntemi * 3.75 + broiRozi * 4.50 + broiLaleta * 4.15;
                var allFlowers = broiHrizntemi + broiLaleta + broiRozi;
                if (praznik == "Y")
                {
                    var holydayPrice = price + (price * 0.15);
                    if (allFlowers <= 20)
                    {
                        Console.WriteLine("{0:F2}", holydayPrice + aranjirane);
                    }
                    else if (allFlowers > 20)
                    {
                        var discountTwenty = holydayPrice - (holydayPrice * 0.2);
                        Console.WriteLine("{0:F2}", discountTwenty + aranjirane);
                    }
                }
                else if (praznik == "N")
                {
                    if (allFlowers <= 20)
                    {
                        Console.WriteLine("{0:F2}", price + aranjirane);
                    }
                    else if (allFlowers > 20)
                    {
                        var discountTwenty = price - (price * 0.2);
                        Console.WriteLine("{0:F2}", discountTwenty + aranjirane);
                    }
                }
            }
            else if (sezon == "Winter")
            {
                var price = broiHrizntemi * 3.75 + broiRozi * 4.50 + broiLaleta * 4.15;
                var allFlowersW = broiHrizntemi + broiLaleta + broiRozi;
                if (praznik == "Y")
                {
                    var holydayPrice = price + (price * 0.15);
                    if (broiRozi >= 10 && allFlowersW <= 20)
                    {
                        var priceBuket = holydayPrice - (holydayPrice * 0.1);
                        Console.WriteLine("{0:F2}", priceBuket + aranjirane);
                    }
                    else if (broiRozi >= 10 && allFlowersW > 20)
                    {
                        var discountFive = holydayPrice - (holydayPrice * 0.1);
                        var discountTwenty = discountFive - (discountFive * 0.2);
                        Console.WriteLine("{0:F2}", discountTwenty + aranjirane);
                    }
                    else if (broiRozi < 10 && allFlowersW > 20)
                    {
                        var discountTwenty = holydayPrice - (holydayPrice * 0.2);
                        Console.WriteLine("{0:F2}", discountTwenty + aranjirane);
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}", holydayPrice + aranjirane);
                    }
                }
                else if (praznik == "N")
                {
                    if (broiRozi >= 10 && allFlowersW <= 20)
                    {
                        var priceBuket = price - (price * 1);
                        Console.WriteLine("{0:F2}", priceBuket + aranjirane);
                    }
                    else if (broiRozi >= 10 && allFlowersW > 20)
                    {
                        var discountFive = price - (price * 0.1);
                        var discountTwenty = discountFive - (discountFive * 0.2);
                        Console.WriteLine("{0:F2}", discountTwenty + aranjirane);
                    }
                    else if (broiRozi < 10 && allFlowersW > 20)
                    {
                        var discountTwenty = price - (price * 0.2);
                        Console.WriteLine("{0:F2}", discountTwenty + aranjirane);
                    }
                    else
                    {
                        Console.WriteLine("{0:F2}", price + aranjirane);
                    }
                }
            }
          }
        }
    }
