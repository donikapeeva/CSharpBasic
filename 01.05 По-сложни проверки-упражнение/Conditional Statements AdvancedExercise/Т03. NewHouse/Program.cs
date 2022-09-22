using System;

namespace Т03._NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се вид цвете "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus" string
            string flower = Console.ReadLine();
            // чете се брой цветя int
            int numberOfFlowers = int.Parse(Console.ReadLine());
            // бюджет int 
            int budget = int.Parse(Console.ReadLine());
            double Price = 0;
            double totalPrice = 0;
            switch (flower)
            {
                case "Roses": //"Roses" 1*5лв ако roses>80 - отстъпка -10% от крайна цена
                    { 
                        if (numberOfFlowers > 80)
                        {
                           Price = numberOfFlowers * 5;
                            totalPrice = Price - Price * 0.10;
                        }
                        else
                        {
                            totalPrice = numberOfFlowers * 5;
                        }
                    }
                    break;
                case "Dahlias": //"Dahlias" 1*3.80 ако dahlias>90 отстъпка -15% от крайна цена
                    {
                        if (numberOfFlowers > 90)
                        {
                            Price = numberOfFlowers * 3.80;
                            totalPrice = Price - Price * 0.15;
                        }
                        else
                        {
                            totalPrice = numberOfFlowers * 3.80;
                        }
                    }
                    break;
                case "Tulips": //"Tulips" 1*2.80лв ако tulips >80 отстъпка -15% от крайна цена
                    {
                        if (numberOfFlowers > 80)
                        {
                            Price = numberOfFlowers * 2.80;
                            totalPrice = Price - Price * 0.15;
                        }
                        else
                        {
                            totalPrice = numberOfFlowers * 2.80;
                        }
                    }
                    break;
                case "Narcissus": //"Narcissus" 1*3лв ако "Narcissus" <120 +15% върху крайна цена
                    {
                        if (numberOfFlowers < 120)
                        {
                            Price = numberOfFlowers * 3.00;
                            totalPrice = Price + Price * 0.15;
                        }
                        else
                        {
                            totalPrice = numberOfFlowers * 3.00;
                        }
                    }
                    break;
                case "Gladiolus": //"Gladiolus" 1*2.50 ако "Gladiolus"<80 +20% върху крайна цена
                    {
                        if (numberOfFlowers < 80)
                        {
                            Price = numberOfFlowers * 2.50;
                            totalPrice = Price + Price * 0.20;
                        }
                        else
                        {
                            totalPrice = numberOfFlowers * 2.50;
                        }
                    }
                    break; 
            }
              
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flower} and {Math.Abs(budget - totalPrice):f2} leva left.");
            }  
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget - totalPrice):f2} leva more.");
            }

            
             
            
            
            
            // пресмятане дали бюджета ще стигне :f2
            //1.Ако бюджета е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
            //2.Ако бюджета НЕ е достатъчен - "Not enough money, you need {нужната сума} leva more." 
        }
    }
}
