using System;

namespace T09.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четем 1.	Дължина в см – цяло число в интервала [10 … 500]
            int l = int.Parse(Console.ReadLine());
            //2.Широчина в см – цяло число в интервала[10 … 300]
            int w = int.Parse(Console.ReadLine());
            //3.Височина в см – цяло число в интервала[10… 200]
            int h = int.Parse(Console.ReadLine());
            //4.Процент  – реално число в интервала[0.000 … 100.000]
            double percent = double.Parse(Console.ReadLine());

            //намиране на обем  в дециметри
            double volume = l * w * h;

            //намиране на литрите вода / 1л=1 дм3/. 
            double volumeL = volume/ 1000;
            //изваждане н процент 
            double totalL = volumeL - (volumeL * (percent / 100));

            //принтиране на литрите
            Console.WriteLine(totalL);

        }
    }
}
