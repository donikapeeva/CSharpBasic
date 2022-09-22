using System;

namespace _05.Number100_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // под 100 отпечатайте: "Less than 100"
            // между 100 и 200 отпечатайте: "Between 100 and 200"
            // над 200 отпечатайте: "Greater than 200" 

            // input from the user 

            int number = int.Parse(Console.ReadLine());
             
            if (number < 100)
            {
                 Console.WriteLine("Less than 100");
            } 
            else if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            } 
            else if (number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
        }
    }
}
