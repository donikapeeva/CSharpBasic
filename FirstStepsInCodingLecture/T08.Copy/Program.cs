using System;

namespace T08.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Броят на опаковките храна за кучета – цяло число в интервала [0… 100]
            int foodDog = int.Parse(Console.ReadLine());
            //2.Броят на опаковките храна за котки –  цяло число в интервала[0… 100] 
            int foodCat = int.Parse(Console.ReadLine());
            //кучешка 2.50
            double dogPrice = 2.50;
            double dogSum = foodDog * dogPrice;
            //котешка храна 4
            double catPrice = 4;
            double catSum = foodCat * catPrice;
            double sum = dogSum + catSum;

            //отпечатване "{крайната сума} lv."
            Console.WriteLine($"{sum} lv.");

        }
    }
}
