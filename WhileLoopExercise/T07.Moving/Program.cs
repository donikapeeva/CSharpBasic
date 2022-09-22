using System;

namespace T07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Широчина на свободното пространство - цяло число в интервала[1...1000]
            int w = int.Parse(Console.ReadLine());
            //Дължина на свободното пространство - цяло число в интервала[1...1000]
            int l = int.Parse(Console.ReadLine());
            //Височина на свободното пространство - цяло число в интервала[1...1000] 
            int h = int.Parse(Console.ReadLine());
            
            int freeSpace = w * l * h; //намиране на кубичните метра в*л*х 

            string input = Console.ReadLine();
            //брой кашони Input 
            //цикъл, който чете кашони, прибавя ги един към друг и проверява дали има още място, до команда "Done"
            while (input != "Done")
            {
                int boxes = int.Parse(input);
                freeSpace -= boxes;
                if (freeSpace < 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            int result = Math.Abs(freeSpace);
            if (freeSpace > 0)
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            } 
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
        }
    }
}
