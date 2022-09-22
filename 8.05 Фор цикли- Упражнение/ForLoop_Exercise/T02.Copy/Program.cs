using System;

namespace T02.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се брой на числата
            int numCount = int.Parse(Console.ReadLine());
            int numSum = 0;
            int maxNum = int.MinValue;
            int number = 0;
            for(int i=1; i<=numCount; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numSum = numSum + input;
                if (input > maxNum)
                {
                    maxNum = input;
                }

            }
            number = maxNum;
            numSum = numSum - number;
            int diff = numSum-number;
            if (numSum == number)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {numSum}");
            }
            if (numSum != number)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");
            }
        }
    }
}
