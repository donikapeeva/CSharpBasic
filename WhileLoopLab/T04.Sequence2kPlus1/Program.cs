using System;

namespace T04.Sequence2kPlus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            //променлива за запазване на всички числа умножени по 2+1
            int kNumber = 0;  
            //докато knumber е по-малък или равен на number  
            while (kNumber <= number)
            {
                kNumber = kNumber * 2 + 1;
                if (kNumber <= number)
                {
                  Console.WriteLine(kNumber);
                }
            }

        }
    }
}
