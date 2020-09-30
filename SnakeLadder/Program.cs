using System;

namespace SnakeLadder
{
    class Program
    {
        const int SNAKE = 1;
        const int LADDER = 2;
        static void Main(string[] args)
        {

            int playerPosition = 0;
            Console.WriteLine("Player is at position : " + playerPosition);
            Random ran = new Random();
            
            while (playerPosition != 100)
            {
                int die = ran.Next(1, 7);
                int option = ran.Next(0, 3);
                Console.WriteLine("Dice roll gives : " + die);
                switch (option)
                {
                    case SNAKE:
                        Console.WriteLine("Player bitten by snake");
                        playerPosition -= die;
                        break;
                    case LADDER:
                        Console.WriteLine("Player climbs the ladder");
                        playerPosition += die;
                        break;
                    default:
                        Console.WriteLine("Player choses not to play");
                        break;
                        
                }
                if (playerPosition < 0)
                    playerPosition = 0;
                Console.WriteLine("Player is now at position : " + playerPosition);
            }
        }
    }
}
