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
                if (Strike(roll))
                {
                    score += StrikeBonus(roll);
                    roll++;
                }
                else if (Spare(roll))
                {
                    score += SpareBonus(roll);
                    roll += 2;
                }
                else
                {
                    score += NormalScore(roll);
                    roll += 2;
                }
            }
            return score;
        }

        private bool Spare (int roll)
        {
            return rolls[roll] + rolls[roll + 1] == 10;
        }

        private int NormalScore(int roll)
        {
            return rolls[roll] + rolls[roll + 1];
        }

        private int SpareBonus(int roll)
        {
            return 10 + rolls[roll + 2];
        }

        private int StrikeBonus(int roll)
        {
            return 10 + rolls[roll + 1] + rolls[roll + 2];
        }

        private bool Strike(int roll)
        {
            return rolls[roll] == 10;
        }
    }
}
