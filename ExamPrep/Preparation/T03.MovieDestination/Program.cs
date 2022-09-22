using System;

namespace T03.MovieDestination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine(); // "Dubai", "Sofia" и "London"
            string season = Console.ReadLine(); // "Summer" и "Winter"
            int days = int.Parse(Console.ReadLine());
            double pricePerDay = 0;


            //Дестинация           Dubai      Sofia        London
            // Сезон     Winter  45 000 lv.  17 000 lv.  24 000 lv.
            //           Summer  40 000 lv.  12 500 lv.  20 250 lv.
            if (destination == "Dubai")
            {
                if (season == "Winter")
                {
                    pricePerDay = 45000;
                }
                else if (season == "Summer")
                {
                    pricePerDay = 40000;
                }
                pricePerDay = pricePerDay* 0.70;
            }
            else if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    pricePerDay = 17000;
                }
                else if (season == "Summer")
                {
                    pricePerDay = 12500;
                }
                pricePerDay =pricePerDay*1.25;
            }
            else if (destination == "London")
            {
                if (season == "Winter")
                {
                    pricePerDay = 24000;
                }
                else if (season == "Summer")
                {
                    pricePerDay = 20250;
                }
                
            }
            double totalPrice = pricePerDay * days;
            double diff = Math.Abs(movieBudget - totalPrice);
            if (movieBudget >= totalPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {diff:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {diff:f2} leva more!");
            }



            //•	Ако дестинацията е Дубай – 30% отстъпка от крайната цена
            //	Ако дестинацията е София – цената се оскъпява с 25 %



        }
    }
}
