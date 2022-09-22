using System;

namespace T01.Excellent_Result
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            bool isExcellentgrade = grade >= 5.5;
            if (isExcellentgrade)
            {  
                Console.WriteLine("Excellent!"); 
            }
        }
    }
}
