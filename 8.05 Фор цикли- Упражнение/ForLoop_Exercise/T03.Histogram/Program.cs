using System;

namespace T03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//брой въведени числа
            //Брой на числата в съответния диапазон
            double p1 = 0;//< 200
            double p2 = 0;//>=200 … <=399
            double p3 = 0;//>=400 … <=599
            double p4 = 0;//>=600 … <=799
            double p5 = 0;//>= 800

            int num = 0;//въведено число

            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());//четене на въведеното число при всяко завъртане на цикъла 
                if (num<200)//ако въведеното число е <200
                {
                    p1 = p1 + 1;//p1 Отчита число <200 и се увеличава с 1
                }
                else if(num < 400)
                {
                    p2 = p2 + 1;
                }
                else if (num < 600)
                {
                    p3 = p3 + 1;
                }
                else if (num <800)
                {
                    p4 = p4 + 1;
                }
                else
                {
                   p5 = p5 + 1;
                }
            }
            p1 = p1 / n * 100;//изчисляване какъв процент са числата към п1 от всички 
            p2 = p2 / n * 100;
            p3 = p3 / n * 100;
            p4 = p4 / n * 100;
            p5 = p5 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");


        }
    }
}
