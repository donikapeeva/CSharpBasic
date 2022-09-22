using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Депозирана сума – реално число в интервала [100.00 … 10000.00]
            //2.Срок на депозита(в месеци) – цяло число в интервала[1…12]
            //3.Годишен лихвен процент – реално число в интервала[0.00 …100.00]
            double deposite = double.Parse(Console.ReadLine());
            int depositeTerm = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());
            //1. Изчисляваме натрупаната лихва: 200 * 0.057 (5.7%) = 11.40 лв.
            //2.Изчисляваме лихвата за 1 месец: 11.40 лв. / 12 месеца = 0.95 лв.
            //3.Общата сума е: 200 лв. + 3 * 0.95 лв. = 202.85 лв. 
            double accruedInterest = deposite * (annualInterestRate / 100);
            double monthInterest = accruedInterest / 12;
            double totalAmount = deposite + depositeTerm * monthInterest;
            //отпечатване на обща сума в края на срока 
            Console.WriteLine(totalAmount);

        }
    }
}
