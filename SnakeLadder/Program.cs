using System;
using System.Threading;

namespace SnakeLadder
{
    class Program
    {
        const int SNAKE = 1;
        const int LADDER = 2;
        public static int TwoPlayers(int playerPosition)
        {

            Random ran = new Random();
     
            while (playerPosition != 100)
            {
                int ifSnake = 0;
                int die = ran.Next(1, 7);
             
                int option = ran.Next(0, 3);
                
                    switch (option)
                    {
                        case SNAKE:
                            //Console.WriteLine("Player bitten by snake");
                            playerPosition -= die;
                            if (playerPosition < 0)
                                playerPosition = 0;
                            return playerPosition;
                            break;
                        case LADDER:
                            //Console.WriteLine("Player climbs the ladder");
                            playerPosition += die;
                            if (playerPosition > 100)
                                playerPosition = playerPosition - die;
                        break;
                        default:
                            //Console.WriteLine("Player choses not to play");
                            break;

                    }

                    
                    
              
            }
            return 100;
        }

        static void Main(string[] args)
        {
            int player1 = 0, player2 = 0;
            Console.WriteLine("Player 1 is at position : " + player1);
            Console.WriteLine("Player 2 is at position : " + player2);
            while (player1<100 && player2<100)
            {
                player1= TwoPlayers(player1);
                Console.WriteLine("Player 1 is at position : " + player1);
                player2= TwoPlayers(player2);
                Console.WriteLine("Player 2 is at position : " + player2);
            }
            if (player1 == 100)
                Console.WriteLine("Player 1 is the winner.");
            else
                Console.WriteLine("Player 2 is the winner.");
        }
    }
}
