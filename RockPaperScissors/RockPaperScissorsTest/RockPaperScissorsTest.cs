using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors;
using NUnit.Framework;

namespace RockPaperScissorsTest
{
    public class RockPaperScissorsTest
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void rockShouldCrushScissors()
        {
            RockPaperScissorsDev rockPaperScissorsDev = new RockPaperScissorsDev();
            string result = rockPaperScissorsDev.DetermineWinner("rock", "scissors");
            string expectedResult = "rock beats scissors"; 
            Assert.AreEqual(expectedResult, result);
        }
     }
}
