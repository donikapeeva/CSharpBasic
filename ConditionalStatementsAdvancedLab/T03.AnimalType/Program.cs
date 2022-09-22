using System;

namespace T03.AnimalType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	dog -> mammal
            //2.crocodile, tortoise, snake->reptile
            //3.others->unknown
            string animalType = Console.ReadLine(); 
            switch (animalType)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise": 
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
