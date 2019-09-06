using NUnit.Framework;
using System;
using System.Collections.Generic;
namespace Test
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void When_MatrixIsLessThanThreeByThree_Then_IsMagicSquare_False() 
        {
            var matrix = new List<List<decimal>>
            {
                new List<decimal> {1.0m, 2.0m},
                new List<decimal> {3.0m, 4.0m }
            };
            Assert.IsFalse(Game.isMagicSquare(matrix));
        }


    }
}
