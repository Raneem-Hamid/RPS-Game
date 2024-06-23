using Xunit;
using RPS_Game;

namespace RPSGameTests.cs
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
        public void RoundWinner_ValidMoves_CorrectResult(string humanMove, string aiMove, string expectedResult)
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
    }
}
