using System;

namespace T02.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //брой незадоволителни оценки - цяло число в интервала [1…5]
            int failNum = int.Parse(Console.ReadLine());//зададен брой на допустимите грешни задачи
            double ratingsSum = 0;//сума на оценките
            int ratingsCount = 0;//брояч на оценките
            string lastTaskName = "";//име на последна задача
            int rating = 0;//оценка от последна задача
            int failCount = 0;

            string input = Console.ReadLine();//четене на дума инпут
            //цикъл до инпут "Enough" 
            while(input== "Enough")
            {
                lastTaskName = input;//присвояване на инпута към променливата за име на последната задача
                rating= int.Parse(Console.ReadLine());//чете се оценка от последната задача
                //всяка оценка се добавя към taskCount++
                ratingsSum += rating;
                ratingsCount++; //увеличаваме броя задачи
                //проверяваме дали оценката е задоволителна или не
                //     ако не е задоволителна failcount++
                
                if (rating <= 4)
                {
                    failCount++;
                    //     проверка дали failcount е станал равен или повече на failnum, 
                    //     отпечатва се 	"You need a break, {брой незадоволителни оценки} poor grades."
                    if (failCount == failNum)
                    { //или ако Марин получи определения брой незадоволителни оценки. по-малка или равна на 4.
                        Console.WriteLine($"You need a break, {failCount} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine();
            }

            //проверка защо цикъла е спрял
            if(failCount!=failNum)
            {
                //  "Average score: {средна оценка}"
                //  "Number of problems: {броя на всички задачи}"
                //  "Last problem: {името на последната задача}"
                double ratingAverage = ratingsSum / ratingsCount;
                Console.WriteLine($"Average score: {ratingAverage:f2}");
                Console.WriteLine($"Number of problems: {ratingsCount}");
                Console.WriteLine($"Last problem: {lastTaskName}");
            }






        }
    }
}
