using System;

namespace T05.GodzillaAndKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // от конзолата се четат: 
            //бюджет
            double budget = double.Parse(Console.ReadLine());
            //брой статисти
            int extra = int.Parse(Console.ReadLine());
            //облекло  
            double clothes1extra = double.Parse(Console.ReadLine());
            //цена на декора=бюджет-10%  
            double decorPrice = budget*0.10;
            //цена на облекло= брой статисти*цена за облеко 
            double clothingPrice = extra * clothes1extra;
            //ако статистите са > 150, 
            //1.отстъпка върху цената е -10%
            if (extra > 150)
            {
                clothingPrice = clothingPrice - clothingPrice * 0.10;
            }
            //пбщо разходи за заснемане на филма
            double moviePrice = clothingPrice + decorPrice;
            //ако
            //1.нужните пари са повече от бюджета се отпечатва o	"Not enough money!" 
            //"Wingard needs {парите недостигащи за филма} leva more." 
            double difference = budget - moviePrice;
            if (difference >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(difference):f2} leva more.");
            }

            //2. ако парите са <= на бюджета се отпечатва Action!" 
            //   "Wingard starts filming with {останалите пари} leva left."



        }
    }
}
