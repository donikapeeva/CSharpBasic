using System;

namespace T10.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //число за броя инпути
            int numCount = int.Parse(Console.ReadLine());
            //променливи за четна сума и нечетна сума
            int evenSum = 0;
            int oddSum = 0;
            for(int i=1; i <= numCount; i++)//брояч който започва от 1 и спира, когато стигне въведения брой з аинпути
            {
                int input= int.Parse(Console.ReadLine());//четене на число
                if(i%2 == 0)//ако броячът е на четна стъпка
                {
                    evenSum += input;//към четната сума се прибавя инпут
                }
                if(i%2 != 0)//когато броячът е на нечетна стъпка
                {
                    oddSum += input;//инпута се прибавя към нечетната сума
                }
            }
            int diff = evenSum - oddSum;//изчисляване на разлика между двете суми
            if (evenSum == oddSum)//ако четна и нечетна са равни
            {
                Console.WriteLine("Yes");//принтира се сумата
                Console.WriteLine($"Sum = {evenSum}");
            }
            if (evenSum != oddSum)//ако четна и нечетна са различни
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");//принтира се разликата
            }
        }
    }
}
