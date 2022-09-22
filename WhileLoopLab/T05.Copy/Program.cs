using System;

namespace T05.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();  //команда която да спре цикъла 
            //променлива, която да съдържа сумата
            double totalAmount = 0;
           //цикъл, който върви, докато не се получи "NoMoreMoney"  
           while(command!= "NoMoreMoney")
           { //вътре в цикъла се чете вноска и след всяко прочитане се принтира 
                double money = double.Parse(command);                
                //"Increase: " + сумата и тя да се прибавя в сметката
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!"); //ако вноската е отрицателно число се принтира "Invalid operation!" и цикъла спира
                    break;
                }
                Console.WriteLine($"Increase: {money:f2}");
                totalAmount += money;

                command = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalAmount:f2}");


            //извън цикъла, когато той спре се принтира
            //"Total: " + общата сума в сметката форматирана до втория знак след десетичната запетая. 

        }
    }
}
