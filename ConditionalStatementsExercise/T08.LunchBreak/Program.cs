using System;

namespace T08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Име на сериал – текст 
            string showName = Console.ReadLine();
            //2.Продължителност на епизод  – цяло число в диапазона[10… 90] 
            int episodeTime = int.Parse(Console.ReadLine());
            //3.Продължителност на почивката  – цяло число в диапазона[10… 120] 
            int lunchBreak = int.Parse(Console.ReadLine());
            //време за обяд е 1/8 от почивката
            // 1/4 се отделя за време за отдих
            //1/8 + 1/4 = 1/8 + 2/8 = 3/8 
            // 5/8 от почивката за сериал
            double timeForShow = lunchBreak * 5 / 8.0;
            //времето достаъчно ли е
            //ако е достатъчно се принтира "You have enough time to watch {име на сериал} and left with {останало време} minutes free time." 
             if (timeForShow >= episodeTime)
            {
                Console.WriteLine($"You have enough time to watch {showName} and left with {Math.Ceiling(timeForShow - episodeTime)} minutes free time.");
            }
            // ако не е достатъчно се принтира "You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes." 
            //резултатът трябва да се закръгли нагоре
            else
            {
                Console.WriteLine($"You don't have enough time to watch {showName}, you need {Math.Ceiling(episodeTime - timeForShow)} more minutes.");
            }

        }
    }
}
