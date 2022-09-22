using System;

namespace T09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double squareMetersPrice = 7.61;
            double discountPercentage = 0.18;
            double totalPriceForSquareMeters = squareMeters * squareMetersPrice;
            double discount = discountPercentage * totalPriceForSquareMeters;
            double finalPrice = totalPriceForSquareMeters - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The dicount is: {discount} lv.");
        }
    }
}
