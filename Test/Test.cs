using NUnit.Framework;
using System;
using System.Collections.Generic;
namespace Test
{
    [TestFixture()]
    public class Test
    {
        private Game game;

        [SetUp]
        public void TestSetup()
        {
            game = new Game();
        }

        private void RollMany(int rolls, int pins)
        {
            for (var i = 0; i < rolls; i++)
            {
                game.Roll(pins);
            }
        }

        [Test()]
        public void Game_AllZeros_ReturnsSCore()
        {
            var game = new Game();

            for (var i = 0; i < 20; i++)
            {
                game.Roll(0);
            }

            Assert.That(game.Score(), Is.EqualTo(0));
        }

        [Test()]
        public void Game_AllOnes_ReturnsScore()
        {
            var game = new Game();

            for (var i = 0; i < 20; i++)
            {
                game.Roll(1);
            }

            Assert.That(game.Score(), Is.EqualTo(20));
        }

    }
}
