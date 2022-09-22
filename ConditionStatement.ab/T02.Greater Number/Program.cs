using System;

namespace T02.Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb1 = int.Parse(Console.ReadLine());
            int numb2 = int.Parse(Console.ReadLine());  
             
            if (numb1 >= numb2)
            {
                Console.WriteLine(numb1); 
            } 
            else
            {
                Console.WriteLine(numb2);
            }
        }
    }
}
