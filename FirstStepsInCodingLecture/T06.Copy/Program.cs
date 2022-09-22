using System;

namespace T06.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //име, фамилия, възраст и град  
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string city = Console.ReadLine();
            //"You are <firstName> <lastName>, a <age>-years old person from <town>."
            Console.WriteLine($"You are {name} {lastName}, a {age}-years old person from {city}.");
        }
    }
}
