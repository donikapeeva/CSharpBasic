using System;

namespace Т04.Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Височина на стената - цяло число [0… 100]
            int h = int.Parse(Console.ReadLine());
            //2.Ширина на стената -цяло число[0… 100]
            int w= int.Parse(Console.ReadLine()); 
            int percent= int.Parse(Console.ReadLine());//процент, който се вади от стената
            double totalArea = h * w * 4;//изчисляване на площта На стените
            double toPaint = Math.Ceiling(totalArea - totalArea*percent / 100);//изчисляване на площта за боядисване
            
            string input = Console.ReadLine();
            //цикъл, който се върти, докато "Tired!" или докато не бъдат боядисани всички стени
            while (input!= "Tired!")
            {
                int paintL = int.Parse(Console.ReadLine());
                toPaint = toPaint - paintL;
                if (toPaint <= 0)
                {
                    break;
                }
                input = Console.ReadLine();

            }
            if (toPaint == 0)
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }
            else if (toPaint > 0)
            {
                Console.WriteLine($"{toPaint} quadratic m left.");
            }
            else
            {
                Console.WriteLine($"All walls are painted and you have {toPaint * -1} l paint left!");
            }

        }
    }
}
