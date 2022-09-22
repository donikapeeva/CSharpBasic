using System;

namespace T12._TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Град	0 ≤ s ≤ 500||500 < s ≤ 1 000 ||	1 000 < s ≤ 10 000 ||s > 10 000
            //Sofia   5 %             7 %                 8 %               12 %
            //Varna   4.5 %           7.5 %               10 %              13 %
            //Plovdiv 5.5 %           8 %                 12 %              14.5 % 

            //city string 
            // продажби доубле
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commission = 0; 

            switch (town)
            {
                case "Sofia": 
                    if (0 <= sales && sales <= 500)
                    {
                        commission = 0.05;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commission = 0.07;
                    } 
                    else if (1000 < sales && sales <= 10000) 
                    {
                        commission = 0.08;
                    } 
                    else if (sales > 10000) 
                    {
                        commission = 0.12;
                    } 
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (0 <= sales && sales <= 500)
                    {
                        commission = 0.045;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commission = 0.075;
                    }
                    else if (1000 < sales && sales <= 10000) 
                    {
                        commission = 0.1;
                    }
                    else if (sales > 10000)
                    {
                        commission = 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (0 <= sales && sales <= 500)
                    {
                        commission = 0.055;
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        commission = 0.08;
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        commission = 0.12;
                    }
                    else if (sales > 10000)
                    {
                        commission = 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            double totalCommission = sales * commission;
            //изчисляване на комисионна 
            if (commission > 0)
            {
                Console.WriteLine($"{totalCommission:f2}");
            }

        }
    }
}
