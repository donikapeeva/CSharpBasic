using System;

namespace T04.EasterEggsBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Брой яйца, които има първият играч - цяло число в интервала [1 … 99]
            int playerOneEggs = int.Parse(Console.ReadLine());
            // 2.Брой яйца, които има вторият играч -цяло число в интервала[1 … 99]
            int playerTwoEggs = int.Parse(Console.ReadLine());
            //3.Победител - текст - "one" или "two"
            string command = Console.ReadLine();
            //След това до получаване на команда "End" се четe многократно един ред:
            while (command!= "End")
            {
                if (command == "one")
                {
                    playerTwoEggs--;
                }
                else if (command == "two")
                {
                    playerOneEggs--;
                }

                if (playerOneEggs == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {playerTwoEggs} eggs left.");
                    break;
                }
                else if (playerTwoEggs == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {playerOneEggs} eggs left.");
                    break;
                }
                
                command = Console.ReadLine();
            }
            if (command == "End")
            {
                Console.WriteLine($"Player one has {playerOneEggs} eggs left.");
                Console.WriteLine($"Player two has {playerTwoEggs} eggs left.");
            }
            

        }
    }
}
