using System;

namespace Т09.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCount = int.Parse(Console.ReadLine());//чете се брой инпути, които се умножават по 2 за две редици
            int leftSum = 0;//променлива за сумата от левите числа
            int rightSum = 0;//променлива за сумата от десните числа
            for (int i = 1; i <= 2*numCount; i++)//цикъл с брояч, който започва от 1 и свършва, когато стане равен на броя инпути по 2, увеличава се с 1
            {
                int input= int.Parse(Console.ReadLine());//четем число
                if (i <= numCount)//проверка, ако брояча все още е по-малък или равен на броя инпути
                {
                    leftSum += input; //в лявата колона сумата расте
                }
                else//ако се превиши брояча, прави втора колона
                {
                    rightSum += input;//дясната сума се увеличава
                }
            }
            int diff = leftSum - rightSum;//променлива за разликата между двете суми
            if (leftSum == rightSum)//ако лявата и дясната са равни
            {
                Console.WriteLine($"Yes, sum = {leftSum}");//принтира се сумата
            }
            else//ако не са равни
            {
                Console.WriteLine($" No, diff = {Math.Abs(diff)}");//принтира се разликата
            }
        }
    }
}
