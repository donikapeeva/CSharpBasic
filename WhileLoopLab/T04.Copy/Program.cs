﻿using System;

namespace T04.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//въведено макс число
            int kNumber = 0;//променлива за сбора на числата до първото число
            //следващо число се изчислява като умножим предишното с 2 и добавим 1.
            //цикъл, който върви докато Кнумбер е по-малък или равен н
            while (kNumber<=n)//цикъл, който се върти, докато сбора е по-малък или равен на първото число
            {
                kNumber = kNumber * 2 + 1;//пресмятане и презаписване на променливата за сбора
                if (kNumber > n)//проверка дали сборът не е станал повече от първото число
                {
                    break;//ако е, цикълът спира
                }
                Console.WriteLine(kNumber);//принтиране на моментния сбор
                continue;//команда цикълът да продължи
            }
            
        } 
    }
}