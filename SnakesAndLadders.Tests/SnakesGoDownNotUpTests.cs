using NUnit.Framework;

namespace SnakesAndLadders.Tests
{
    [TestFixture]
    public class SnakesGoDownNotUpTests
    {
        [Test]
        public void GivenASnakeBetweenTwoAndTwelveWhenTheTokenLandsOnTwelveThenTheTokenEndsOnTwo()
        {
            var game = new Game();
            var token = new Token();
            game.Add(token);
            game.Add(new Snake(12, 2));

            game.MoveToken(6);
            game.MoveToken(5);

            Assert.That(token.Location(), Is.EqualTo(2));
        }
    }
}