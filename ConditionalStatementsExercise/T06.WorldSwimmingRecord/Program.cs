using System;

namespace T06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Рекордът в секунди – реално число в интервала
            double record = double.Parse(Console.ReadLine());
            //2.Разстоянието в метри – реално число в интервала
            double meters = double.Parse(Console.ReadLine());
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число
            double meterTime = double.Parse(Console.ReadLine());
            //изчисляване за какви секунди Иван трябва да преплува разстоянието  
            double goalTime = meters * meterTime;
            //съпротивлението на водата го забавя на всеки 15 м.с 12.5 секунди, които се прибавят към общото време
            double resistance = Math.Floor(meters/15) * 12.5;
            double totaltimeIvan = goalTime + resistance;
            double difference = totaltimeIvan - record;
            //резултатът 
            if (record > totaltimeIvan)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totaltimeIvan:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {difference:f2} seconds slower.");
            }


        }
    }
}
