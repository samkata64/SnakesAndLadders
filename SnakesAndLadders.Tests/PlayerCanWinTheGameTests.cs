using NUnit.Framework;

namespace SnakesAndLadders.Tests
{
    [TestFixture]
    public class PlayerCanWinTheGameTests
    {
        [Test]
        public void GivenTheTokenIsOnSquareNinetySevenWhenTheTokenIsMovedThreeSpacesThenTheTokenIsOnSquareOneHundred()
        {
            var _game = new Game();
            var _token = new Token();
            _game.Add(_token);
            _game.MoveToken(96);

            _game.MoveToken(3);
            Assert.That(_token.Location(), Is.EqualTo(100));
            Assert.That(_game.IsWon(), Is.True);
        }

        [Test]
        public void GivenTheTokenIsOnSquareNinetySevenWhenTheTokenIsMovedThreeSpacesThenTheTokenStaysStill()
        {
            var _game = new Game();
            var _token = new Token();
            _game.Add(_token);
            _game.MoveToken(96);

            _game.MoveToken(4);
            Assert.That(_token.Location(), Is.EqualTo(97));
            Assert.That(_game.IsWon(), Is.False);
        }
    }
}