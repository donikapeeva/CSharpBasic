using System;

namespace T06.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //име на търсената книга
            string favoriteBook = Console.ReadLine();
            //променлива за брой книги
            int books = 0;
            //въвеждане на имена на книги
            string input = Console.ReadLine();
            
            //цикъл, който приключва при команда "No More Books".
            while (input != "No More Books")
            {
                
                //ако намери книгата се принтира
                //o	"You checked {брой} books and found it."
                if (input == favoriteBook)
                {
                    break;
                }
                books++;
                input = Console.ReadLine();
            }
            if (input == favoriteBook)
            {
                Console.WriteLine($"You checked {books} books and found it.");
            }
            if(input=="No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {books} books.");
            }
            
            




            //ако не намери книгата се принтира o	"The book you search is not here!"
            //   "You checked {брой} books."

        }
    }
}
