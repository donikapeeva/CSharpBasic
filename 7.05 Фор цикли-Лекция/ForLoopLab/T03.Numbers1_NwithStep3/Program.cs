using System;

namespace T03.Numbers1_NwithStep3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for(int counter= 1; counter <= number; counter += 3)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
