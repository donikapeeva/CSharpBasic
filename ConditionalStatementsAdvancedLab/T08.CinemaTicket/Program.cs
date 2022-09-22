using System;

namespace T08.CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ден от седмицата стринг
            string day = Console.ReadLine();
            int price = 0;
            //Monday	Tuesday	Wednesday	Thursday	Friday	Saturday	Sunday
            //  12        12       14         14          12        16       16
            switch (day)
            {
                case "Monday":
                    price = 12;
                    break;
                case "Tuesday":
                    price = 12;
                    break;
                case "Wednesday":
                    price = 14;
                    break;
                case "Thursday":
                    price = 14;
                    break;
                case "Friday":
                    price = 12;
                    break;
                case "Saturday":
                    price = 16;
                    break;
                case "Sunday":
                    price = 16;
                    break;
            }
            Console.WriteLine(price);

            //принтиране на цената на билет според деня
        }
    }
}
