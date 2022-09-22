using System;

namespace T02.FamilyTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Бюджетът, с който разполагат – реално число в интервала [1.00 … 10000.00]
            double budget = double.Parse(Console.ReadLine());
            //	Брой нощувки – цяло число в интервала[0 … 1000]
            int days = int.Parse(Console.ReadLine());
            //	Цена за нощувка – реално число в интервала[1.00 … 500.00]
            double pricePerNight= double.Parse(Console.ReadLine());
            //Процент за допълнителни разходи – цяло число в интервала[0 … 100]
            double percent= double.Parse(Console.ReadLine());


            if (days > 7)
            {
                pricePerNight = pricePerNight * 0.95;

            }
            double hotelPrice = days * pricePerNight;
            double percentMoney = budget * percent / 100;
                double totalMoneyNeeded = hotelPrice +percentMoney;
                double finalPriceDifference = Math.Abs(totalMoneyNeeded-budget);
            if (budget >= totalMoneyNeeded)
            {
                Console.WriteLine($"Ivanovi will be left with {finalPriceDifference:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{finalPriceDifference:f2} leva needed.");
            }
            //Отпечатването на конзолата зависи от резултата:
            //	Ако сумата е достатъчна:
            //  "Ivanovi will be left with {останали пари след почивката} leva after vacation."
            //	Ако НЕ е достигната сумата:
            //   "{парите нужни до достигане на целта} leva needed."


        }
    }
}
