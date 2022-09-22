using System;

namespace _01.USDToBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четем USD от конзолата 
            double usd = double.Parse(Console.ReadLine());
            //преобразуваме сумата в лева 1 USD = 1.79549 BGN  
            double bgn = usd * 1.79549;
            //извеждане на резултат от конзолата 
            Console.WriteLine(bgn);
        }
    }
}
