using System;

namespace Т01.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четат се долари добле
            double dollars = double.Parse(Console.ReadLine());
            //1 USD = 1.79549 BGN.
            double price = 1.79549;
            //пресмятане на долари в левове
            double bgn = dollars * price;
            //принтиране
            Console.WriteLine(bgn);
        }
    }
}
