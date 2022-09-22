using System;

namespace T05.CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int lenghtOfText = text.Length;
            for(int index = 0; index <= lenghtOfText -1 ; index++)
            {
                char currentChar = text[index];
                Console.WriteLine(currentChar);
            }
        }
    }
}
