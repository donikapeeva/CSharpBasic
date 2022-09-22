using System;

namespace T05.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Закупеното количество храна за кученцето в килограми – цяло число в интервала [1 …100]
            int dogFood = int.Parse(Console.ReadLine());
            dogFood = dogFood * 1000;
            int foodEaten = 0;
            double allFoodEaten = 0;
            string input = Console.ReadLine();
            //while цикъл , който върви до команда Adopted
            while (input!= "Adopted")
            {
                foodEaten = int.Parse(input);
                allFoodEaten = allFoodEaten + foodEaten;
                if(input== "Adopted")
                {
                    break;
                }
                input= Console.ReadLine();
            }
            double diff = Math.Abs(dogFood - allFoodEaten);
            if (allFoodEaten > dogFood)
            {
                Console.WriteLine($"Food is not enough. You need {diff} grams more.");
            }
            else if(allFoodEaten <= dogFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {dogFood-allFoodEaten} grams.");
            }
            //На всеки следващ ред до ще получавате колко грама изяжда кученцето на всяко хранене -цяло число в интервала[10 …1000]

            //изчисляваме дали количеството храна, което е закупено за кученцето, ще е достатъчно докато кученцето бъде осиновено.


            //•	Ако количеството храна е достатъчно да се отпечата:
            // "Food is enough! Leftovers: {останала храна} grams."
            //	Ако количеството храна не е достатъчно да се отпечата:
            // "Food is not enough. You need {нужно количество храна} grams more."

        }
    }
}
