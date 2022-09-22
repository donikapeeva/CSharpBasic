using System;

namespace T07.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());//инпут за броя числа
            int inputSum = 0;//променлива за сумата от въведените числа
            for(int i=1;i <= numCount; i++)//цикъл, който започва от 1 и се върти, докато стигне сумата на инпута за броя числа и се увеличава с едно
            {
                int input = int.Parse(Console.ReadLine());//вътре в цикъла се четат числа, колкото е numCount
                inputSum += input;//в променливата за сумата се събира всяко въведено число
            }
            Console.WriteLine(inputSum);//извън цикъла се принтира цялата сума
            
        }
    }
}
