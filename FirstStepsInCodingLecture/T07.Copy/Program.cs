using System;

namespace T07.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Името на архитекта - текст
            string name = Console.ReadLine();
            //2.Брой на проектите, които трябва да изготви - цяло число в интервала[0 … 100
            int projects = int.Parse(Console.ReadLine());
            //всеки проект отнема по 3 часа 
            //пресмятане на нужните часове брой проекти по 3
            int projectsTime = projects * 3;
            //отпечатване на •	"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."
            Console.WriteLine($"The architect {name} will need {projectsTime} hours to complete {projects} project/s.");
        }
    }
}
