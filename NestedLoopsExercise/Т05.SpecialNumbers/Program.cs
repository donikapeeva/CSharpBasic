using System;

namespace Т05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се число n инт  
            int n = int.Parse(Console.ReadLine());
            //генериране на всички четирицифрени числа съставени с числа от 1 и 9 и отпечатване
            for (int l = 1; l <= 9; l++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        for (int i = 1; i <= 9; i++)
                        {
                            if (n % l == 0 && n % k == 0 && n % j == 00 && n % i == 0)
                            {
                                Console.Write($"{l}{k}{j}{i} ");
                            }

                        }
                    }
                }
            }
        }
    }
}
