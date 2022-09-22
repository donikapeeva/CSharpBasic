using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Брой пакети химикали - цяло число в интервала [0...100]
            //Брой пакети маркери - цяло число в интервала[0...100]
            //Литри препарат за почистване на дъска -цяло число в интервала[0…50]  
            //Процент намаление -цяло число в интервала[0...100] 
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int detergent = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) / 100;
            double price = (pens * 5.80)+(markers * 7.20)+(detergent * 1.20);
            //пари за всичко=изчисляване на намаление от общата сума
            double totalPrice = price - (price * percent);
            //отпечатване колко пари са нужни за всичко
            Console.WriteLine(totalPrice);

        }
    }
}
