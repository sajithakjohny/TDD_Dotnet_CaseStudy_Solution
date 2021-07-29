using NUnit.Framework;
using FizzBuzz;
using System.Collections.Generic;

namespace FizzBuzzNunitTestProject
{
    public class Tests
    {
        [TestFixture]
        public class FizzBuzzTest
        {
            public FizzBuzzGame fizzBuzzGame;
            [SetUp]
            public void Setup()
            {
                fizzBuzzGame = new FizzBuzzGame();
            }
            [Test]
            public void GivenMemberOfListDivisibleBy3FizzBy5BuzzByBothThenFizzBuzz()
            {

                List<string> result = fizzBuzzGame.GetFizzBuzzResult(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8,9, 10, 11, 12, 13, 14, 15, 16 });
                var expectedResult = new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "Fizz Buzz", "16" };
                Assert.AreEqual(expectedResult, result);
            }
        }
    }
}