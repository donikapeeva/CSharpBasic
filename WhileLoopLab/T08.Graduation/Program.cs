using System;

namespace T08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четем име на ученик стринг
            string name = Console.ReadLine();
            //оценкa от всяка учебна година
            double rating = double.Parse(Console.ReadLine());
            //сбор от всички оценки
            double totalRating = 0;
            //средна оценка от всички
            double avarageRating = 0;
            //променлива за класът
            int currentClass = 1;
            //брой провали
            int fails = 0; 
            while(currentClass <= 12)//докато класовете са по-малко или равни на 12
            {
                if (rating < 4.00) //ако оценката е по-ниска от 4 провалът се увеличава с 1
                {
                    fails++;
                }
                if (fails == 2) //ако провалите станат 2 ученикът е изключен от училище.
                {
                    currentClass--; //класът слиза с 1 надолу, ученикът повтаря
                    Console.WriteLine($"{name} has been excluded at {currentClass} grade");//изписва се името на ученика и че е изключен от класа
                    break;
                }
                totalRating += rating; //тотален сбор на оценки = тотална оценка=0+оценка/събиране на всички оценки
                avarageRating = totalRating / currentClass;//средната оценка= тотален сбор на оценки/ класовете
                currentClass++;//класът се увеличава с едно
                if (currentClass > 12)//ако класът стане по-голям от 12
                {
                    Console.WriteLine($"{name} graduated. Average grade: {avarageRating:f2}");
                    break; //конзолата изписва името, ученикът минава и средна оценка
                }
                rating = double.Parse(Console.ReadLine());//превръщане на рейтинга от текст в число в while цикъла
            }

        }
    }
}
