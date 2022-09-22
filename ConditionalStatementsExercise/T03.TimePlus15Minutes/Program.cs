using System;

namespace T03.TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //четене на въведен час и минути 
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            //преобразуване на часове в минути и ги събираме с минутите 
            minutes = minutes + hours * 60;
            //добавяне на 15 мин. 
            int minafter15min = minutes + 15;
            //преобразуване на получените минути в час и минути
            int hoursAfter = minafter15min / 60;
            int minAfter = minafter15min % 60;

            //проверка дали :
            //ако часовете са >23ч. - изваждаме 24ч. 
            if (hoursAfter > 23)
            {
                hoursAfter = hoursAfter - 24;
            }
            //ако минутит са <10 се отпечатват с 0 
            if (minAfter < 10)
            {
                Console.WriteLine($"{hoursAfter}:0{minAfter}");
            }

            //отпечатване на резултат час:минути 
            else 
            {

                Console.WriteLine($"{hoursAfter}:{minAfter}");
            }

        }
    }
}
