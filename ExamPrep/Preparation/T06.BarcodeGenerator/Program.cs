using System;

namespace T06.BarcodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	Две четирицифрени числа, които показват обхвата на баркодовете, които трябва да промените.
            //	Първи ред – четирицифрено число – началото на обхвата.Цяло число в интервала[1000…9999]
            int numOne = int.Parse(Console.ReadLine());
            //	Втори ред – четирицифрено число – края на обхвата.Цяло число в интервала[1000…9999]
            int numTwo = int.Parse(Console.ReadLine());
            for(int b1=numOne/1000;b1<=numTwo/1000; b1++)
            {
                if (b1 % 2 == 0)
                {
                    continue;
                }
                for(int b2 = numOne / 100 % 10; b2 <= numTwo / 100 % 10; b2++)
                {
                    if (b2 % 2 == 0)
                    {
                        continue;
                    }
                    for (int b3 = numOne/10%10; b3 <= numTwo/10%10; b3++)
                    {
                        if (b3 % 2 == 0)
                        {
                            continue;
                        }
                        for (int b4= numOne%10; b4 <=numTwo%10; b4++)
                        {
                            if (b4 % 2 == 0)
                            {
                                continue;
                            }
                            Console.Write($"{b1}{b2}{b3}{b4} ");
                        }
                    }
                }
            }

        }
    }
}
