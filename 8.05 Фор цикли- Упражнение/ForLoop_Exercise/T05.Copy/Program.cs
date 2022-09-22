using System;

namespace T05.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Брой отворени табове в браузъра n - цяло число в интервала [1...10]
            int tabs = int.Parse(Console.ReadLine());
            //	Заплата - число в интервала[500...1500]
            int salary = int.Parse(Console.ReadLine());
            string site = "";
            //for цикъл за проверките
            for(int i=0; i<=tabs; i++)
            {
                //в който се чете име на сайт
                site = Console.ReadLine();
                if (site == "Facebook") //•	"Facebook" -> 150 лв.
                {
                    salary -= 150;
                }
                else if(site== "Instagram")//	"Instagram"-> 100 лв.
                {
                    salary -= 100;
                }
                else if(site== "Reddit")//	"Reddit"-> 50 лв.
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {  //	Ако по време на проверката заплатата стане по-малка или равна на 0 лева, на конзолата се изписва
                   //"You have lost your salary." и програмата приключва.
                    Console.WriteLine($"You have lost your salary.");
                    break;
                }


            }
            if (salary > 0) //ако парите не свършат, извън цикъла се принтира колко пари са останали
            {
                Console.WriteLine(salary);
            }

        }
    }
}
