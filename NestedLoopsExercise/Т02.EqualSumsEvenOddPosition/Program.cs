using System;

class EqualSumsEvenOddPosition
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine()); //променлива за първото шестцифрено число
        int end = int.Parse(Console.ReadLine()); //променлива за второто шестцифрено число. То винаги е > от първото
        //цикъл, който върви в диапазона от първото до второто число и се увеличава
        for (int num = start; num <= end; num++)
        {
            int currentNumber = num;//променлива за моментното число= на числото от диапазона. 
            int oddSum = 0;//променлива за  нечетната сума
            int evenSum = 0;//променлива за четната сума
            int count = 0;
            while (currentNumber != 0)//цикъл, който върви докато моментното число е по-голямо от нула
            {
                int digit = currentNumber % 10;
                if (count % 2 == 0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }
                currentNumber /= 10;
                count++;
            }
            if (evenSum == oddSum)
            {
                Console.Write($"{num} ");
            }
            
        }
    }
}