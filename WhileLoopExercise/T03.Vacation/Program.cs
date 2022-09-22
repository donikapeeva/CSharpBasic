using System;

namespace T03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
              double neededMoney = double.Parse(Console.ReadLine());  //	Пари нужни за екскурзията - реално число в интервала [1.00...25000.00]
            double availableMoney = double.Parse(Console.ReadLine()); //	Налични пари -реално число в интервала[0.00...25000.00] 
            string input="";  //Вид действие – текст с възможности "spend" и "save" 
            double money=0; //	Сумата, която ще спести / похарчи 
            //помощни променливи- поредни дни брояч; брояч за общ брой дни
            int daysCount = 0; //общо дни
            int spendCount = 0; //дни с харчене 


            while (availableMoney < neededMoney)
            {
                input = Console.ReadLine();//вид действие - spend/save; 
                money = double.Parse(Console.ReadLine()); //пари изхарчени или спестени
                daysCount++; //брояч за дните

                if (input == "save") //ако инпут е save
                {
                    //availableMoney = availableMoney +money;
                    availableMoney += money;//наличните пари се увеличават
                    spendCount = 0; //броячът на изхарчените пари се нулира
                }
                else //ако се харчи
                {
                    //availableMoney = availableMoney - money;
                    availableMoney -= money;//наличните пари се изваждат
                    if (availableMoney < 0) //ако се изхарчат повече пари от наличните
                    {
                        availableMoney = 0;//наличните стават нула
                    }

                    spendCount++;//увеличава се броячът на дните с харчене
                    if (spendCount == 5) //ако дните с харчене станат 5 поредни се принтира следното и се спира цикъла
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine($"{daysCount}");
                        break;
                    }
                }
            }

            if (availableMoney >= neededMoney)//ако наличните пари станат равни или повече от цената на екскурзията се принтира
            {
                Console.WriteLine($"You saved the money for {daysCount} days."); 
            }

        }
    }
}
