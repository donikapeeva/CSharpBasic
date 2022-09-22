using System;

namespace T02.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – броят процесори, които трябва да се изработят – цяло число в интервала [1...500 000]
            int processorsCount = int.Parse(Console.ReadLine());
            //Втори ред – броят служители – цяло число в интервала[1...1000]
            int people= int.Parse(Console.ReadLine());
            //Трети ред – работните дни – цяло число в интервала[1...1000]
            int workDays= int.Parse(Console.ReadLine());
            double workHoursSum = people * workDays * 8;//общо работни часове за всички работни дни
            double allprocessors = Math.Floor(workHoursSum / 3);

            //1 процесор се изработва за 3 часа
            //1 служител работи 8 часа на ден
            if (allprocessors >= processorsCount)
            { //	Ако са повече или колкото плануваните:
              //	"Profit: -> {печалби} BGN"
                double diff = allprocessors- processorsCount;
                diff = diff * 110.10;
                Console.WriteLine($"Profit: -> {diff:f2} BGN");

            }
            else if (allprocessors < processorsCount)
            {
                double diff = processorsCount-allprocessors;
                diff = diff * 110.10;
                //	"Losses: -> {загуби} BGN"
                //	Сумите трябва да са форматирани до втория знак след десетичната запетая.
                Console.WriteLine($"Losses: -> {diff:f2} BGN");
            }


            //пресмятане каква печалба или загуба ще реализира фирмата 
            //за 10 часа се изработват 10/3 = 3.33 процесора   3 процесора. Един брой струва 110.10 лв. 

            //На конзолата трябва да се отпечата текст, спрямо броя на изработените процесори:
            //	Ако са повече или колкото плануваните:
            //	"Profit: -> {печалби} BGN"
            //	Ако са по - малко от плануваните:


        }
    }
}
