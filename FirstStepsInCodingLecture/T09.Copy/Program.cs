using System;

namespace T09.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Кв.метри, които ще бъдат озеленени – реално число в интервала[0.00 … 10000.00]
            double meters = double.Parse(Console.ReadLine());
            //цена на един кв. м. е 7.61 лв със ДДС. 
            double priceM = 7.61;
            double price = meters * priceM;
            //18% отстъпка от крайната цена. 
            double discount = price * 0.18;
            double finalPrice = price - discount;

            //отпечатва се "The final price is: {крайна цена на услугата} lv."
            //	"The discount is: {отстъпка} lv."
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");

        }
    }
}
