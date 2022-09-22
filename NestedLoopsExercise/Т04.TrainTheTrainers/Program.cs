using System;

namespace Т04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четем броя на журито инт
            int n = int.Parse(Console.ReadLine());
            //променлива за име на презентация или командата "Finish" -тя слага край на четенето
            string input = Console.ReadLine();
            double presentationEv;//променлива за сбор на всички оценки за моментна презентация- сбор на оценките, разделен на броя на журито
            int presentationCount = 0;//променлива за общ брой презентации- брояч на презентациите
            double evaluation =0;//променлива за сбор на всички средни оценки за презентации, за да намерим цялостна средна оценка

            //четем имена на презентации, докато не получим "Finish" (външен цикъл while)
            while (input != "Finish")
            {
                //нашият инпут е име на моментната презентация
                //нулираме сбора на всички оценки за моментна презентация
                presentationEv = 0;

                //за всяка презентация трябва да получим оценка от всеки оценяващ(вътрешен for цикъл) 
                for (int i = 1; i <= n; i++)
                {
                    //събираме оценките
                    presentationEv += double.Parse(Console.ReadLine());
                }

                //изчисляваме средната оценка за моментната презентация
                presentationEv = presentationEv / n;
                //отпечатваме каква е средната оценка за моментната презентация
                Console.WriteLine($"{input} - {presentationEv:f2}.");
                //добавяме я към сбора на всички срецни оценки от презентации
                evaluation += presentationEv;
                //увеличаваме броя на презентациите с 1  
                presentationCount++;
                //прочитане на нов вход
                input = Console.ReadLine();
            }
            //отпечатване на средната оценка на студента от всички презентации- сбор на оценките делено на брой презентации
            evaluation /= presentationCount;

            Console.WriteLine($"Student's final assessment is {evaluation:f2}.");


        }
    }
}
