using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosition = 0;
            Console.WriteLine("Player is at position : " + playerPosition);
            Random ran = new Random();
            int die = ran.Next(1, 7);
            Console.WriteLine("Dice roll gives : " + die);
            playerPosition += die;
            Console.WriteLine("Player is now at position : " + playerPosition);
        }
    }
}
