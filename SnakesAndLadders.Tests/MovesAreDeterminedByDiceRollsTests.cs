using NUnit.Framework;

namespace SnakesAndLadders.Tests
{
    [TestFixture]
    public class MovesAreDeterminedByDiceRollsTests
    {
        [Test]
        public void DiceRollsAreBetweenOneAndSix()
        {
            Assert.That(new Die().Roll(), Is.InRange(1, 6));
        }
    }
}