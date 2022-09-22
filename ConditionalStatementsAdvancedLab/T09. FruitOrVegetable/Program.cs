using System;

namespace T09._FruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //име на продукт стринг  
            string product = Console.ReadLine();
            //проверка дали е плод или зеленчук
            // 1.fruit може да бъде banana, apple, kiwi, cherry, lemon и grapes
            switch (product)
            {
                case "banana":
                    Console.WriteLine("fruit");
                    break;
                case "apple":
                    Console.WriteLine("fruit");
                    break;
                case "kiwi":
                    Console.WriteLine("fruit");
                    break;
                case "cherry":
                    Console.WriteLine("fruit");
                    break;
                case "lemon":
                    Console.WriteLine("fruit");
                    break;
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                    Console.WriteLine("vegetable");
                    break;
                case "cucumber":
                    Console.WriteLine("vegetable");
                    break;
                case "pepper":
                    Console.WriteLine("vegetable");
                    break;
                case "carrot":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
            // 2. vegetable може да бъде tomato, cucumber, pepper и carrot 
            //3. ako е друго се принтира "unknown"
        }
    }
}
