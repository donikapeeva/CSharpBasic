using System;

namespace Т05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double бюджет 
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string typeOfVacation = "";
            double Price = 0;
            //сезон лято или зима 
            //1.ако бюджета е <= 100лв дестинация България
            // лято къмпинг 30% от бюджета
            // зима хотел 70% от бюджета 
            if (budget<= 100)
            {
                destination = "Bulgaria"; 
                switch (season)
                {
                    case "summer":
                        typeOfVacation = "Camp";
                        Price = budget * 0.30; 
                        break;
                    case "winter":
                        typeOfVacation = "Hotel";
                        Price = budget * 0.70;
                        break;
                }
            }
            //2.ако бюджета е <= 1000лв Балканите 
            // Лято – къмпинг 40 % от бюджета
            // Зима – хотел 80 % от бюджета
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        typeOfVacation = "Camp";
                        Price = budget * 0.40;
                        break;
                    case "winter":
                        typeOfVacation = "Hotel";
                        Price = budget * 0.80;
                        break;
                }
            }
            else //3. ако бюджета е >1000лв Европа
                  // всеки сезон къмпинг или хотел 90% от бюджета
            {
                destination = "Europe";
                typeOfVacation = "Hotel";
                Price = budget * 0.90;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfVacation} - {Price:F2}");



            //отпечатване „Somewhere in [дестинация]“ измежду “Bulgaria", "Balkans” и ”Europe” 
            //“{Вид почивка} – {Похарчена сума}“ 
            // Почивката може да е между „Camp” и „Hotel”
            // Сумата трябва да е закръглена с точност до вторият знак след запетаята.


        }
    }
}
