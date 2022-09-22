using System;

namespace T07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //намиране на мин число , променлива
            int minNumber = int.MaxValue;
            //въвеждане на числа стринг
            string input = Console.ReadLine();
            //dokato въведеното е различно от "Stop",  
            while (input != "Stop")
            {
                //превръщане на инпута от стринг в число инт в променлива Number
                int number = int.Parse(input);
                if (number < minNumber)
                {
                    minNumber = number;
                }
                //четене на следащото число
                input = Console.ReadLine();
            }
            //принтиране на минималното число
            Console.WriteLine(minNumber);
        }
    }
}
