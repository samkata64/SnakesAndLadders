using NUnit.Framework;

namespace SnakesAndLadders.Tests.Feature2
{
    [TestFixture]
    public class LaddersGoUpNotDownTests
    {
        private Game _game;
        private Token _token;

        [SetUp]
        public void GivenAGameWithASnakeBetweenTwelveAndTwo()
        {
            _game = new Game();
            _token = new Token();
            _game.Add(_token);
            _game.Add(new Ladder(2, 12));
        }

        [Test]
        public void WhenTheTokenLandsOnSquareTwoThenTheTokenEndsOnSquareTwelve()
        {
            _game.MoveToken(1);
            Assert.That(_token.Location(), Is.EqualTo(12));
        }
    }
}