using System;

namespace T07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            //rabotno vreme ot 10-18h. ot ponedelnik do subota
            if (hour >= 10 && hour <= 18 && (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday"))
            {
                Console.WriteLine("open");
            }

            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
