using System;

namespace T04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //цена на екскурзията  
            double tripPrice = Double.Parse(Console.ReadLine());
            //2.Брой пъзели - цяло число в интервала [0… 1000]
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            //6.Брой камиончета - цяло число в интервала 
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddies = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            //обща цена на броя на всяка играчки
            //Пъзел - 2.60 лв.
            //Говореща кукла -3 лв.
            //Плюшено мече -4.10 лв.
            //Миньон - 8.20 лв.
            //Камионче - 2 лв.
            double toyPrice = puzzles * 2.60 + dolls * 3 + teddies * 4.10 + minions * 8.20 + trucks * 2;
            //общ брой на играчките  
            int toys = puzzles + dolls + teddies + minions + trucks;
            //проверка дали броя играчки е равно/над 50   
            //1 ако е >= 50 начисляваме 25% отстъпка 
            if (toys >= 50)
            {
                toyPrice = toyPrice - toyPrice * 0.25;
            }
            //От цялата печлба изваждаме 10% за наем  
            toyPrice = toyPrice - toyPrice * 0.10;
            //проверка дали печалбата е достатъчна за екскурзия с difference променлива. 
            //1.ако парите стигат се отпечатва "Yes! {оставащите пари} lv left." 
            double difference = toyPrice - tripPrice;
            if (difference >= 0)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            //2.ако не достигат	"Not enough money! {недостигащите пари} lv needed." 
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(difference):f2} lv needed.");
            }

        }
    }
}
