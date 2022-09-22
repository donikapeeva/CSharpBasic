using System;

namespace T06.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//input дума който се чете
            //намиране на дължината на думата
            int lenght = input.Length;//взимане на дължината на думата в променлива за дължина
            int sum = 0;//променлива за сумата на всички гласни
            //буква	      a	  e	  i	  o	  u
            //стойност    1   2   3   4   5
            for( int index = 0; index < lenght; index++)//for цикъл, който върви през дължината на думата
            {
                char currLetter = input[index];//променлива за текъщата буква, която е равна на текущия индекс от думата. стъпката от брояча
                switch (currLetter)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                    

                }
                
            }
            int totalSum = sum;
            Console.WriteLine(totalSum);

        }
    }
}
