using System;

namespace T10._InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isvalid = number >= 100 && number <= 200 || number == 0;
            if (!isvalid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
