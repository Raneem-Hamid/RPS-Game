using System.Numerics;

namespace RPS_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("*          ROCK, PAPER, SCISSORS       *");
            Console.WriteLine("****************************************");
            Console.WriteLine("Welcome to the classic game of Rock, Paper, Scissors!");
            Console.WriteLine("You will be playing against a cunning AI opponent.");
            Console.WriteLine("Let's see if you can outsmart the machine!");
            Console.WriteLine("The first to reach 3 points wins the game.");
            Console.WriteLine("Good luck!");
            Console.WriteLine("****************************************");
            Console.Write("Please enter your name: ");

            string playerName = Console.ReadLine();
            Player humanPlayer = new Player
            {
                Name = playerName
            };
            Console.WriteLine($"Hi {humanPlayer.Name}");

            Player aiPlayer = new Player
            {
                Name = "AI"
            };

            RPSGame game = new RPSGame(humanPlayer, aiPlayer);
            game.PlayGame();
        }
    }
}
