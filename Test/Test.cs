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

        private void RollSpare()
        {
            game.Roll(5);
            game.Roll(5);
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
            RollMany(20, 0);

            Assert.That(game.Score(), Is.EqualTo(0));
        }

        [Test()]
        public void Game_AllOnes_ReturnsScore()
        {
            RollMany(20, 1);

            Assert.That(game.Score(), Is.EqualTo(20));
        }

        [Test()]
        public void Game_Spare_ReturnsScorePlusBonus()
        {
            RollSpare();
            game.Roll(3);
            RollMany(17, 0);

            Assert.That(game.Score(), Is.EqualTo(16));
        }

    }
}
