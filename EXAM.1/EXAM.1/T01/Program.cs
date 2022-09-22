using System;

namespace T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се прочитат 5 реда:
            //	На първи ред: цената в долари за процесора – реално число в интервала[200.00 … 3000.00]
            double processorUSD = double.Parse(Console.ReadLine());
            //	На втори ред: цената в долари за видео карта – реално число в интервала[100.00 … 1500.00]
            double videocardUSD= double.Parse(Console.ReadLine());
            //	На трети ред: цената в долари за една RAM памет – реално число в интервала[80.00... 500.00]
            double ramUSD= double.Parse(Console.ReadLine());
            //	На четвърти: ред брой RAM памети – цяло число в интервала[1... 4]
            int ramQuantity = int.Parse(Console.ReadLine());
            //   На пети ред: процент отстъпка – реално число в интервала[0.01 … 0.1] 
            double percentDiscount= double.Parse(Console.ReadLine());
            //процесор, видео карта и RAM памет,
            //1 долар = 1.57 лева.
            double processorBGN = processorUSD * 1.57;
            double videocardBGN = videocardUSD * 1.57;
            double ramBGN = ramUSD * 1.57;
            double totalRAMPrice = ramBGN * ramQuantity;
            //процесор и видео карта има отстъпка процент 
            double processorTotal = processorBGN - (processorBGN * percentDiscount);
            double videocardTotal = videocardBGN - (videocardBGN * percentDiscount);
            //пресмятаНе колко общо пари ще му трябват в лева 
            double totalPrice = processorTotal + videocardTotal + totalRAMPrice;
            //отпечатва се "Money needed - {общо лева} leva."
            Console.WriteLine($"Money needed - {totalPrice:f2} leva.");

        }
    }
}
