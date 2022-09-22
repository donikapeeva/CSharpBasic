using System;

namespace T09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //въвеждане на две редици числа
            int countOfInputs = int.Parse(Console.ReadLine());
            int leftSum = 0; //променливи за сумите
            int rightSum = 0;
            for (int counter=0; counter<2*countOfInputs; counter++)//цикъл за преминаване през въведените числа в две редици
            {
                int currentnumber = int.Parse(Console.ReadLine());
                if (counter < countOfInputs)//ако броячът е по-малък от броя въведени числа се влиза в лявата колона числа(първите)
                {
                    leftSum += currentnumber;
                }
                else //ако не е по-малък, влиза в дясната(следващите) колона числа
                {
                    rightSum += currentnumber;
                }
            } 
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($" No, diff = {Math.Abs(leftSum-rightSum)}");
            }
            //смятане на сбора във всяка редица
            //сравняване между двете редици
            //печатане
        }
    }
}
