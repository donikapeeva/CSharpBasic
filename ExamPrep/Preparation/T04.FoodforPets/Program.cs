using System;

namespace T04.FoodforPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Брой дни – цяло число в диапазона [1…30]
            int days = int.Parse(Console.ReadLine());
            //	Общо количество храна – реално число в диапазона[0.00…10000.00]
            double foodQuantity = double.Parse(Console.ReadLine());
            double eatenBisquits = 0;
            // Количество изядена храна от кучето – цяло число в диапазона[10…500]
            int eatenFoodDog = 0;
            // Количество изядена храна от котката – цяло число в диапазона[10…500]
            int eatenFoodCat = 0;
            for (int i = 1; i <= days; i++)
            {
                int eatenByDog = int.Parse(Console.ReadLine());
                int eatenByCat= int.Parse(Console.ReadLine());
                eatenFoodDog += eatenByDog;
                eatenFoodCat += eatenByCat;
                if (i % 3 == 0)
                {
                    eatenBisquits += (eatenByDog + eatenByCat) * 0.1;
                }

            }
            double totalFoodEaten = eatenFoodCat + eatenFoodDog;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(eatenBisquits)}gr.");
            double percentEatenFood = totalFoodEaten / foodQuantity * 100;
            Console.WriteLine($"{percentEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{eatenFoodDog/totalFoodEaten*100:f2}% eaten from the dog.");
            Console.WriteLine($"{eatenFoodCat / totalFoodEaten * 100:f2}% eaten from the cat.");





            //	"Total eaten biscuits: {количество изядени бисквитки}gr."
            //	"{процент изядена храна}% of the food has been eaten."
            //	"{процент изядена храна от кучето}% eaten from the dog."
            //	"{процент изядена храна от котката}% eaten from the cat."

        }
    }
}
