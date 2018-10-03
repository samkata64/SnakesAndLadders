﻿using NUnit.Framework;

namespace SnakesAndLadders.Tests
{
    [TestFixture]
    public class TokenCanMoveAcrossTheBoardTests
    {
        private Game _game;
        private Token _token;

        [SetUp]
        public void GivenAGameWithATokenAdded()
        {
            _game = new Game();
            _token = new Token();
            _game.Add(_token);
        }

        [Test]
        public void ThenTheTokenStartsAtSquareOne()
        {
            Assert.That(_token.Location(), Is.EqualTo(1));
        }

        [Test]
        public void WhenTheTokenIsMoved3Spaces()
        {
            _game.MoveToken(3);
            Assert.That(_token.Location(), Is.EqualTo(4));
        }

        [Test]
        public void WhenTheTokenIsMoved3SpacesThenFourSpaces()
        {
            _game.MoveToken(3);
            _game.MoveToken(4);
            Assert.That(_token.Location(), Is.EqualTo(8));
        }
    }
}
