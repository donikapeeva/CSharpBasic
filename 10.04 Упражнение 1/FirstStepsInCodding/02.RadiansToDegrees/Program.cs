using System;

namespace _02.RadiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четем от конзолата радиани 
            double radians = double.Parse(Console.ReadLine());
            //преобразуваме радианите в градуси градус = радиан * 180 / π 
            double degrees = radians * 180 / Math.PI;
            //извеждане на резултата(градусите) в конзолата 
            Console.WriteLine(degrees);
        }
    }
}
