using System;
using System.Collections.Generic;
namespace Test
{
    public class Game
    {
        private int score;
        private readonly int[] rolls = new int[21];
        private int currentRoll;       
        public void Roll(int pins)
        {
            rolls[currentRoll] = pins;
            currentRoll++;
        }

        public int Score()
        {
            var roll = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                if (Spare(roll))
                {
                    score += 10 + rolls[roll + 2];
                }
                else
                {
                    score += rolls[roll] + rolls[roll + 1];
                }
                roll += 2;
            }
            return score;
        }

        private bool Spare (int roll)
        {
            return rolls[roll] + rolls[roll + 1] == 10;
        }
    }
}
