using System;

namespace Т01.ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine(); 
            while( word != "Stop")
            {
                Console.WriteLine(word);
                word = Console.ReadLine();

            }

        }
    }
}
