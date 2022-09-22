using System;

namespace T08.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се •	Годишната такса за тренировки по баскетбол – цяло число в интервала [0… 9999];
            int tax = int.Parse(Console.ReadLine());
            //•	Баскетболни кецове – цената им е 40% по-малка от таксата за една година
            double shoes = tax - (tax * 0.40);
            //	Баскетболен екип – цената му е 20 % по - евтина от тази на кецовете
            double clothes = shoes - (shoes * 0.20);
            //	Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
            double ball = clothes / 4;
            //	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка 
            double accss = ball / 5;
            double totalPrice = tax+shoes + clothes + ball + accss;

            //отпечатване колко ще изхарчи Джеси
            Console.WriteLine(totalPrice);

        }
    }
}
