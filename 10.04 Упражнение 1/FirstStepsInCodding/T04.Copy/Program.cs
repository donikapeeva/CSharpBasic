using System;

namespace T04.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Брой страници в текущата книга – цяло число в интервала [1…1000]
            int pages = int.Parse(Console.ReadLine());
            //2.Страници, които прочита за 1 час – цяло число в интервала[1…1000]
            int pagesPerHour = int.Parse(Console.ReadLine());
            //3.Броят на дните, за които трябва да прочете книгата – цяло число в интервала[1…1000] 
            int days = int.Parse(Console.ReadLine());
            //изчисляване на часовете за страниците
            int hoursForPages = pages / pagesPerHour;
            //изчисляване на часове за ден 
            int hoursPerDay = hoursForPages/days ;

            //отпечатване на брой часове, които трябва да чете на ден
            Console.WriteLine(hoursPerDay);

        }
    }
}
