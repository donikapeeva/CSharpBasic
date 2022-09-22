
using System;

namespace Т01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // правоъгълна форма столове r- редове, c-колони 
            //три вида прожекции 
            //1. Premiere = cena na bilet 12.00lv 
            // 2. Normal = cena na bilet 7.50lv
            //3. Discount = cena na bilet 5.00lv
            // string projekcia 
            string projection = Console.ReadLine();
            // int redove 
            int r = int.Parse(Console.ReadLine());
            // int koloni  
            int c = int.Parse(Console.ReadLine());
            int seats = r * c;
            double profit = 0;
            switch (projection)
            {
                case "Premiere":
                    {
                       profit = seats * 12.00; 
                            }
                    break;
                case "Normal":
                    {
                        profit = seats * 7.50;
                    }
                    break;
                case "Discount":
                    {
                        profit = seats * 5.00;
                    }
                    break;
            }
            Console.WriteLine($"{profit:f2} leva");

            //za da se namerqt vsi4ki mesta se umnojava r*c , sled tova resultata* cenata spored denq
        }
    }
}
