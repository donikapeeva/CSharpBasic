using System;

namespace T09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //конзолата чете 
            //инт дни престой
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            days = days - 1;
            double price = 0;
            double finalPrice = 0;
            if (days >0 && days <= 10)
            {
                if (roomType == "apartment")
                {
                    price = days * 25;
                    price = price - price * 0.30;
                }
                else if (roomType == "president apartment")
                {
                    price = days * 35;
                    price = price - price * 0.10;
                }
                else
                {
                    price = days * 18;
                }
            }
            else if (days > 10 && days <= 15)
            {
                if (roomType == "apartment")
                {
                    price = days * 25;
                    price = price - price * 0.35;
                }
                else if (roomType == "president apartment")
                {
                    price = days * 35;
                    price = price - price * 0.15;
                }
                else
                {
                    price = days * 18;
                }
            }
            else
            {
                if (roomType == "apartment")
                {
                    price = days * 25;
                    price = price - price * 0.50;
                }
                else if (roomType == "president apartment")
                {
                    price = days * 35;
                    price = price - price * 0.20;
                }
                else
                {
                    price = days * 18;
                }
            }
            if (rating == "positive")
            {
                finalPrice = price + price * 0.25;
                Console.WriteLine($"{finalPrice:f2}");
            } 
            else if (rating == "negative")
            {
                finalPrice = price - price * 0.10;
                Console.WriteLine($"{finalPrice:f2}"); 
            }
            else
            {
                Console.WriteLine($"{price:f2}");
            }




            //стринг вид помещение 
            // а) три вида помещения 1."room for one person" – 18.00 лв за нощувка
            //      2."apartment" – 25.00 лв за нощувка
            //     	3."president apartment" – 35.00 лв за нощувка

            //оценка стринг 
            // Намаления 1. room for one person	- без намаление, за колкото и дни да е там
            // apartment под 10 дни 30% от крайната цена; между 10 и 15 дни	35% от крайната цена; над 15дни	50% от крайната цена;
            // president apartment под 10дни	10% от крайната цена; между 10 и 15-15% от крайната цена; над 15 дни 20% от крайната цена;
            // оценката negative  се приспада още 10% или positive- от крайната цена се приспада още 25% намаление
            // отпечатване на крайната цена

        }
    }
}
