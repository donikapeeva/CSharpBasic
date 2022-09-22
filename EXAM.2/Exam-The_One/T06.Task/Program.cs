using System;

namespace T06.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //едно число – брой локации – цяло число в интервала [1.. 100]
            int locationNum = int.Parse(Console.ReadLine());
            double goldProfit = 0;
            double averGoldProfit = 0;
             
            for(int i=1; i <= locationNum; i++)
            {
                if (i > 1)
                {
                    goldProfit = 0;
                }
                //цикъл, в който се чете 
                //1.	На първия ред – очакван среден добив на ден злато – реално число в интервала [0.00.. 10000.00]
                //2.На втория ред – брой дни, в който ще се копае на дадената локация – цяло число в интервала[1..30] 
                double goldAverageProfitGoal = double.Parse(Console.ReadLine());
                int daysPerLocation= int.Parse(Console.ReadLine());
                //вътрешен цикъл, който върви през броя дни 
                //в него се чете •	Добито злато за деня – реално число в интервала [0.00.. 1000.00]
                for(int d=1; d <= daysPerLocation; d++)
                {
                    double goldPerDay = double.Parse(Console.ReadLine());
                    goldProfit += goldPerDay;
                    if (d == daysPerLocation)
                    {
                        break;
                    }
                }
                averGoldProfit = goldProfit / daysPerLocation;
                if (averGoldProfit >= goldAverageProfitGoal)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averGoldProfit:f2}.");
                    
                }
                else if(averGoldProfit < goldAverageProfitGoal)
                {
                    double diff = Math.Abs(goldAverageProfitGoal - averGoldProfit);
                    Console.WriteLine($"You need {diff:f2} gold.");
                    
                }
                if (i == locationNum)
                {
                    break;
                }
            }





        }
    }
}
