using System;

namespace T04.PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //input from user string
            string pass = "s3cr3t!P@ssw0rd";
            string passFromUser = Console.ReadLine();

            bool isCorrectedPassword = passFromUser == pass;
                 
            if (isCorrectedPassword) 
            {
                Console.WriteLine("Welcome");
                      
            } 
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
