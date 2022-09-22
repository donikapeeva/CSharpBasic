using System;

namespace T07.Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред – броя на групите от катерачи – цяло число в интервала [1...1000]
            int groups = int.Parse(Console.ReadLine());
            int musala = 0;
            int monblan = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;
            //цикъл, който върви през броя групи 
            for (int i=1; i<=groups; i++)
            {
                //в него се чете брой хора за дадена група
                int people = int.Parse(Console.ReadLine());
                //според броя, всяка група изкачва разл.връх
                
                if (people <= 5)
                { //•	Група до 5 човека – изкачват Мусала
                    musala += people;
                }
                else if (people>=6 && people <= 12)
                {//	Група от 6 до 12 човека – изкачват Монблан
                    monblan += people;
                }
                else if (people >= 13 && people <= 25)
                {//	Група от 13 до 25 човека – изкачват Килиманджаро
                    kilimanjaro += people;
                }
                else if (people >= 26 && people <= 40)
                { //	Група от 26 до 40 човека –  изкачват К2
                    k2 += people;
                }
                else if (people >=41)
                { //	Група от 41 или повече човека – изкачват Еверест
                    everest += people;
                }

            }
            //пресмятане на общ брой хора
            double totalPeople = musala + monblan + kilimanjaro + k2 + everest;
            //от него се изчисляват процентите. 
            double musalaPercent = (musala / totalPeople) * 100;
            double monblanPercent = (monblan / totalPeople) * 100;
            double kilimanjaroPercent = (kilimanjaro / totalPeople) * 100;
            double k2Percent = (k2 / totalPeople) * 100;
            double everestPercent = (everest/ totalPeople) * 100;

            Console.WriteLine($"{musalaPercent:f2}%");
            Console.WriteLine($"{monblanPercent:f2}%");
            Console.WriteLine($"{kilimanjaroPercent:f2}%");
            Console.WriteLine($"{k2Percent:f2}%");
            Console.WriteLine($"{everestPercent:f2}%");


            //печатат се процентите•	
            //Първи ред - процентът изкачващи Мусала
            //Втори ред – процентът изкачващи Монблан
            //Трети ред – процентът изкачващи Килиманджаро
            //Четвърти ред – процентът изкачващи К2
            //Пети ред – процентът изкачващи Еверест


        }
    }
}
