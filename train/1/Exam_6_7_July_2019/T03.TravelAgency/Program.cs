using System;

namespace T03.TravelAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Име на града - текст с възможности ("Bansko",  "Borovets", "Varna" или "Burgas")
            string city = Console.ReadLine();
            //2.Вид на пакета -текст с възможности("noEquipment",  "withEquipment", "noBreakfast" или "withBreakfast")
            string conditions= Console.ReadLine();
            //3.Притежание на VIP отстъпка - текст с възможности  "yes" или "no"
            string vip= Console.ReadLine();
            //4.Дни за престой -цяло число в интервала[1 … 10000] 
            int days=int.Parse(Console.ReadLine());
            double price = 0;
            bool isValid = false; //булева променлива за проверка дали инпутите са валидни
            //ако повече от 7 дни, получава единия ден безплатно.
            
            if (days > 7)
            {
                days = days - 1;
            }
            //switch По град "Bansko",  "Borovets" или "Varna" или "Burgas"

            switch (city)
            {
                //1.Банско или Боровец
                //               с екипировка    без екипировка
                //цена на ден      100лв              80лв
                //вип отстъпка     10%                 5% 
                case "Bansko":
                case "Borovets":
                    if(conditions== "withEquipment")
                    {
                        price = days * 100;
                        if (vip == "yes")
                        {
                            price = price - price * 0.10;
                        }
                    }
                    else if(conditions== "noEquipment")
                    {
                        price = days * 80;
                        if (vip == "yes")
                        {
                            price = price - price * 0.05;
                        }
                    }
                    else
                    {
                        isValid = true;
                    }
                    break;

                //2. Варна или Бургас
                //               със закуска       без закуска
                //цена на ден      130лв              100лв
                //вип отстъпка     12%                 7% 
                case "Varna":
                case "Burgas":
                    if(conditions == "withBreakfast")
                    {
                        price = days * 130;
                        if (vip == "yes")
                        {
                            price = price - price * 0.12;
                        }
                    }
                    else if (conditions == "noBreakfast")
                    {
                        price = days * 100;
                        if (vip == "yes")
                        {
                            price = price - price * 0.07;
                        }
                    }
                    else
                    {
                        isValid = true;
                    }
                    break;
                default:
                        isValid = true;
                    break;
            }
            if(isValid)
            {
                Console.WriteLine("Invalid input!");
            }
            else if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");

            }
            else
            {
                Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
            }
            
            

             

            //•	Когато потребителят е въвел всички данни правилно, отпечатваме: 
            //"The price is {цената, форматирана до втория знак}lv! Have a nice time!"
            //•	Ако потребителят е въвел по - малко от 1 ден за престой, отпечатваме:
            //"Days must be positive number!"
            //•	Когато при въвеждането на града или вида на пакета се въведат невалидни данни, отпечатваме: "Invalid input!"



        }
    }
}
