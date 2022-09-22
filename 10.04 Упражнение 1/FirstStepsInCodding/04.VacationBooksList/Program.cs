using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //три променливи, които да се пазят от конзолата 
            int page = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            //намираме колко часа са нужни за прочитане на книгата 
            int totalHour = page / pagesPerHour;
            //колко часа на ден трябва да чете 
            int hoursPerDay = totalHour / days;
            //отпечатване на резулатата часовете за четене на ден 
            Console.WriteLine(hoursPerDay);
        }
    }
}
