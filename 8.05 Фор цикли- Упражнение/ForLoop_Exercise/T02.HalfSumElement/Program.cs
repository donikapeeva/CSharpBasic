using System;

namespace T02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четат се n=на брой числа
            //проверка дали сред списъка има число, което е резултат от събирането на другите 
            int n = int.Parse(Console.ReadLine());
            int sum = 0; //променлива за сумата
            int maxNum = int.MinValue; //променлива за най-голямото число от въведените
            int num = 0;//променлива за числото, което се чете
            
            for(int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum = sum + num;

                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            sum = sum - maxNum;//изваждаме най-голямото число
            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            } 
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum-maxNum)}");

            }

            
            //принтира-ако има има такова число "Yes" и на нов ред "Sum = "  + неговата стойност 
            //ако няма "No" и на нов ред "Diff = " + разликата между най-големия елемент и сумата на останалите (по абсолютна стойност)

        }
    }
}
