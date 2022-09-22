using System;

namespace _09._Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Working days
            //плод	banana	apple	orange	grapefruit	kiwi	pineapple	grapes
            //цена    2.50  1.20    0.85    1.45        2.70    5.50        3.85

            //Weekend price
            //плод	banana	apple	orange	grapefruit	kiwi	pineapple	grapes
            //цена  2.70    1.25    0.90    1.60        3.00    5.60        4.20

            string typeOfFruits = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double totalSum = 0;


            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (typeOfFruits)
                    {
                        case "banana":
                            totalSum = qty * 2.50;
                            break;
                        case "apple":
                            totalSum = qty * 1.20;
                            break;
                        case "orange":
                            totalSum = qty * 0.85;
                            break;
                        case "grapefruit":
                            totalSum = qty * 1.45;
                            break;
                        case "kiwi":
                            totalSum = qty * 2.70;
                            break;
                        case "pineapple":
                            totalSum = qty * 5.50;
                            break;
                        case "grapes":
                            totalSum = qty * 3.85;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;

                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (typeOfFruits)
                    {
                        case "banana":
                            totalSum = qty * 2.70;
                            break;
                        case "apple":
                            totalSum = qty * 1.25;
                            break;
                        case "orange":
                            totalSum = qty * 0.90;
                            break;
                        case "grapefruit":
                            totalSum = qty * 1.60;
                            break;
                        case "kiwi":
                            totalSum = qty * 3.00;
                            break;
                        case "pineapple":
                            totalSum = qty * 5.60;
                            break;
                        case "grapes":
                            totalSum = qty * 4.20;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (totalSum > 0)
            {
                Console.WriteLine($"{totalSum:f2}");
            }



        }
    }
}