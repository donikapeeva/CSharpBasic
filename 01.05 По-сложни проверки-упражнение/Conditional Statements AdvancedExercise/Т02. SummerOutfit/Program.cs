using System;

namespace Т02._SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int gradusi 10-42 
            int degrees = int.Parse(Console.ReadLine());
            //string day time Morning Afternoon Evening 
            string timeOfDay = Console.ReadLine();
            // promenlivi outfit shoes
            string outfit = "Shirt"; // == evening
            string shoes = "Moccasins"; // == evening
            //1. Morning if gradusi<= 18      Outfit = Sweatshirt  Shoes = Sneakers
            //          else if gradusi<= 24   Outfit = Shirt  Shoes = Moccasins
            //         else  gradusi >= 25      Outfit = T-Shirt   Shoes = Sandals 
            if (timeOfDay == "Morning")
            {
                if (degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            } 
            else if (timeOfDay == "Afternoon")// 2. Afternoon gradusi<= 18 Outfit = Shirt   Shoes = Moccasins
            //           gradusi<= 24   Outfit = T-Shirt   Shoes = Sandals
            //           gradusi >= 25      Outfit = Swim Suit Shoes = Barefoot
            {
                if (degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            } 
            else
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
            
            //3. Evening gradusi<= 18      Outfit = Shirt  Shoes = Moccasins
            //           gradusi<= 24   Outfit = Shirt  Shoes = Moccasins
            //           gradusi >= 25      Outfit = Shirt  Shoes = Moccasins 
            // отпечатване "It's {градуси} degrees, get your {облекло} and {обувки}."




        }
    }
}
