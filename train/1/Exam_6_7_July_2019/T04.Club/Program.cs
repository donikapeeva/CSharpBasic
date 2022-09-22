using System;

namespace P04_Club
{
    class P04_Club
    {
        static void Main(string[] args)
        {
            double profitGoal = double.Parse(Console.ReadLine());//чете се желаната печалба
            string input = Console.ReadLine();//инпут коктейл или Party
            double income = 0.0;//печалба

            while ("Party!" != input)//цикъл, който върви, докато не се получи команда Парти
            {
                int quantity = int.Parse(Console.ReadLine());//променлива за броя коктейли

                int price = quantity * input.Length;//изчисляване на цената на коктейлите с взимане на дължината на името
                double finalPrice = price;//презаписване на финална цена
                if (price % 2 != 0)//проверка ако цената е нечетна
                {
                    finalPrice =finalPrice-finalPrice*0.25;//тогава цената има 25% отстъпка
                }
                income += finalPrice;//цената се прибавя към печалбата
                profitGoal-= finalPrice;//цената се вади от желаната печалба
                if (profitGoal <= 0)//проверка дали желаната печалба не е равна или по-малка от 0 и е достигната
                {
                    break;//цикълът спира
                }

                input = Console.ReadLine();//отново се чете име на коктейл или парти
            }

            if ("Party!" == input)//ако инпут е Парти се отпечатва:
            {
                Console.WriteLine($"We need {profitGoal:F2} leva more.");
            }
            else //ако не се отпечатва, че целта е достигната
            {
                Console.WriteLine("Target acquired.");
            } 
            //отпечатване на печалбата.
            Console.WriteLine($"Club income - {income:F2} leva.");
        }
    }
}
