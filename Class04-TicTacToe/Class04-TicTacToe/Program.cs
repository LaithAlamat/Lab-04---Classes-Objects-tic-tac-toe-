using System;

namespace Class04_TicTacToe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            StartGame();
            
        }
            static void StartGame()
            {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.WriteLine("Welcome to Tic-Tac-Toe");

            Player playerOne = new Player();
            Player playerTwo = new Player();

            Console.WriteLine("Player one, enter your name");
            playerOne.Name = Console.ReadLine();
            Console.WriteLine("Player two, enter your name");
            playerTwo.Name = Console.ReadLine();
            playerOne.Marker = "X";
            playerTwo.Marker = "O";

            playerOne.IsTurn = true;
            playerTwo.IsTurn = false;
            Game currentGame = new Game(playerOne, playerTwo);

            Player winner = currentGame.Play();

            //Display game results
            if (winner != null)
            {
                Console.WriteLine($"Congrats, {winner.Name}, you won the game!");
            }
            else
            {
                Console.WriteLine($"It's a draw");
            }
        }
    }
}
