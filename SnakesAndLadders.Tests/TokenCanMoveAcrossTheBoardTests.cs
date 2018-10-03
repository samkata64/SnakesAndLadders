using NUnit.Framework;

namespace SnakesAndLadders.Tests
{
    [TestFixture]
    public class TokenCanMoveAcrossTheBoardTests
    {
        [Test]
        public void WhenTheTokenIsPlacedOnTheBoardTheTokenIsAtSquareOne()
        {
            var game = new Game();
            var token = new Token();
            game.Add(token);
            Assert.That(token.Location(), Is.EqualTo(1));
        }
    }
}
