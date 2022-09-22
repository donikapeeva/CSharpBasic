using System;

namespace T08.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {  //първия ред ще получите името на ученика 
            string name = Console.ReadLine();
            //променлива за оценка за всеки клас
            double rating = double.Parse(Console.ReadLine());
            //променлива за сумата на всички оценки
            double totalRating = 0;
            //променлива за средна оценка
            double averRating = 0;
            //променлива за настоящ клас
            int currClass = 1;
            //променлива за брой скъсвания , ако са повече от едно, цикъла спира и се принтира
            int fail = 0;
            while (currClass <= 12)
            {
                
                if (rating < 4.00)
                {
                    fail++;
                }
                if (fail == 2)
                {
                    currClass--;
                    Console.WriteLine($"{name} has been excluded at {currClass} grade");
                    break;

                }
                totalRating += rating;
                averRating = totalRating / currClass;
                currClass++;
                if (currClass > 12)
                {
                    Console.WriteLine($"{name} graduated. Average grade: {averRating:f2}");
                    break;

                }
                rating = double.Parse(Console.ReadLine());
            }
           //"{име на ученика} has been excluded at {класа, в който е бил изключен} grade"




            //изчислява средната оценка на ученик от цялото му обучение.
            //ако ученикът завърши всички 12 класа се принтира
            //"{име на ученика} graduated. Average grade: {средната оценка от цялото обучение}"



        }
    }
}
