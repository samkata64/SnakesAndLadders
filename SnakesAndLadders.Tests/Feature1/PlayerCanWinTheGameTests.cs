﻿using NUnit.Framework;

namespace SnakesAndLadders.Tests.Feature1
{
    [TestFixture]
    public class PlayerCanWinTheGameTests
    {
        private Game _game;
        private Token _token;

        [SetUp]
        public void GivenAGameWithATokenOnSquareNinetySeven()
        {
            _game = new Game();
            _token = new Token();
            _game.Add(_token);
            _game.MoveToken(96);
        }

        [Test]
        public void WhenTheTokenIsMovedThreeSpacesTheLocationIsOneHundredAndTheGameIsWon()
        {
            _game.MoveToken(3);
            Assert.That(_token.Location(), Is.EqualTo(100));
            Assert.That(_game.IsWon(), Is.True);
        }

        [Test]
        public void WhenTheTokenIsMovedFourSpacesTheLocationIsUnchangedAndTheGameIsNotWon()
        {
            _game.MoveToken(4);
            Assert.That(_token.Location(), Is.EqualTo(97));
            Assert.That(_game.IsWon(), Is.False);
        }
    }
}