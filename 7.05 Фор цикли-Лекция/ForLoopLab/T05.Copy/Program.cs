using System;

namespace T05.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//приемане на дума стринг
            for (int i = 0; i < input.Length; i++)//цикъл, чийто брояч започва от нулевия индекс и спира с крайния знак на думата, броячът е стъпката върху буква от думата
            {
                Console.WriteLine(input[i]);//отпечатва всеки знак на инпута/ i е сстъпката, буквата на която е броячът
            }

        }
    }
}
