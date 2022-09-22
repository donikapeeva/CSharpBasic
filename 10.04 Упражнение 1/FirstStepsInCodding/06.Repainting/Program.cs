using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //необходимо количество найлон int , боя, разредител 
            int nylonQuantity = int.Parse(Console.ReadLine());
            int paintQuantity = int.Parse(Console.ReadLine());
            int thinnerQuantity = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double nylonPrice = (nylonQuantity+2) * 1.50;
            double paintPrice = (paintQuantity+(paintQuantity*0.10)) * 14.50;
            double thinnerPrice = thinnerQuantity * 5;
            //необходими материали боя+10%, найлон +2кв.м, и 0.40лв за торбички 
            double materialsPrice = nylonPrice + paintPrice + thinnerPrice + 0.40;
            //сума за майстори
            double laborPrice = (materialsPrice * 0.30) * 8;
            double totalPrice = materialsPrice + laborPrice;

            Console.WriteLine(totalPrice);

        }
    }
}
