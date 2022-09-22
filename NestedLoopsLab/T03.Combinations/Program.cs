using System;

namespace T03.Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numMagic = int.Parse(Console.ReadLine());
            int combinations = 0;
            //x1 + x2 + x3 = n
            for (int x1=0; x1<=numMagic; x1++)
            {
                for(int x2 = 0; x2 <= numMagic; x2++)
                {
                    for(int x3 = 0; x3 <= numMagic; x3++)
                    {
                        if (x1 + x2 + x3 == numMagic)
                        {
                            combinations++;

                        }
                    }
                }
                 
            }
            Console.WriteLine(combinations);
        }
    }
}
