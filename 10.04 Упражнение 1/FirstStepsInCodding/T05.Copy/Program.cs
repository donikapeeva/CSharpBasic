using System;

namespace T05.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Брой пакети химикали - цяло число в интервала [0...100]
            int pen = int.Parse(Console.ReadLine());
             //	Брой пакети маркери - цяло число в интервала[0...100]
             int markers = int.Parse(Console.ReadLine());
            //	Литри препарат за почистване на дъска -цяло число в интервала[0…50]
            int detergent= int.Parse(Console.ReadLine());
            //	Процент намаление -цяло число в интервала[0...100]
            int percent= int.Parse(Console.ReadLine());

            //•	Пакет химикали - 5.80 лв. 
            double penPrice = pen * 5.80;
            //	Пакет маркери -7.20 лв.
            double markerPrice = markers * 7.20;
            //	Препарат - 1.20 лв(за литър)
            double detergentPrice = detergent * 1.20;
            //изчисляване на нужната сума 
            double priceForAll = penPrice + markerPrice + detergentPrice;
            double discount = priceForAll * percent / 100;
            double totalPrice = priceForAll - discount;

            //отпечатване
            Console.WriteLine(totalPrice);

        }
    }
}
