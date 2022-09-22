using System;

namespace T06.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Име на актьора - текст
            string actorName = Console.ReadLine();
            //Точки от академията - реално число в интервала[2.0... 450.5]
            double academyPoints = double.Parse(Console.ReadLine());
            //Брой оценяващи n - цяло число в интервала[1… 20]
            int numEvaluators= int.Parse(Console.ReadLine());
            double actorPoints = 0;
            //цикъл за оценяване
            for(int i = 1; i <= numEvaluators; i++)
            {
                //o	Име на оценяващия - текст
                string name = Console.ReadLine();
                // Точки от оценяващия -реално число в интервала[1.0... 50.0]
                double evaluatorsPoints= double.Parse(Console.ReadLine());
                int length = name.Length;
                actorPoints = academyPoints+ ((length * evaluatorsPoints) / 2);
                academyPoints = actorPoints;
                if(actorPoints>= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
                    break;
                }

            }
            double diff = 1250.5 - actorPoints;
            if (actorPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {Math.Abs(diff):f1} more!");
            }

            //актцорът получава точки =дължината на името на оценяващия умножено по точките, които дава делено на две
            //If проверка в цикъла дали точките са повече от 1250.5 , тогава се отпечатва "Congratulations, {име на актьора} got a nominee for leading role with {точки}!"
            //цикъла спира

            //ако точките не са достатъчни, извън цикъла се принтира "Sorry, {име на актьора} you need {нужни точки} more!"

        }
    }
}
