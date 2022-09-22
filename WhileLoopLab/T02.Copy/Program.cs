using System;

namespace T02.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //прочита име и парола на потребителски профил
            string user = Console.ReadLine();
            string password = Console.ReadLine();
            //парола за вход.
            string input= Console.ReadLine();
            while (input != password)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {user}!");

        }
    }
}
