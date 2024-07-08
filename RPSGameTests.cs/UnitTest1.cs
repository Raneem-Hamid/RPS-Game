using Xunit;
using RPS_Game;

namespace RPS_Game.Tests
{
    public class RPSGameTests
    {
        [Theory]
        [InlineData("rock", "scissors", "Player wins this round!")]
        [InlineData("paper", "rock", "Player wins this round!")]
        [InlineData("scissors", "paper", "Player wins this round!")]
        [InlineData("rock", "paper", "AI wins this round!")]
        [InlineData("paper", "scissors", "AI wins this round!")]
        [InlineData("scissors", "rock", "AI wins this round!")]
        [InlineData("rock", "rock", "It's a tie!")]
        [InlineData("paper", "paper", "It's a tie!")]
        [InlineData("scissors", "scissors", "It's a tie!")]
        public void DetermineWinner_ValidMoves_CorrectResult(string humanMove, string aiMove, string expectedResult)
        {
            // Arrange
            Player human = new Player { Name = "Player" };
            Player ai = new Player { Name = "AI" };
            RPSGame game = new RPSGame(human, ai);

            // Act
            string result = game.DetermineWinner(humanMove, aiMove);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("rock", "scissors")]
        [InlineData("paper", "rock")]
        [InlineData("scissors", "paper")]
        public void DetermineWinner_PlayerWins_UpdatesScore(string humanMove, string aiMove)
        {
            // Arrange
            Player human = new Player { Name = "Player" };
            Player ai = new Player { Name = "AI" };
            RPSGame game = new RPSGame(human, ai);

            // Act
            game.DetermineWinner(humanMove, aiMove);

            // Assert
            Assert.Equal(1, human.Score);
            Assert.Equal(0, ai.Score);
        }

        [Theory]
        [InlineData("rock", "paper")]
        [InlineData("paper", "scissors")]
        [InlineData("scissors", "rock")]
        public void DetermineWinner_AiWins_UpdatesScore(string humanMove, string aiMove)
        {
            // Arrange
            Player human = new Player { Name = "Player" };
            Player ai = new Player { Name = "AI" };
            RPSGame game = new RPSGame(human, ai);

            // Act
            game.DetermineWinner(humanMove, aiMove);

            // Assert
            Assert.Equal(0, human.Score);
            Assert.Equal(1, ai.Score);
        }

        [Theory]
        [InlineData("rock", "rock")]
        [InlineData("paper", "paper")]
        [InlineData("scissors", "scissors")]
        public void DetermineWinner_Tie_NoScoreChange(string humanMove, string aiMove)
        {
            // Arrange
            Player human = new Player { Name = "Player" };
            Player ai = new Player { Name = "AI" };
            RPSGame game = new RPSGame(human, ai);

            // Act
            game.DetermineWinner(humanMove, aiMove);

            // Assert
            Assert.Equal(0, human.Score);
            Assert.Equal(0, ai.Score);
        }
    }
}