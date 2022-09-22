using System;

namespace T07.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Брой пилешки менюта – цяло число в интервала [0 … 99]
            int chickenMenu = int.Parse(Console.ReadLine());
            //	Брой менюта с риба – цяло число в интервала[0 … 99]
            int fishMenu= int.Parse(Console.ReadLine());
            //	Брой вегетариански менюта – цяло число в интервала[0 … 99] 
            int vegiMenu= int.Parse(Console.ReadLine());
            //•	Пилешко меню –  10.35 лв.
            double chickenPrice = chickenMenu * 10.35;
            //•	Меню с риба – 12.40 лв. 
            double fishPrice = fishMenu * 12.40;
            //•	Вегетарианско меню  – 8.15 лв. 
            double vegiPrice = vegiMenu * 8.15;
            //десерт=20% от общата сметка
            double price = chickenPrice + fishPrice + vegiPrice;
            double dessert = price * 0.20;
            double totalPrice = price + dessert + 2.50;

            //доставка=2.50
            //изчисляване на сума за поръчка
            //принтиране "{цена на поръчката}"
            Console.WriteLine(totalPrice);

        }
    }
}
