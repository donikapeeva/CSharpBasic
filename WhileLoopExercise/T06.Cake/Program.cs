using System;

namespace T06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се ширина и дължина 
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            //изчислява се колко е голяма тортата 
            int cakeSize = w * h; //брой парчета 
            int cakePieces = 0;
                string input = Console.ReadLine();
            //цикъл, който се върти докато тортата не свърши или не получим вход "STOP"   
            while (input!="STOP")
            {
                cakePieces = int.Parse(input);

                if (cakeSize >= cakePieces)// проверка дали има достатъчно парчета, колкото гостите искат 
                {  //1.ако има се изваждат броя на парчетата от тортата
                    cakeSize -= cakePieces;
                }
                else
                {   //2. ако няма-отпечатване колко парчета не стигат;спираме цикъла
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize-cakePieces)} pieces more.");
                    break;
                }
                input = Console.ReadLine(); //прочитане на нов вход от конзолата  
            }
            //проверка дали са останали парчета и колко 

            if (input=="STOP")
            {
                Console.WriteLine($"{cakeSize} pieces are left.");

            }






        }
    }
}
