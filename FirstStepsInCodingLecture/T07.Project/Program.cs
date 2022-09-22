using System;

namespace T07.Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheArchitect = Console.ReadLine();
            int numbersOfProjects = int.Parse(Console.ReadLine());
            int individualProjectTime = 3;
            int timeForAllProjects = numbersOfProjects * individualProjectTime;
            Console.WriteLine($"The architect {nameOfTheArchitect} will need {timeForAllProjects} hours to complete {numbersOfProjects} project/s.");
        }
    }
}
