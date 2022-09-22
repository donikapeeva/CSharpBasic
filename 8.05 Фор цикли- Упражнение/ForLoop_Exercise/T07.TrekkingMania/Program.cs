using System;

namespace T07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //чете се На първия ред – броя на групите от катерачи – цяло число в интервала [1...1000]
            int n = int.Parse(Console.ReadLine());
            //За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала[1...1000]  
            
            int musala = 0;
            int montblanc = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;
            for(int i=1; i<=n; i++)    //проверка на дестинацията според броя на хората в група се избира дестинация
            //	Група до 5 човека – изкачват Мусала
            //	Група от 6 до 12 човека – изкачват Монблан
            //	Група от 13 до 25 човека – изкачват Килиманджаро
            //	Група от 26 до 40 човека –  изкачват К2
            //	Група от 41 или повече човека – изкачват Еверест
            
            {
                int people = int.Parse(Console.ReadLine());
                if (people <= 5)
                {
                    musala += people;
                }
                else if (people <= 12)
                {
                    montblanc += people;
                }
                else if (people <= 25)
                {
                    kilimanjaro += people;
                } 
                else if(people <= 40)
                {
                    k2 += people;
                }
                else if (people >= 41)
                {
                    everest += people;
                }
            }
            //изчисляване на общ брой хора(събиране на броя във всяка група)
            //изчисляване на проценти по върхнове от общия брой - брой изкачващи връх/общ брой*100 
            double all = musala + montblanc + kilimanjaro + k2 + everest;
            double percentMusala = musala / all * 100;
            double percentMontblanc = montblanc / all * 100;
            double percentKilimanjaro = kilimanjaro/ all * 100;
            double percentK2 = k2 / all * 100;
            double percentEverest = everest / all * 100;
            //отпечатване на проценти за всеки връх, до втория знак след запетая
            //	Първи ред - процентът изкачващи Мусала
            //	Втори ред – процентът изкачващи Монблан
            //	Трети ред – процентът изкачващи Килиманджаро
            //	Четвърти ред – процентът изкачващи К2
            //	Пети ред – процентът изкачващи Еверест
            Console.WriteLine($"{percentMusala:f2}%");
            Console.WriteLine($"{percentMontblanc:f2}%");
            Console.WriteLine($"{percentKilimanjaro:f2}%");
            Console.WriteLine($"{percentK2:f2}%");
            Console.WriteLine($"{percentEverest:f2}%");



        }
    }
}
