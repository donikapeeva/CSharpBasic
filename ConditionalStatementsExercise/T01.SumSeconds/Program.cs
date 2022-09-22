using System;

namespace T01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //три състезателя - прочитане и запазване в променлива
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());
            int player3 = int.Parse(Console.ReadLine());
            //намиране на общото време на тримата състезателя(в секунди) 
            int time = player1 + player2 + player3;
            //отделяне на времето в минути и в секунди 
            int min = time / 60;
            int sec = time % 60;
            //конзолата изписва резултата
            //1. ако секундите са по-малко от 10, отпред трябва да има нула; 
            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            //2. Ако са >= 10 се отпечатва 
            else if (sec >= 10)
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
