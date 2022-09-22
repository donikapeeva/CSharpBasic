using System;

namespace T03.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for(int count=1; count <= number; count += 3)
            {
                Console.WriteLine(count);
            }
        }
    }
}
