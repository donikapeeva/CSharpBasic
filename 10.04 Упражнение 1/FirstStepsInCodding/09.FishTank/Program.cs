using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Дължина в см – цяло число в интервала [10 … 500] int а
            //2.Широчина в см – цяло число в интервала[10 … 300]int б
            //3.Височина в см – цяло число в интервала[10… 200]int ц 
            int lenght = int.Parse(Console.ReadLine());
            int with = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            //4.Процент пясък – реално число в интервала[0.000 … 100.000]int преобразуване 
            double percent = double.Parse(Console.ReadLine())/100;
            //пресмятане на обем на паралепипет V= a.b.c  
            double volume = lenght * with * height;
            // преобразуване на обема в литри  
            double volumeLiters = volume / 1000;
            //намиране на нужните литри вода - литри по 1- процента  
            double waterLiters = volumeLiters * (1 - percent);
            //отпечатване на резултата 
            Console.WriteLine(waterLiters);

        }
    }
}
