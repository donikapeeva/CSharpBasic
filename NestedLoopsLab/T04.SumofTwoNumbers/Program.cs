using System;

namespace T04.SumofTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numStart = int.Parse(Console.ReadLine());
            int numEnd = int.Parse(Console.ReadLine());
            int numMagic = int.Parse(Console.ReadLine());
            int combination = 0;
            bool beFound = false;
            for(int numFirst = numStart; numFirst<= numEnd; numFirst++)
            {
                
                for(int numSecond=numStart; numSecond<=numEnd; numSecond++)
                {
                    combination++; 
                    if(numFirst + numSecond == numMagic)
                    {
                        beFound = true;
                        Console.WriteLine($"Combination N:{combination} ({numFirst} + {numSecond} = {numMagic})");
                        break;
                    }
                }
                if (beFound)
                {
                    break;
                }
            }
            if (!beFound)
            {
                Console.WriteLine($"{combination} combinations - neither equals {numMagic}");
            }

        }
    }
}
