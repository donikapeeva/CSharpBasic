using System;

namespace T04.PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //прочита възраст (реално число) и пол ('m' или 'f'),  
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            //"Mr." – мъж (пол 'm') на 16 или повече години 
            //"Ms." – жена(пол 'f') на 16 или повече години 
            if (gender == "f")
            {
                if (age < 16)
                    Console.WriteLine("Miss");
                else if (age >= 16)
                    Console.WriteLine("Ms.");
            } 
            else
            {
                if (age < 16)
                    Console.WriteLine("Master");
                else if (age >= 16)
                    Console.WriteLine("Mr.");
            }
            //"Master" – момче(пол 'm') под 16 години
            //"Miss" – момиче(пол 'f') под 16 години

        }
    }
}
