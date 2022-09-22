using System;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());

            double SumKilometri = +M;
            double SumALLKilometri = SumKilometri;


            for (int i = 1; i <= N; i++)
            {
                int Procent = int.Parse(Console.ReadLine());
                SumKilometri += 1.00 * Procent / 100 * SumKilometri;
                SumALLKilometri += SumKilometri;
            }


            if (SumALLKilometri >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(SumALLKilometri - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - SumALLKilometri)} more kilometers");
            }

        }
    }
}