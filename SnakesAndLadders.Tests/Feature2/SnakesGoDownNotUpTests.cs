﻿using NUnit.Framework;

namespace SnakesAndLadders.Tests.Feature2
{
    [TestFixture]
    public class SnakesGoDownNotUpTests
    {
        private Game _game;
        private Token _token;

        [SetUp]
        public void GivenAGameWithASnakeBetweenTwelveAndTwo()
        {
            _game = new Game();
            _token = new Token();
            _game.Add(_token);
            _game.Add(new Snake(12, 2));
        }

        [Test]
        public void WhenTheTokenLandsOnSquareTwelveThenTheTokenEndsOnSquareTwo()
        {
            _game.MoveToken(6);
            _game.MoveToken(5);

            Assert.That(_token.Location(), Is.EqualTo(2));
        }

        [Test]
        public void WhenTheTokenLandsOnSquareTwoItStaysOnSquareTwo()
        {
            _game.MoveToken(1);
            Assert.That(_token.Location(), Is.EqualTo(2));
        }
    }
}