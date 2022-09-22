using System;

namespace T03.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първият ред – отбор – текст с възможности: "Argentina", "Brazil", "Croatia", "Denmark"
            string country = Console.ReadLine();
            //	Вторият ред – вид сувенири – текст с възможности: "flags", "caps", "posters", "stickers"
            string souvenirsType = Console.ReadLine();
            //	Третият ред – брой закупени сувенири – цяло число в интервала[1…200] 
            int souvenirsCount = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            double flagsPrice = 0;
            double capsPrice = 0;
            double postersPrice = 0;
            double stickersPrice = 0;
            switch (country)
            {
                case "Argentina":
                    if (souvenirsType == "flags")
                    {
                        flagsPrice = souvenirsCount * 3.25;
                    }
                    else if (souvenirsType == "caps")
                    {
                        capsPrice = souvenirsCount * 7.20;
                    }
                    else if (souvenirsType == "posters")
                    {
                        postersPrice = souvenirsCount * 5.10;
                    }
                    else if (souvenirsType == "stickers")
                    {
                        stickersPrice = souvenirsCount * 1.25;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                    }
                    break;
                case "Brazil":
                    if (souvenirsType == "flags")
                    {
                        flagsPrice = souvenirsCount * 4.20;
                    }
                    else if (souvenirsType == "caps")
                    {
                        capsPrice = souvenirsCount * 8.50;
                    }
                    else if (souvenirsType == "posters")
                    {
                        postersPrice = souvenirsCount * 5.35;
                    }
                    else if (souvenirsType == "stickers")
                    {
                        stickersPrice = souvenirsCount * 1.20;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                    }

                    break;
                case "Croatia":
                    if (souvenirsType == "flags")
                    {
                        flagsPrice = souvenirsCount * 2.75;
                    }
                    else if (souvenirsType == "caps")
                    {
                        capsPrice = souvenirsCount * 6.90;
                    }
                    else if (souvenirsType == "posters")
                    {
                        postersPrice = souvenirsCount * 4.95;
                    }
                    else if (souvenirsType == "stickers")
                    {
                        stickersPrice = souvenirsCount * 1.10;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                    }

                    break;
                case "Denmark":
                    if (souvenirsType == "flags")
                    {
                        flagsPrice = souvenirsCount * 3.10;
                    }
                    else if (souvenirsType == "caps")
                    {
                        totalPrice = souvenirsCount * 6.50;
                    }
                    else if (souvenirsType == "posters")
                    {
                        totalPrice = souvenirsCount * 4.80;
                    }
                    else if (souvenirsType == "stickers")
                    {
                        totalPrice = souvenirsCount * 0.90;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                    }

                    break;
                default:
                    Console.WriteLine("Invalid country!");
                    break;
            }

            Console.WriteLine($"Pepi bought {souvenirsCount} {souvenirsType} of {country} for {totalPrice:f2} lv.");

            // 	           Аржентина	Бразилия	Хърватия	Дания
            //флагчета     3.25 лв.    4.20 лв.    2.75 лв.    3.10 лв.
            //шапки        7.20 лв.    8.50 лв.    6.90 лв.    6.50 лв.
            //плакати      5.10 лв.    5.35 лв.    4.95 лв.    4.80 лв.
            //стикери      1.25 лв.    1.20 лв.    1.10 лв.    0.90 лв.




            //изчислява сумата за закупените сувенири.


            //отпечата на конзолата един ред :
            //	Ако страната и стоката са правилно зададени:
            // ''Pepi bought {брой сувенири} {вид сувенири} of {отбор} for {крайна сума} lv.''
            //	Ако страната не е правилно зададена:
            //"Invalid country!"
            //	Ако стоката не е правилно зададена:
            //"Invalid stock!"
            //Резултатът да е форматиран до втората цифра след десетичната запетая.


        }
    }
}
