 using System;

namespace T04.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се число/степен и програмата трябва да отпечата само резултатите на четните степени до това число
            int number = int.Parse(Console.ReadLine());//границата на степените
            //променлива за степенуването, числото, което ще се степенува
            int num = 1;
            //цикъл при който брояча започва от 0 и спира, която стане равен на Number.Брояча се увеличава с две стъпки*2, за да 
            for(int count=0; count<=number; count += 2)
            { //
                //печата се числото num От 1 нагоре
                Console.WriteLine(num);
                //след това при всяко завъртане Num се умножава по 4, за да се получи степенуването. 
                num *= 4;//num=num*2*2
            }
        }
    }
}
