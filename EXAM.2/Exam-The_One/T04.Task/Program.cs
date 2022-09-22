using System;

namespace T04.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	N – цяло число – 0 <= N < M
            int n = int.Parse(Console.ReadLine());
            //	M – цяло число – N < M <= 10000
            int m = int.Parse(Console.ReadLine());
            //	S – цяло числo – N <= S <= M
            int s = int.Parse(Console.ReadLine());
            //цикъл, който върви през адресните номера
            for(int i = m; i >= n; i--)
            {
                if(i % 2 == 0 && i % 3 == 0)
                {
                    if (i == s)
                    {
                        break;
                    }
                    Console.Write($"{i} ");
                }
                
            } 
            // ако някой от адресните номера от  M до N, които се делят на 2 и 3, е равен на адреса S, този адрес не трябва да се принтира и програмата трябва да приключи Break;
            //принтира на конзолата всички адресни номера от М до N, Които се делят едновременно на 2 и на 3 без остатък

            //На конзолата се принтират на един ред, всички адресни номера отговарящи на условията, разделени с интервал.
        }
    }
}
