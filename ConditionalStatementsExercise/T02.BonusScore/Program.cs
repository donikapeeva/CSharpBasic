using System;

namespace T02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четене на число   
            int number = int.Parse(Console.ReadLine());
            double bonus = 0;
             //ако числото е <= 100  
            if (number <= 100)
            {
                bonus = 5;
            }
            // ако числото е > 1000
            else if (number > 1000)
            {
                bonus = number * 0.1;
            }
            //ако числото е > 100 до 1000 
            else
            {
                bonus = number * 0.2;
            }
             
            //бонус точки за четни +1т., ако завършва на 5 се добавят 2т. 

            if (number%2 == 0)
            {
                bonus = bonus + 1;
            } 
            else if (number%10 == 5)
            {
                bonus = bonus + 2;
            }

            //отпечатване на бонус 
            Console.WriteLine(bonus);
            //отпечатване на число+бонус
            Console.WriteLine(number + bonus);

        }
    }
}
