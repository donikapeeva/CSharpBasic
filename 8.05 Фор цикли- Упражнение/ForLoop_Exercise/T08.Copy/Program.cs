using System;

namespace T08.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Брой турнири, в които е участвал – цяло число в интервала [1…20] 
            int competitions = int.Parse(Console.ReadLine());
            //	Начален брой точки в ранглистата - цяло число в интервала[1...4000]
            int startPoints= int.Parse(Console.ReadLine());
            string rang = "";
            int allPoints = 0;
            double wins = 0;
            //цикъл минаващ през турнирите
            for(int i=1; i <= competitions; i++)
            {
                rang = Console.ReadLine();
                //във всеки цикъл се чете как е зявършил Достигнат етап от турнира – текст – "W", "F" или "SF"
                if (rang == "W")
                {
                    allPoints += 2000; //	W - ако е победител получава 2000 точки
                    wins++; //броим победите
                }
                else if (rang == "F")
                {
                    allPoints += 1200; //	F - ако е финалист получава 1200 точки
                }
                else if (rang == "SF")
                {
                    allPoints += 720; //	SF - ако е полуфиналист получава 720 точки
                }
          
            }
            //изчисляване на общия брой точки
            int totalPoints = startPoints + allPoints;
            //Също изчислете колко точки средно печели от всички изиграни турнири и
            double averagePoints = allPoints / competitions;
            //колко процента от турнирите е спечелил. 
            double winsPercent = (wins/competitions) * 100;

            //•	"Final points: {брой точки след изиграните турнири}"
            Console.WriteLine($"Final points: {totalPoints}");
            //	"Average points: {средно колко точки печели за турнир}"
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            //	"{процент спечелени турнири}%"
            Console.WriteLine($"{winsPercent:f2}%");


        }
    }
}
