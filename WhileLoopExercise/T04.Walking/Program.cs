using System;

namespace T04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //променлива за брой извървяни стъпки 
            int steps = 0;
            //променлива за входа инпут 
            string input = Console.ReadLine();
           //цикъл, който се изпълнява, тя не достигне целта си от 10 000 крачки или не се прибере вкъщи 
           while(input!="Going home")
            {
                steps += int.Parse(input);//1.всеки път чете крачки, добавя ги останалите 
                if (steps >= 10000)//2.Проверка дали е постигнала 10 000 крачки
                {
                    break; //ако е постигнала целта се спира изпълнението на цикъла
                }
                input = Console.ReadLine();

            }
            //след цикъла се прави проверка защо е спрял
            if (input=="Going home") //1. ако е спрял заради "Going home"
            {
                steps += int.Parse(Console.ReadLine());//чете се колко крачки е направила вкъщи и се добавят към останалите 
            }
            
            if(steps < 10000)//проверка дали не е постигнала целта си от 10 000 крачки 
            {
                Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            }
            else //ако е постигнала целта си се отпечатва "Goal reached! Good job!"  "{разликата между стъпките} steps over the goal!" 
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{steps-10000} steps over the goal!");
            }








        }
    }
}
