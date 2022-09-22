using System;

namespace T02.FamilyTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се
            //	Бюджетът, с който разполагат – реално число в интервала[1.00 … 10000.00]
            double budget = double.Parse(Console.ReadLine());
            //	Брой нощувки – цяло число в интервала[0 … 1000]
            int nights = int.Parse(Console.ReadLine());
            //	Цена за нощувка – реално число в интервала[1.00 … 500.00]
            double pricePerNight= double.Parse(Console.ReadLine());
            //	Процент за допълнителни разходи – цяло число в интервала[0 … 100] % от бюджета 
            int percent= int.Parse(Console.ReadLine());
            //изчисляване на процента за допълнителни разходи
            
            double totalSum = 0;
            //ако нощувките са повече от 7, цената за нощувка се намаля с 5%.
            if (nights > 7)
            {
                pricePerNight = pricePerNight - (pricePerNight * 0.05);
            }
            
            
            double totalNightPrice = nights * pricePerNight;
            double totalPercent = budget * (percent / 100.0);
            totalSum = totalNightPrice + totalPercent;
            if (totalSum > budget)
            {
                double needMoney = Math.Abs(budget - totalSum);
                Console.WriteLine($"{needMoney:f2} leva needed.");
                
            }
            else
            {
                double leftMoney = budget - totalSum;
                Console.WriteLine($"Ivanovi will be left with {leftMoney:f2} leva after vacation.");

            }
            

            //изчисление дали бюджета ще стигне 

            //ако сумата е достатъчна се принтира o	"Ivanovi will be left with {останали пари след почивката} leva after vacation."
            //ако сумата не е достатъчна o	"{парите нужни до достигане на целта} leva needed."
        }
    }
}
