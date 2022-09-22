using System;

namespace T06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Входът е цяло трицифрено число в интервала[111…999].
            int number = int.Parse(Console.ReadLine());
            int numsum = 0;
            int x1 = 0;
            int x2 = 0;
            int x3 = 0;
            for (int x3 = 1; x3 < number/100; x3++)
            {
                for (int x2 = 0; x2 < number%100; x2++)
                {
                    for (int x1 = 0; x3 < number%1000; x3++)
                    {
                        numsum = x1 * x2 * x3;
                    }
                }
            }
            Console.Write($"{x1} * {x2} * {x3} = {numsum};");

            //Максималната стойност на множителите е определена от всяка една от 3-те цифри на въведеното число.
            //отпечатване
            //"{първата цифра} * {втората цифра} * {третата цифра} = {резултатът от умножението на трите цифри};"


        }
    }
}
