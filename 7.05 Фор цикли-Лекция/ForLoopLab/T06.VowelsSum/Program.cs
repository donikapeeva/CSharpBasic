using System;

namespace T06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. string za text
            string text = Console.ReadLine();
            //буква	       a  e 	i	o	u
            // стойност     1   2   3   4   5
            // 2.променлива за броене на дължината на текста
            int lengthOfText = text.Length;
            //3. променлива за сумата на събраната стойност на буквите
            int sum = 0;
            //for цикъл през всички букви от думата, индексът да е по-кратък от думата и да се увеличава с един знак
            for (int index = 0; index < lengthOfText; index++)
            {
                //променлива за четене на буквите в думата чрез индексирането
                char currenLetter = text[index];
                switch (currenLetter)
                {   //разписваме и прибавяме към сумата стойността на гласните
                    case 'a':
                        sum++; //+1
                        break;
                    case 'e':
                        sum += 2; //+2
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
            Console.WriteLine(sum);
        } 
    }
}
