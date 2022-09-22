using System;

namespace T06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine()); 
            for(int currentfloor=floors; currentfloor>=1; currentfloor--)
            {
                for(int currentroom=0;currentroom<rooms; currentroom++)
                {
                    if (currentfloor == floors)
                    {
                        Console.Write($"L{currentfloor}{currentroom} ");
                    }
                    else if (currentfloor%2== 0)
                    {
                        Console.Write($"O{currentfloor}{currentroom} ");
                    }
                    else
                    {
                        Console.Write($"A{currentfloor}{currentroom} ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
