using System;

namespace T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред - цената на тениската – реално число в интервала [1.00 ... 1000.00]
            double shirtPrice = double.Parse(Console.ReadLine());
            //	На втория ред - сумата, която трябва да достигне, за да спечели топка – реално число в интервала[100.00... 10 000.00]
            double sumGoal = double.Parse(Console.ReadLine());
            //тениски,
            //шорти,75% ot цената на тениските
            double shortsPrice = shirtPrice - (shirtPrice * 0.25);
            //чорапи са 20% от цена на шортите
            double socksPrice = shortsPrice - (shortsPrice * 0.80);
            //бутонки=(тениска +шорти)*2 
            double shoesPrice = (shirtPrice + shortsPrice) * 2;
            double price = shirtPrice + shortsPrice + socksPrice + shoesPrice;

            //пресмятане на 15 % намаление от общата сума
            price = price - price * 0.15;
            double diff = Math.Abs(sumGoal - price);
            //изчислява дали Пепи е спечелил топката ако сметката е  по-висока или равна >= на дадена сума от конзолата
            if (price >= sumGoal)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {price:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {diff:f2} lv. more.");
            }
            //•	Ако топката Е спечелена:
            //   "Yes, he will earn the world-cup replica ball!"
            //  "His sum is {сумата} lv."
            //	Ако топката НЕ Е спечелена:
            //   "No, he will not earn the world-cup replica ball."
            //   "He needs {недостигащи пари} lv. more."

        }
    }
}
