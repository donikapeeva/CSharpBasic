using System;

namespace T03.CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се вход напитка - текст с възможности"Espresso", "Cappuccino" или "Tea"
            string drink = Console.ReadLine();
            //	Втори ред -захар - текст  с възможности "Without", "Normal" или "Extra"
            string sugar = Console.ReadLine();
            //	Трети ред -брой напитки - цяло число в интервала[1… 50]
            int drinksNumber = int.Parse(Console.ReadLine());
            double drinkSum = 0;
            double totalSum = 0;

            //	       Без захар	       Нормално	     Допълнително захар
            //Еспресо    0.90 лв./ бр.    1 лв. / бр.      1.20 лв. / бр.
            //Капучино   1.00 лв. / бр.   1.20 лв. / бр.   1.60 лв. / бр.
            //  Чай      0.50 лв. / бр.   0.60 лв. / бр.   0.70 лв. / бр.

            switch (drink)   //пресмятане на сумата според избраните напитки
            {
                case "Espresso":
                    if (sugar== "Without")
                    {
                        drinkSum = drinksNumber * 0.90;
                        totalSum = drinkSum - drinkSum * 0.35; //ако •	При избрана напитка без захар има 35% отстъпка.

                    }
                    else if(sugar == "Normal")
                    {
                        totalSum = drinksNumber * 1.00;
                    }
                    else if (sugar == "Extra")
                    {
                        totalSum = drinksNumber * 1.20;
                    }
                    if (drinksNumber >= 5) //	При избрана напитка "Espresso" и закупени поне 5 броя, има 25 % отстъпка.
                    {
                        totalSum = totalSum - totalSum * 0.25;
                    }
                break;
                    
                case "Cappuccino":
                    if (sugar == "Without")
                    {
                        drinkSum = drinksNumber * 1.00;
                        totalSum = drinkSum - drinkSum * 0.35; //ако •	При избрана напитка без захар има 35% отстъпка.

                    }
                    else if (sugar == "Normal")
                    {
                        totalSum = drinksNumber * 1.20;
                    }
                    else if (sugar == "Extra")
                    {
                        totalSum = drinksNumber * 1.60;
                    }

                    break;
                case "Tea":
                    if (sugar == "Without")
                    {
                        drinkSum = drinksNumber * 0.50;
                        totalSum = drinkSum - drinkSum * 0.35; //ако •	При избрана напитка без захар има 35% отстъпка.

                    }
                    else if (sugar == "Normal")
                    {
                        totalSum = drinksNumber * 0.60;
                    }
                    else if (sugar == "Extra")
                    {
                        totalSum = drinksNumber * 0.70;
                    }
                    break;

            }
            if (totalSum > 15.00) //	При сума надвишава 15 лева, 20 % отстъпка от крайната цена,  
            {
                totalSum = totalSum - totalSum * 0.20;
            }
            //принтиране на "You bought {брой напитки} cups of {напитка} for {крайна цена} lv."
            Console.WriteLine($"You bought {drinksNumber} cups of {drink} for {totalSum:f2} lv.");
           

            
            
             

            


            


        }
    }
}
