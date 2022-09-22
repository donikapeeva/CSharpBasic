using System;

namespace Т04._FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // инт бюджет
            int budget = int.Parse(Console.ReadLine());
            //стринг сезон
            string season = Console.ReadLine();
            // стринг рибари
            int fishermen = int.Parse(Console.ReadLine());
            double price = 0.00;
            switch (season)
            {
                case "Spring":
                    {
                        price = 3000;
                    }
                    break;
                case "Summer":
                    {
                        price = 4200;
                    }
                    break;
                case "Autumn":
                    {
                        price = 4200;
                    }
                    break;
                case "Winter":
                    {
                        price = 2600;
                    }
                    break;

                default:
                    break;
            }
            // сезон и наем "Spring", "Summer", "Autumn", "Winter"
            // 1. пролет 3000лв
            // 2 лято и есен 4200лв
            //3. зима 2600лв
            // отстъпка
            // 1. <= 6 човека 10%
            //2. <= 11 човека 15% 
            //3. > 11 човека 25%
            // ако са четен брой пролет, лято, зима имат още 5% отстъпка(без есен) 
            if (fishermen <= 6)
            {
                price = price - price * 0.10;
            }
            else if (fishermen <= 11)
            {
                price = price - price * 0.15;
            } 
            else  
            {
                price = price - price * 0.25;
            }
            if ((fishermen%2 == 0) && (season != "Autumn"))
            {
                price = price - price * 0.05;
            } 
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {(budget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(price - budget):f2} leva.");
            }
            //проверка дали бюджета е достатъчен и отпечатване •	Ако бюджетът е достатъчен:
            // "Yes! You have {останалите пари} leva left."
            // Ако бюджетът НЕ Е достатъчен:"Not enough money! You need {сумата, която не достига} leva."

        }
    }
}
