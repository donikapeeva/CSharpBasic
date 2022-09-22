using System;

namespace T07.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //стрингов инпут
            string input = Console.ReadLine();
            //променлива за най-малкото число, което да пази най-голямото число вътре
            int minNumber = int.MaxValue;
            //цикъл, който се върти до Stop 
            while (input != "Stop")
            {
                int number = int.Parse(input);//четем число(парснат стринг)
                if (number < minNumber)
                {
                    minNumber = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
