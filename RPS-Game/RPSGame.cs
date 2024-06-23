namespace RPS_Game
{
    public class RPSGame
    {
        private Player human;
        private Player ai;

        public RPSGame(Player humanPlayer, Player aiPlayer)
        {
            human = humanPlayer;
            ai = aiPlayer;
        }

        public void PlayGame()
        {
            int round = 0;
            int humanScore = human.Score;
            int aiScore = ai.Score;

            Console.WriteLine($"Initial Scores: {human.Name}: {humanScore}, {ai.Name}: {aiScore}");

            while (humanScore < 3 && aiScore < 3)
            {
                round++;
                string humanChoice = Player.PlayerChoice();
                string aiChoice = Player.AiChoice();
                string result = DetermineWinner(humanChoice, aiChoice);
                Console.WriteLine(result);
                Console.WriteLine($"Round {round} - {human.Name}: {humanScore}, {ai.Name}: {aiScore}");
            }

            if (humanScore >= 3)
            {
                Console.WriteLine($"{human.Name} wins the game!");
            }
            else
            {
                Console.WriteLine($"{ai.Name} wins the game!");
            }
        }

        public string DetermineWinner(string humanMove, string aiMove)
        {
            if (humanMove == aiMove)
            {
                return "It's a tie!";
            }
            else if ((humanMove == "rock" && aiMove == "scissors") ||
                     (humanMove == "scissors" && aiMove == "paper") ||
                     (humanMove == "paper" && aiMove == "rock"))
            {
                human.Score++;
                return $"{human.Name} wins this round!";
            }
            else
            {
                ai.Score++;
                return $"{ai.Name} wins this round!";
            }
        }
    }
}
