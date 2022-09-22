using System;

namespace T08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четене на цели числа 
            int count = int.Parse(Console.ReadLine()); //променлива за брой въведени числа
            //да се принтират най-голямото и най-малкото
            int maxNumber = int.MinValue; //променлива за макс число над минималната стойност
            int minNumber = int.MaxValue; // променлива за минимално число под максималната стойност 
            for (int counter = 0; counter < count; counter++) //цикъл за преминаване през въведените числа
            {
                int currentNumber = int.Parse(Console.ReadLine()); //четене на въвеждане на числа
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
                if (currentNumber < minNumber)//ако въведенето число е по-малко от минималното число на конзолата
                {
                    minNumber = currentNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
