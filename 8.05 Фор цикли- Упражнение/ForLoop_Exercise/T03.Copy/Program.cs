using System;

namespace T03.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четат се н-на брой числа между 1 и 1000
            int numCount = int.Parse(Console.ReadLine());
            //p1 под 200
            double p1 = 0;
            //p2 от 200 до 399
            double p2 = 0;
            //p3, от 400 до 599
            double p3 = 0;
            //p4 от 600 до 799
            double p4 = 0;
            //p5  от 800 нагоре
            double p5 = 0;
            for(int i=1; i <= numCount; i++)
            {
                int input= int.Parse(Console.ReadLine());
                if (input < 200)
                {
                    p1++;
                }
                else if (input >= 200 && input <= 399)
                {
                    p2++;
                }
                else if (input >= 400 && input <= 599)
                {
                    p3++;
                }
                else if (input >= 600 && input <= 799)
                {
                    p4++;
                }
                else if (input >= 800)
                {
                    p5++;
                }                

            }
            double p1Percent = p1 / numCount * 100;
            double p2Percent= p2 / numCount * 100;
            double p3Percent = p3 / numCount * 100;
            double p4Percent = p4 / numCount * 100;
            double p5Percent = p5 / numCount * 100;

            Console.WriteLine($"{p1Percent:f2}%");
            Console.WriteLine($"{p2Percent:f2}%");
            Console.WriteLine($"{p3Percent:f2}%");
            Console.WriteLine($"{p4Percent:f2}%");
            Console.WriteLine($"{p5Percent:f2}%");

        }
    }
}
