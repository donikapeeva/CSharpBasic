using System;

namespace T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Първи ред – брой хора – цяло число в интервала [1 … 20]
            int people = int.Parse(Console.ReadLine());
            //2.Втори ред – сезон – текст с възможности - "spring", "summer", "autumn" или "winter" 
            string season = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;
            //                Пролет (spring)	Лято (summer)	      Есен (autumn)  	Зима (winter)
            //  до 5 човека   50.00 лв.на човек  48.50 лв.на човек  60.00 лв.на човек  86.00 лв.на човек
            //над 5 човека   48.00 лв.на човек  45.00 лв.на човек  49.50 лв.на човек  85.00 лв.на човек
            switch (season)
            {
                case "spring":
                    if (people <= 5)
                    {
                        price = people * 50.00;
                        totalPrice = price;
                    }
                    else if (people > 5)
                    {
                        price = people * 48.00;
                        totalPrice = price;
                    }
                    break;
                case "summer":
                    if (people <= 5)
                    {
                        price = people * 48.50;
                        totalPrice = price;
                    }
                    else if (people > 5)
                    {
                        price = people * 45.00;
                        totalPrice = price;
                    }
                    totalPrice = totalPrice - totalPrice * 0.15; //ако е summer 15% отстъпка
                    break;
                case "autumn":
                    if (people <= 5)
                    {
                        price = people * 60.00;
                        totalPrice = price;
                    }
                    else if (people > 5)
                    {
                        price = people * 49.50;
                        totalPrice = price;
                    }
                    break;
                case "winter":
                    if (people <= 5)
                    {
                        price = people * 86.00;
                        totalPrice = price;
                    }
                    else if (people > 5)
                    {
                        price = people * 85.00;
                        totalPrice = price;
                    }
                    totalPrice = totalPrice + totalPrice * 0.08; //ако е winter 8% оскъпяване
                    break;
            }
            Console.WriteLine($"{totalPrice:f2} leva.");


            // Отпечатва се Цената за екскурзията, форматирана до втория знак, в следния формат:
            // "{цената} leva."

        }
    }
}
