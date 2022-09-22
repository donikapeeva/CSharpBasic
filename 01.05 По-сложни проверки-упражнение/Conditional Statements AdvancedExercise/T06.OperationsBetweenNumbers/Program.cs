using System;

namespace T06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // инт число 1 
            int num1 = int.Parse(Console.ReadLine());
            // инт число 2 
            int num2 = int.Parse(Console.ReadLine());
            // оператор Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%).  
            char operation = char.Parse(Console.ReadLine());

            // при + - * се отпечатва n1 (operator) n2 = result - even и се проверява дали е четен %2 == 0 even или не odd
            if (operation == '+' || operation == '-' || operation == '*')
            {
                int result =0;
                string evenOrOdd = "even";
                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    default:
                        result = num1 * num2;
                        break;
                }
                if (result%2!=0)
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine($"{num1} {operation} {num2} = {result} - {evenOrOdd}");

            }
            else //(operation == '/' || operation == '%')
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else if (operation == '/')
                {
                    double result = 1.0 * num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                }

            }
            // при / резултат 	"{N1} / {N2} = {резултат:f2}"
            // модулно деление % се отпечатва остатък o	"{N1} % {N2} = {остатък}" 
            // ако се дели на / % 0 	"Cannot divide {N1} by zero"
        }
    }
}
