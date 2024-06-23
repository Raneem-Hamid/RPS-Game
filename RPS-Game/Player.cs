namespace RPS_Game
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player()
        {
            Score = 0;
        }

        // This method is used for normal gameplay
        public static string PlayerChoice()
        {
            string input;
            do
            {
                Console.WriteLine("Enter your move: (1) Rock, (2) Paper, (3) Scissors");
                input = Console.ReadLine().Trim();
                if (input != "1" && input != "2" && input != "3")
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            } while (input != "1" && input != "2" && input != "3");

            return input switch
            {
                "1" => "rock",
                "2" => "paper",
                "3" => "scissors",
                _ => "invalid",
            };
        }

        // This method is used for testing purposes
        public static string PlayerChoice(string input)
        {
            return input switch
            {
                "1" => "rock",
                "2" => "paper",
                "3" => "scissors",
                _ => "invalid",
            };
        }

        public static string AiChoice()
        {
            Random rand = new Random();
            int aiChoice = rand.Next(1, 4);
            return aiChoice switch
            {
                1 => "rock",
                2 => "paper",
                3 => "scissors",
                _ => "rock",
            };
        }
    }
}
