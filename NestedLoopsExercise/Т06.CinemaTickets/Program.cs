using System;

namespace Secontry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//стринг инпут име на филм или финиш

            int student = 0;//променлива за студентски билети
            int standard = 0; //променлива за стандартни билети
            int kid = 0; // променлива за детски билети
            while (input != "Finish")//външен цикъл, който върви, докато инпута е филм и разл. от финиш
            {
                int freeSeats = int.Parse(Console.ReadLine());//четат се свободните места за моментния филм
                int tickets = 0;//променлива за бррой билети
                string ticketType = Console.ReadLine();//променлива за тип билети
                while (ticketType != "End")//вътрешен цикъл, който се върти, докато се въвежда тип билет, различно от Енд
                {
                    tickets++;//броя билети се увеличава
                    if (ticketType == "student")//проверка дали типа билет е студентски
                    {
                        student++;//ако е студентските билети се увеличават
                    }
                    else if (ticketType == "standard")//проверка дали типа билет е стандартен
                    {
                        standard++;//ако е стандартните билети се увеличават
                    }
                    else if (ticketType == "kid")//проверка дали типа билет е детски
                    {
                        kid++;//ако е детските билети се увеличават
                    }
                    if (freeSeats == tickets)//проверка дали свободните места са се изравнили със закупените билети
                    {
                        break;//ако са равни,вътрешния цикъл спира
                    }
                    ticketType = Console.ReadLine();//отново се чете тип билет
                }
                double occupancyRate = tickets * 100.0 / freeSeats;//пресмятане на процента заетост на места-закупени билети по 100, разделено на свободните места
                Console.WriteLine($"{input} - {occupancyRate:f2}% full.");//конзолата печата името на филма и процента заетост
                input = Console.ReadLine();//отново се чете име на филм и цикъла се завърта
            }
            if (input == "Finish")//ако вместо филм дойде Финиш
            {
                int totalTickets = student + standard + kid;//пресмята се целия брой билети
                double studentRate = student * 100.0 / totalTickets; //процент студентски билети
                double standardRate = standard * 100.0 / totalTickets; //процент стандартни билети
                double kidRate = kid * 100.0 / totalTickets; //процент детски билети
                Console.WriteLine($"Total tickets: {totalTickets}"); //отпечатва се общия брой билети
                Console.WriteLine($"{studentRate:f2}% student tickets."); //отпечатва се процент студентски билети
                Console.WriteLine($"{standardRate:f2}% standard tickets."); //отпечатва се процент стандартни билети
                Console.WriteLine($"{kidRate:f2}% kids tickets."); //отпечатва се процент детски билети


            }
        }
    }
}
