using System;

namespace Т03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се вход от конзолата стринг и се преобразува после в числа
            string input = Console.ReadLine();
            //променлива за  текущо число инт 
            int num;
            //променлива сума на простите числа primeSum
            //променлива сума на непростите числа nonprimeSum 
            int primeSum = 0;
            int nonprimeSum = 0;
            //цикъл, който сe изпънява докато не получим "stop"
            while (input != "stop")
            {
                num = int.Parse(input);//1.преобразуваме входа в число  

                if (num < 0)//проверка дали числото е отрицателно <0
                {
                    Console.WriteLine("Number is negative.");//отпечатване, че числото е отрицателно
                    input = Console.ReadLine();//четене на нов инпут
                    continue;//продължаване
                }
                //Проверка дали числото е просто или непросто  
                //2. Прости числа всички числа, които се делят без остатък единствено на 1 и себе си н%1==0; н%н==0 и добавяме към сумата на простите
                //3. Непрости числа всички, които имат повече от 1 делител и го добавяме към сумата на непростите числа
                bool isPrime = true; //булева променлива дали числото е просто 
                for(int i = 2; i<num; i++)//цикъл, който да проверява дали числото е просто. дели числото на две и числата нагоре до самото него
                {
                    if (num % i == 0)//ако числото разделено на 2 няма остатък
                    {
                        isPrime = false; //числото не е просто
                        break;
                    }
                }
                if (isPrime)//ako числото е просто
                {
                    primeSum += num; //простото число се прибавя към сумата на простите числа
                }
                else //ако не е просто
                {
                    nonprimeSum += num; //непростото число се прибавя към сумата на непростите числа
                }
                input = Console.ReadLine();
            }
            //отпечатва се резултата(primeSum или nonPrimesum)
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonprimeSum}");

        }
    }
}
