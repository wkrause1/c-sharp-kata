using System;
using System.Collections.Generic;
namespace Test
{
    public class Game
    {
        private int score;
       
        public void Roll(int pins)
        {
            score += pins;
        }

        public int Score()
        {
            return score;
        }
    }
}
