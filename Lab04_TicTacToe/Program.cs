using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
        }

        static void PlayGame()
        {
            // TODO: Setup your game here. Create an introduction. 
            // Create your players, and instantiate your Game class. 
            // output to the console the winner
            Console.WriteLine("Enter player 1 name:");
            string p1 = Console.ReadLine();
            Console.WriteLine("Enter player 2 name:");
            string p2 = Console.ReadLine();
            Game game = new Game(p1, p2);

        }
    }
}
