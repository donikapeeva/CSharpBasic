using System;

namespace T03.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());//първоначално число
            int num = int.Parse(Console.ReadLine());//четем н на брой числа
            int sum = 0;//променлива за сумата на тези числа
            while (sum < number)//цикъл, който се върти, докато сумата е по-малка от първоначалното число
            {
                sum += num;//събираме сумата при всяко завъртане
                if (sum >= number)//ако сумата стане по-голяма или равна на първоначалното число
                {
                    break;//цикъла спира
                }
                num = int.Parse(Console.ReadLine());//отново се чете число, за да се заавърти цикъла
            }
            Console.WriteLine(sum);//принтиране на сумата след спиране на цикъла.
        }
    }
}
