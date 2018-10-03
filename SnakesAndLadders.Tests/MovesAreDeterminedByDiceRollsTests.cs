using System;
using System.Linq.Expressions;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;

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

    public class Die
    {
        public int Roll()
        {
            return new Random().Next(1, 6);
        }
    }
}