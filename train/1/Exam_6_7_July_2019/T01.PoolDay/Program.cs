using System;

namespace T01.PoolDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //брой на хората.Цяло число в интервала[1…100]
            int people = int.Parse(Console.ReadLine());
            //такса вход. Реално число в интервала[0.00…50.00]
            double tax = double.Parse(Console.ReadLine());
            //цена един за шезлонг. Реално число в интервала[0.00…50.00]
            double loungePrice= double.Parse(Console.ReadLine());
            //цена за един чадър. Реално число в интервала[0.00...50.00]
            double umbrellaPrice = double.Parse(Console.ReadLine());
            //такса вход
            double totalTax = tax * people;
            //шезлонг искат 75%от брой хора
            double lounge = Math.Ceiling(people *0.75);
            double loungeTPrice = lounge * loungePrice;
            //1 чадър стига за двама души
            double umbrellas = Math.Ceiling(people/2.0);
            double umbrellaTPrice = umbrellas * umbrellaPrice;

            //изчисляване на нужните чадъри и шезлонги и числото да се закръгли нагоре

            double totalPrice = totalTax + loungeTPrice + umbrellaTPrice;
            //каква сума трябва да се изплати?

            //Принтиране "{сумата за покриване на разходите} lv." сумата да се форматира до втория знак
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
