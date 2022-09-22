using System;

namespace T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	цел за деня – цяло число в интервала [1 … 5000] 
            int moneyGoal = int.Parse(Console.ReadLine());
            string input = "";
            
            int haircut = 0;
            int color = 0;

            //while цикъл, в който върви до команда "closed"
            while (input != "closed")
            {
                double money = 0;

                if (input == "haircut")
                {
                    if (input == "mens")
                    {
                        money += 15.00;
                    }
                    else if (input == "ladies")
                    {
                        money += 20.00;
                    }
                    
                }
                    



                    if (totalMoney >= moneyGoal)
                    {
                        Console.WriteLine($"You have reached your target for the day!");
                        Console.WriteLine($"Earned money: {totalMoney}lv.");
                    }
                    else
                    {
                        double diff = moneyGoal - totalMoney;
                        Console.WriteLine($"Target not reached! You need {diff}lv. more.");
                        Console.WriteLine($"Earned money: {totalMoney}lv.");
                    }
                //•	Подстригване (haircut):
                //o Мъжко(mens) -15лв.
                //o Дамско(ladies) – 20лв.
                //o Детско(kids) – 10лв.
                //•	Боядисване(color):
                //o Поддръжка(touch up) – 20лв.
                //o Пълно боядисване(full color) – 30лв.

                //if prowerka дали е достигнала целта
            }

        }
    }
}
