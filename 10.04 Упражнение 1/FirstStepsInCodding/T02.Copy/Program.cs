using System;

namespace T02.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се ъгъл в радиани
            double radian = double.Parse(Console.ReadLine());
            //преобразуване на радиан в градус градус = радиан * 180 / π 
            double degrees = radian * 180 / Math.PI;

            //принт на числото
            Console.WriteLine(degrees);
        }
    }
}
