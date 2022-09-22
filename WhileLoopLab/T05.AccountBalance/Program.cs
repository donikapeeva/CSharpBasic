using System;

namespace T05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // четене на дума 
            string input = Console.ReadLine();
            //променлива за цялата сума
            double totalAmount = 0;

            //докато въведената дума е различна от "NoMoreMoney"  
            while (input != "NoMoreMoney")
            {
                //въвеждане на стойности/суми от юзъра, които се конвертират от стринг в double
                double amount = double.Parse(input); 
                if(amount < 0)//ако стойностите са по-малки от нула се принтира "Invalid operation!"
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {amount:f2}");
                totalAmount += amount;
                input = Console.ReadLine();
            }
            //ako total e >0 

            if (totalAmount > 0)
            {
                //принтиране на тотал
                Console.Write($"Total: {totalAmount:f2}");
            }
            
        }
    }
}
