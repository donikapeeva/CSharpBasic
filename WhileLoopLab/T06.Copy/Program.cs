using System;

namespace T06.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се команда
            string input = Console.ReadLine();//стрингов инпут
            //променлива за най-голямо число
            int maxNUmber = int.MinValue;//променлива за макс числото, която да ни пази най=ниското число
            //цикъл, който се върти до командата "Stop", 
            while(input!= "Stop")//цикъл, който се върти до команда стоп
            {
                //вътре командата се парсва в число
                int currNumber = int.Parse(input);
                
                if(currNumber>maxNUmber)//ако последното въведено число ни е по-голямо от максималното
                {
                    maxNUmber = currNumber;//максималното се презаписва със стойност последното число
                }
                input = Console.ReadLine();//отново стринг инпут, за завъртане на цикъла
            }
            Console.WriteLine(maxNUmber);//принтираме максималното число, при команда стоп
        }
    }
}
