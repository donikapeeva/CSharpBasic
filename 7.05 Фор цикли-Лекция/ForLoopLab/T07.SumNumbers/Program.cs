using System;

namespace T07.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се брой цели числа
            int count = int.Parse(Console.ReadLine());
            //в следващите редове се четат цели числа
            int sumOfNumbers = 0; //променлива за сумата на числата
            for (int counter = 0; counter < count; counter++) //фор цикъл, който да отброява въведения брой числа
            {
                int number = int.Parse(Console.ReadLine());//въведени числа, чиито брой съответства на count 
                sumOfNumbers += number; //sum да е равна на събиращите се въведени числа
            }
            Console.WriteLine(sumOfNumbers);
        }
    }
}
