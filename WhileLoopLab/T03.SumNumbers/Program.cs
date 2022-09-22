using System;

namespace T03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input from user 
            //int number 
            int targetNumber = int.Parse(Console.ReadLine());
            //variable за числата въведени от потребителя, до момента, в който числата не са равни на target number
            int sumOfNumbers = 0; 
            //докато сумата targetnumber не стане по-голямо от sum of numbers 
            while (targetNumber > sumOfNumbers)
            {
                //четем число от конзолата и запазваме в променливата sumOfNumbers и събираме с предишните числа 
                int inputNumber = int.Parse(Console.ReadLine());
                sumOfNumbers += inputNumber;
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
