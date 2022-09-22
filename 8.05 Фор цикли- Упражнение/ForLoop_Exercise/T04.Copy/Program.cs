using System;

namespace T04.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Възрастта на Лили - цяло число в интервала [1...77]
            int liliAge = int.Parse(Console.ReadLine());
            //	Цената на пералнята - число в интервала[1.00...10 000.00]
            double wmPrice = double.Parse(Console.ReadLine());
            //	Единична цена на играчка -цяло число в интервала[0...40]
            int toyPrice = int.Parse(Console.ReadLine());
            double money = 0;
            int toys = 0;
            for(int i=1; i <= liliAge; i++)
            {
                if (i %2 == 0)
                {
                    money=money+((i * 5)-1);
                
                }
                else
                {
                    toys+=1;
                }
            }
            double totalToyPrice = toys * toyPrice;
            double totalMoney = totalToyPrice + money;
            double diff = wmPrice - totalMoney;
            if (totalMoney >= wmPrice)
            {
                Console.WriteLine($"Yes! {Math.Abs(diff):f2}");
                
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(diff):f2}");
            }

        }
    }
}
