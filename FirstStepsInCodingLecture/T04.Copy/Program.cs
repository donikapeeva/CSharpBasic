using System;

namespace T04.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double cm = number * 2.54;
            Console.WriteLine(cm);
        }
    }
}
