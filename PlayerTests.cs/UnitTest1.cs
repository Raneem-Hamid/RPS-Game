using RPS_Game;
using Xunit;

namespace RPS_Game.Tests
{
    public class PlayerTests
    {
        [Fact]
        public void PlayerChoice_RockInput_ReturnsRock()
        {
            // Arrange & Act
            string result = Player.PlayerChoice("1");

            // Assert
            Assert.Equal("rock", result);
        }

        [Fact]
        public void PlayerChoice_PaperInput_ReturnsPaper()
        {
            // Arrange & Act
            string result = Player.PlayerChoice("2");

            // Assert
            Assert.Equal("paper", result);
        }

        [Fact]
        public void PlayerChoice_ScissorsInput_ReturnsScissors()
        {
            // Arrange & Act
            string result = Player.PlayerChoice("3");

            // Assert
            Assert.Equal("scissors", result);
        }

        [Fact]
        public void AiChoice_ReturnsValidMove()
        {
            // Act
            string result = Player.AiChoice();

            // Assert
            Assert.Contains(result, new[] { "rock", "paper", "scissors" });
        }
    }
}
