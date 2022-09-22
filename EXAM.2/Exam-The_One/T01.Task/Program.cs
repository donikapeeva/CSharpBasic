using System;

namespace T01.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Броя кутии с боя – цяло число в интервала[1 … 10 000]
            int paintCount = int.Parse(Console.ReadLine());
            //Броя на ролките тапети – цяло число в интервала[1... 10 000]
            int wallRolls= int.Parse(Console.ReadLine());
            //Цената за един чифт ръкавици – реално число  в интервала[0.00... 1000.00]
            double glovesPrice=double.Parse(Console.ReadLine());
            //Цената за една четка – реално число  в интервала[0.00... 2000.00
            double brushPrice= double.Parse(Console.ReadLine());
            double paintPrice = paintCount * 21.50;
            double wallPrice=wallRolls*5.20;
            double gloveNeed = Math.Ceiling(wallRolls * 0.35);
            double brushNeed = Math.Floor(paintCount * 0.48);
            double totalGlovePrice = gloveNeed * glovesPrice;
            double totalBrushPrice = brushNeed * brushPrice;
            //изчисляване на обща цена на продуктите
            double allPrice = paintPrice + wallPrice + totalBrushPrice + totalGlovePrice;
            //изчисляване на цена на доставка, която представлява 1 / 15 от общата цена на продуктите. 
            double logisticPrice = allPrice / 15;
            //отпечатване на •	"This delivery will cost {цената на доставката} lv." 
            Console.WriteLine($"This delivery will cost {logisticPrice:f2} lv.");
            //боя,=21.50 лв/кутия
            //тапети,=5.20 лв/ролка
            //ръкавици -нужните ръкавици са 35% от броя на ролките тапети, закръглени нагоре
            //четки=нужните четки  48% от броя на кутиите боя, закръглени надолу 




        }
    }
}
