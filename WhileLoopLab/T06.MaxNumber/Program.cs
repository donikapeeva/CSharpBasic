using System;

namespace T06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //намиране на максималното число
            int maxNumber = int.MinValue;
            //въвеждане на числа стринг
            string input = Console.ReadLine();
            //dokato въведеното е различно от "Stop",  
            while (input != "Stop")
            {
                //превръщане на инпута от стринг в число инт в променлива Number
                int number = int.Parse(input);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                //четене на следащото число
                input = Console.ReadLine();
            } 
            //принтиране на максималното число
            Console.WriteLine(maxNumber);
        }
    }
}
