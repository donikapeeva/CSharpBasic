using System;

namespace T06.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Необходимо количество найлон(в кв.м.) -цяло число в интервала[1... 100]
            int nylon = int.Parse(Console.ReadLine());
            //2.Необходимо количество боя(в литри) -цяло число в интервала[1…100]
            int paint= int.Parse(Console.ReadLine());
            //3.Количество разредител(в литри) - цяло число в интервала[1…30]
            int thinnerL= int.Parse(Console.ReadLine());
            //4.Часовете, за които майсторите ще свършат работата -цяло число в интервала[1…9]
            int maistorHours= int.Parse(Console.ReadLine());

            //изчисляване на разходите
            //за найлон +2 Предпазен найлон - 1.50 лв. за кв. метър
            double nylonPrice = (nylon + 2) * 1.50;
            //за боя +10% Боя - 14.50 лв.за литър
            double paintPrice = (paint+(paint*0.10))*14.50;
            //за разредител Разредител за боя - 5.00 лв.за литър
            double thinnerPrice = thinnerL * 5.00;
            //добавяме 0.40 за торбички
            double price = nylonPrice + paintPrice + thinnerPrice + 0.40;
            //изчисляване на сумата за майсторите, която е 30% от всички разходи за материали
            double maistorPrice = (price * 0.30) * maistorHours;
                double totalPrice = price + maistorPrice;

            //отпечатване на •	"{сумата на всички разходи}"
            Console.WriteLine($"{totalPrice}");


        }
    }
}
