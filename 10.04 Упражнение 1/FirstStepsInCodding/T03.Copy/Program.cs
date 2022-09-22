using System;

namespace T03.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Депозирана сума – реално число в интервала [100.00 … 10000.00]
            double deposit = double.Parse(Console.ReadLine());
            //2.Срок на депозита(в месеци) – цяло число в интервала[1…12]
            int time =int.Parse(Console.ReadLine());
            //3.Годишен лихвен процент – реално число в интервала[0.00 …100.00]
            double interest = double.Parse(Console.ReadLine());
            //изчисляване на сума в края на депозитния период
            //сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)
            double interestForYear = deposit * (interest/100);
            double interestForMonth = interestForYear / 12;
            double sum = deposit + time * interestForMonth;

            //отпечатване на сумата
            Console.WriteLine(sum);
        }
    }
}
