using System;

namespace Т01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //променлива за броя редове и число, на което да спре
            int currentNum = 1;//променлива  за последното число

            for(int i=1; i<=n; i++) //цикъл при който се от
            {
                for(int j=1; j<=i; j++) //цикъл, който брои числата и определя колко редове и по колко числа на ред ще има
                {
                    Console.Write(currentNum+" ");//отпечатване на число
                    currentNum++;//увеличаване на числото

                    if (currentNum > n)//prowerka дали последното число е по-голямо от първоначално въведеното число
                    {
                        break;
                    }
                }
                Console.WriteLine();//минаване на следващ ред. 
                if (currentNum > n)//проверка дали последното число е по-голямо от първоначално въведеното число
                {
                    break;
                }
                
            }
        }
    }
}
