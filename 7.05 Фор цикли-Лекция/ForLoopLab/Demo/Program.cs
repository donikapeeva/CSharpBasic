using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = input.Length;
            Console.WriteLine(length);
            for(int index=0; index<=input.Length; index++)
            {
                Console.WriteLine(index);
            }
        }
    }
}
