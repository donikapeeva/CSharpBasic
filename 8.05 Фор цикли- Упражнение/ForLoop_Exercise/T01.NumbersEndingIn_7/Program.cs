 using System;

namespace T01.NumbersEndingIn_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //отпечатване на числата завършващи на 7 от 1 до 1000 

            for (int i = 1; i <= 1000; i++)
            {  
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
