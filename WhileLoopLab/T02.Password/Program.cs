using System;

namespace T02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string променливи username и password 
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string inputPass = Console.ReadLine(); 
             
            while(inputPass != password)
            {
                inputPass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");

            //при правилна парола се изпринтира "Welcome {username}!".
        }
    }
}
