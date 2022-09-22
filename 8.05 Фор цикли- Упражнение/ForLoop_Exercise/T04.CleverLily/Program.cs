using System;

namespace T04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Възрастта на Лили - цяло число в интервала [1...77]
            int age = int.Parse(Console.ReadLine());
            //Цената на пералнята - число в интервала[1.00...10 000.00]
            double wmPrice = double.Parse(Console.ReadLine());
            //Единична цена на играчка -цяло число в интервала[0...40]
            double toyPrice = double.Parse(Console.ReadLine());
            double money = 0;
            //колко пари е събрала Лили
            //пари от рожден ден(четни рождени дни) с изваждане на взетите пари от брат и(по 1лв за всеки четен РД)
            //пари от продажба на играчки(нечетни рождени дни)
            for (int i=1; i<=age; i++)
            {
                //четен i%2=0; i*5-1;
                if (i%2 == 0)
                {
                    money += i * 5 - 1;
                }
                //нечетен i%2 !=0; играчка=toyprice
                else
                {
                   money += toyPrice;
                }
            }

            //пресмятане на парите, дали са достатъчни за пералня.
            //отпечатване •	Ако парите на Лили са достатъчни:
            //    "Yes! {N}" - където N е остатъка пари след покупката
            //Ако парите не са достатъчни:
            //  "No! {М}" - където M е сумата, която не достига
            if (money >= wmPrice)
            {
                Console.WriteLine($"Yes! {money-wmPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {wmPrice-money:f2}");
            }

        }
    }
}
