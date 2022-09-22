using System;

namespace T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //На първия ред – N – брой дни, в които г-жа Иванова тренира  – цяло число в интервала [1...50]
            int daysN = int.Parse(Console.ReadLine());
            //На втория ред – M – километрите, които е избягала първия ден – реално число в интервала[1.00…500.00]
            double km1DayM = double.Parse(Console.ReadLine());

            double kmforDay = +km1DayM;
            double sumKM = kmforDay;
            //За всеки ден се чете
            for (int i = 1; i <= daysN; i++)
            {
                int percent = int.Parse(Console.ReadLine());//чете се процента
                kmforDay += 1.00 * percent / 100 * kmforDay;//пресмятане на километрите за деня
                sumKM += kmforDay;//прибавяне към избяганите километри

                
            }
            //за да отслабне, трябва да избяга минимум 1 000 км goal==1000
            //проверка дали избяганите километри са >=1000
            if (sumKM >= 1000)//ако пробяганите км са повече от 1000
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(sumKM - 1000)} more kilometers!");

            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000-sumKM)} more kilometers");

            }
            //резултата да се закръгли нагоре
            //Ако пробяганите километри са >= 1 000 км – да се отпечатва съобщение:
            //"You've done a great job running {избяганите километри повече от 1000} more   kilometers!"
            //Ако пробяганите километри са < 1 000 км – да се отпечата съобщение:
            //"Sorry Mrs. Ivanova, you need to run {недостигащите километри} more kilometers"













        }
    }
}
