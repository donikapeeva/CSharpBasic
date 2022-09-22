using System;

namespace T07._AreaOfFigures
{
    internal class Program
    {
        // Ако фигурата е квадрат(square): на следващия ред се чете едно дробно число -дължина на страната му
        // Ако фигурата е правоъгълник(rectangle): на следващите два реда четат две дробни числа -дължините на страните му
        // Ако фигурата е кръг(circle): на следващия ред чете едно дробно число - радиусът на кръга
        // Ако фигурата е триъгълник(triangle): на следващите два реда четат две дробни числа -дължината на страната му и дължината на височината към нея
        static void Main(string[] args)
        {
            //read figures 
            string figureName = Console.ReadLine();
            //create condition and print result 
            if (figureName == "square")
            {
                double figureSide = double.Parse(Console.ReadLine());
                double squareArea = figureSide * figureSide;
                Console.WriteLine($"{squareArea:f3}");

            }
            else if (figureName == "rectangle")
            {
                double rectangleside1 = double.Parse(Console.ReadLine());
                double rectangleside2 = double.Parse(Console.ReadLine());
                double rectangleArea = rectangleside1 * rectangleside2;
                Console.WriteLine($"{rectangleArea:f3}");
            }
            else if (figureName == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double circleArea = radius * radius * Math.PI;
                Console.WriteLine($"{circleArea:f3}");
            }
            else if (figureName == "triangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double triangleArea = side1 * h / 2;
                Console.WriteLine($"{triangleArea:f3}");
            }
                
             
        }
    }
}
