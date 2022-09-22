using System;

namespace T06.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //име на търсената книга
            string favoriteBook = Console.ReadLine();
            //въвеждане на имена на книги
            string input= Console.ReadLine();
            //променлива за брой книги
            int books = 0;
            //цикъл, който приключва при команда "No More Books".
            while(input!= "No More Books")
            {
                books++;
                //ако намери книгата се принтира
                //o	"You checked {брой} books and found it."
                if (input == favoriteBook)
                {
                    Console.WriteLine($"You checked {books-1} books and found it.");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {books} books.");




            //ако не намери книгата се принтира o	"The book you search is not here!"
            //   "You checked {брой} books."

        }
    }
}
