using System;

namespace T08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете Брой турнири, в които е участвал – цяло число в интервала [1…20] 
            int n = int.Parse(Console.ReadLine());
            //Начален брой точки в ранглистата - цяло число в интервала[1...4000] 
            double pointsStart = double.Parse(Console.ReadLine());
            string ranking = string.Empty;
            double wins = 0;
            double points = 0;
            
            double averagePoints = 0;

            //променливи : точки от турнири; брой спечелени турнири; среден брой точки точки турнири/брой турнири
            for (int i =1; i <=n; i++)
            {
                ranking = Console.ReadLine();                     //проверка как е финиширал
                //точки според това как завършва 	W - ако е победител получава 2000 точки(добавяме и 1 към брой спечелени турнири )
                //                               	F - ако е финалист получава 1200 точки
                //                               	SF - ако е полуфиналист получава 720 точки 
                //добавяне на точките към началния брой точките.
                if (ranking == "W")
                {
                    points += 2000;
                    wins += 1;

                } 
                else if (ranking == "F")
                {
                    points += 1200;
                }
                else if (ranking == "SF")
                {
                    points += 720;
                }
                averagePoints = points / n;
            }
            points = pointsStart + points;
            
            wins = wins/ n * 100; //изчисляване % на спечелените турнири -брой спечелени турнири/ брой турнири*100

            //	"Final points: {брой точки след изиграните турнири}"
            //	"Average points: {средно колко точки печели за турнир}"
            //	"{процент спечелени турнири}%" 
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{wins:f2}%");








        }
    }
}
