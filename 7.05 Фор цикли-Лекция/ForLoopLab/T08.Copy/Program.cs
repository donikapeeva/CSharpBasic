using System;

namespace T08.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());//инпут брой числа
            int maxNum = int.MinValue;//променлива за максималното число, да е по-голямо от минималното число в конзолата
            int minNum = int.MaxValue;//променлива за минималното число, да е по-малко от макс числото в конзолата
            for(int i=1; i <= numCount; i++)//цикъл, който започва от 1 и се върти докато стигне инпута за брой числа
            {
                int currNum = int.Parse(Console.ReadLine());//въвеждаме числа(според броя, който сме въвели)
                if (currNum > maxNum)//проверка дали текущото въведено число е по-голямо от макс числото
                {
                    maxNum=currNum;//ако е макс числото се презаписва със стойността на текущото число.
                }
                if (currNum < minNum)//проверка дали текущото въведено число е по-малко от минималното число
                {
                    minNum = currNum;//ако е минималното число се презаписва със стойността на текущото число
                }
            }
            Console.WriteLine($"Max number: {maxNum}");//принтира се макс числото
            Console.WriteLine($"Min number: {minNum}");//принтира се мин числото
        }
    }
}
