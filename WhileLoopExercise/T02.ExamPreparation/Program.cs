using System;

namespace T02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //брой незадоволителни оценки - цяло число в интервала [1…5] int
            int fails = int.Parse(Console.ReadLine());
            double sumRatings = 0; //сбор от всички оценки
            int ratingsCount = 0; //брой на оценките инт
            string lastExercise = "";//име на последната въведена задача стринг
            int rating; //оценка за съответната задача
            int failCounter = 0; //брояч на незадоволителните оценки 
            string input = Console.ReadLine();
            

            //цикъл докато не получим "Enough"  или не стигнем зададения брой незадоволителни оценки
            while (input != "Enough")
            {
                // 1.Име на задача -текст(низ)
                // 2.Оценка -цяло число в интервала[2…6] 
                lastExercise = input;
                rating = int.Parse(Console.ReadLine());
                //изчисляване на сбора на всички оценки.броячът се увеличава с 1 
                sumRatings += rating; //сборът= сбор=0+оценката от текуща задача 
                ratingsCount++;//broqt се увеличава с 1 

                // проверка дали оценката е задоволителна или не <=4 броячът се увеличава с 1 count++ 
                if (rating <= 4)//ако оценката е <=4
                {
                    failCounter++; //броячът се увеличава с 1

                    if (failCounter == fails) //достигане на макс брой незадоволителни оценки
                    {

                        //ако е се отпечатва 	"You need a break, {брой незадоволителни оценки} poor grades." и break; 
                        Console.WriteLine($"You need a break, {failCounter} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine(); 
            }
            if (failCounter != fails)
            {
                double ratingAverage = sumRatings / ratingsCount;
                Console.WriteLine($"Average score: {ratingAverage:F2}");
                Console.WriteLine($"Number of problems: {ratingsCount}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }




            //проверка дали цикъла е приключил, защото е получил "Enough",  
            //отпечатваме 
            //	"Average score: {средна оценка}"
            //  "Number of problems: {броя на всички задачи}"
            //  "Last problem: {името на последната задача}"


        }
    }
}
