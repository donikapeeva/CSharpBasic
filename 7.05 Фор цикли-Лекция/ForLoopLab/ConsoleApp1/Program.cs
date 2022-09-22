using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четене на инт числа n На брой
            //програма, която проверява дали сумата от числата на четни позиции е == на сумата на числата на нечетни позиции. 
            int countOfInputs = int.Parse(Console.ReadLine());
            int evenSum = 0; //създаване на променлива за четните и нечетни суми 
            int oddSum = 0; 
            for(int counter=1; counter <= countOfInputs; counter++)//цикъл с брояч, който преминава през позициите и проверява дали каунтър, който започва от 1 е на четна или нечетна позиция 
            {
                int currenNumber = int.Parse(Console.ReadLine()); 
                if (counter%2 == 0)//ако при стъпката на counter е на четна позиция
                {
                    evenSum += currenNumber; //сумата на четните позиции
                }
                else
                {
                    oddSum += currenNumber;//сумата на нечетните позиции
                }
            } 
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                    Console.WriteLine($"Sum = {evenSum}");
            } 
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum-oddSum)}");
            }


            //	Ако сумите са равни да се отпечатат два реда: "Yes" и на нов ред "Sum = " + сумата; 
            // Ако сумите не са равни да се отпечат два реда: "No" и на нов ред "Diff = " + разликата.

        }
    }
}
