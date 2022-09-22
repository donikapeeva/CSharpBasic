using System;

namespace T07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //бюджет на Петър дроб 
            double budget = double.Parse(Console.ReadLine());
            //брой видео карти цяло число
            int videocards = int.Parse(Console.ReadLine());
            //брой процесори цяло число
            int procesors = int.Parse(Console.ReadLine());
            //брой рам памет цяло число 
            int ram = int.Parse(Console.ReadLine());
            //видео карта 250лв, процесор- 35% от цената на видео карта, рам 10% от цената на видео карта 
            //изчисляване цена на процесор 
            //изчисляване цена на рам 
            int videoPrice = videocards * 250;
            double procesorPrice = procesors * videoPrice * 0.35;
            double ramPrice = ram * videoPrice * 0.10;
            //изчисляване на обща сума  
            double totalPrice = videoPrice + procesorPrice + ramPrice;
            //ако видео картите са повече от процесорите обща сума -15%
            if (videocards > procesors)
            {
                totalPrice = totalPrice - totalPrice * 0.15;
            }
            //изчисляване дали бюджета ще стигне
            //1. ако бюджетът стига се отпечатва "You have {остатъчен бюджет} leva left!"  
            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {(budget - totalPrice):f2} leva left!");
            }
            //2. ако бюджетът не е достатъчен се отпечатва "Not enough money! You need {нужна сума} leva more!" 
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalPrice - budget):f2} leva more!");
            }
        }
    }
}
