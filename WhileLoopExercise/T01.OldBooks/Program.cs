using System;

namespace T01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // прочитане на любимата книга на Ани
            string favoriteBook = Console.ReadLine();
            //прочитаме заглавия на книги  
            string input = Console.ReadLine();
            //създаване на броя за брой въведени книги =0;
            int count = 0;
            

            // правим го, докато не прегледаме всички книги , докато не получим вход "No More Books".
            while(input!= "No More Books")
            { 
                if (input== favoriteBook)//ako инпута е любимата книга, цикъла спира
                {
                    break;
                }
                count++; //броят въведени книги се увеличава с 1
                input = Console.ReadLine(); //чете се инпут книга
            }
            //проверка защо спира цикъла-дали сме открили книги
            if (input == favoriteBook) //ако сме я открили се отпечатва "You checked {брой} books and found it."
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else //ако не сме я открили 	"The book you search is not here!"
            //  "You checked {брой} books."
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
            

            
               
            

        }
    }
}
