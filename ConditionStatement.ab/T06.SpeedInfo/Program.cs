using System;

namespace T06.SpeedInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се скорост-число
            double speed = double.Parse(Console.ReadLine());

            //aко скоростта е до 10 се отпечатва "slow" 
            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            //ako skorostta e nad 10 i do 50 se otpe4atva "average" 
            else if (speed <= 50)
            {
                Console.WriteLine("average");
            }
            //skorost mejdu 50 i 150 se otpe4atva "fast" 
            else if (speed <= 150)
            {
                Console.WriteLine("fast");
            }
            // skorost mejdu 150 i 1000 se otpe4atva "ultra fast"
            else if (speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            //skorost nad 1000 se otpe4atva "extremely fast"
            else if (speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
