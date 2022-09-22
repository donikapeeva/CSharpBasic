using System;

namespace T06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Име на актьора - текст
            string actor = Console.ReadLine();
            //Точки от академията - реално число в интервала[2.0... 450.5]
            double points = double.Parse(Console.ReadLine());
            //Брой оценяващи n - цяло число в интервала[1… 20]
            int n = int.Parse(Console.ReadLine());
            string judge = string.Empty;
            double judgePoints = 0;

            for (int i=1; i<=n; i++)
            {
                judge = Console.ReadLine();
                //точките за актьора се формират от дължината на името на оценяващия*точките/2
                judgePoints = double.Parse(Console.ReadLine());
                points += judge.Length*judgePoints/2;


                if (points >= 1250.5) //проверка, ако точките са равни или повече от 1250.5 спира цикъла
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:f1}!"); 
                    break;
                }

            }

            if (points<1250.5)
            {
                Console.WriteLine($"Sorry, {actor} you need {(1250.5 - points):f1} more!");
            }
                //проверка дали надхвърлят 1250.5 програмата трябва да прекъсне и да се отпечата, че дадения актьор е получил номинация.
                //"Congratulations, {име на актьора} got a nominee for leading role with {точки}!" 

                // ако не са толкова "Sorry, {име на актьора} you need {нужни точки} more!"

        }
    }
}
