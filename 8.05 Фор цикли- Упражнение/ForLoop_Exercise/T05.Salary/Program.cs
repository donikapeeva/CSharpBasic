using System;

namespace T05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се
            //	Брой отворени табове в браузъра n - цяло число в интервала [1...10]
            int tabs = int.Parse(Console.ReadLine());
            //Заплата - число в интервала[500...1500]
            double salary = double.Parse(Console.ReadLine());
            //След това n – на брой пъти се чете име на уебсайт – текст 
            string site = string.Empty; 
            for(int i=1; i<=tabs; i++)
            {
                site = Console.ReadLine(); //глоби:
                                           //"Facebook"-> 150 лв.
                                           //"Instagram"-> 100 лв.
                                           //"Reddit"-> 50 лв. 

                if (site== "Facebook")
                {
                    salary -= 150;
                } 
                else if (site == "Instagram")
                {
                    salary -= 100;
                }
                else if(site=="Reddit")
                {
                    salary -= 50;
                }
                 
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                } 
                
            } 
            if (salary > 0)
            {
                Console.WriteLine(Math.Round(salary));
            }
            


            //•	Ако по време на проверката заплатата стане по-малка или равна на 0 лева, на конзолата се изписва 
            //"You have lost your salary." и програмата приключва.
          	//В противен случай след проверката на конзолата се изписва остатъкът от заплатата(да се изпише като цяло число).



        }
    }
}
