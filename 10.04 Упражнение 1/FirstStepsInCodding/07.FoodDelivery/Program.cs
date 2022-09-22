using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Брой пилешки менюта – цяло число в интервала [0 … 99]
	        //Брой менюта с риба – цяло число в интервала[0 … 99]
	        //Брой вегетариански менюта – цяло число в интервала[0 … 99] 
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegMenu = int.Parse(Console.ReadLine());
            double chickenMenuPrice = chickenMenu * 10.35;
            double fishMenuPrice = fishMenu * 12.40;
            double vegMenuPrice = vegMenu * 8.15;
            double menuPrice = chickenMenuPrice + fishMenuPrice + vegMenuPrice;
            //десерт= 20% от общата сметка без доставка 
            double dessert = menuPrice * 0.20;
            //цена на поръчка+2.50 доставка 
            double totalPrice = menuPrice + dessert + 2.50;
            //четене на цена на поръчка
            Console.WriteLine(totalPrice);

        }
    }
}
