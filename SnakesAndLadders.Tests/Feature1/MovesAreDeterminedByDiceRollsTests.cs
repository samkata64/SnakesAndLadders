using NUnit.Framework;

namespace SnakesAndLadders.Tests.Feature1
{
    [TestFixture]
    public class MovesAreDeterminedByDiceRollsTests
    {
        [Test]
        public void DiceRollsAreBetweenOneAndSix()
        {
            Assert.That(new Die().Roll(), Is.InRange(1, 6));
        }

        [Test]
        public void WhenAPlayerRollsAFourTheTokenMovesFourSpaces()
        {
            var game = new Game();
            var token = new Token();
            game.Add(token);

            game.MoveToken(new AlwaysFourDie().Roll());
            Assert.That(token.Location(), Is.EqualTo(5));
        }
    }

    public class AlwaysFourDie : IRollable
    {
        public int Roll()
        {
            return 4;
        }
    }
}