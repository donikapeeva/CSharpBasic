using System;

namespace Secontry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            int student = 0;
            int standard = 0;
            int kid = 0; 
            while(input!= "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                int tickets = 0;
                string ticketType = Console.ReadLine();
                while (ticketType != "End")
                {
                    tickets++;
                    if(ticketType == "student")
                    {
                        student++;
                    }
                    else if(ticketType == "standard")
                    {
                        standard++;
                    }
                    else if (ticketType == "kid")
                    {
                        kid++;
                    }
                    if (freeSeats == tickets)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }
                double occupancyRate = tickets * 100.0 / freeSeats;
                Console.WriteLine($"{input} - {occupancyRate:f2}% full.");
                input = Console.ReadLine();
            }
            if(input == "Finish")
            {
                int totalTickets = student + standard + kid;
                double studentRate = student * 100.0 / totalTickets;
                double standardRate = standard * 100.0 / totalTickets;
                double kidRate = kid * 100.0 / totalTickets;
                Console.WriteLine($"Total tickets: {totalTickets}");
                Console.WriteLine($"{studentRate:f2}% student tickets.");
                Console.WriteLine($"{standardRate:f2}% standard tickets.");
                Console.WriteLine($"{kidRate:f2}% kids tickets.");


            }
        }
    }
}
