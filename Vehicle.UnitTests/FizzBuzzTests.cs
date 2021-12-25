using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Vehicle.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(4, "4")]
        public void GetOutput_InputIsDivisibleWithThreeAndFive_PrintFizzBuzz(int input, string expectedOutput)
        {
            var fizzbuzz = new FizzBuzz();

            var result = fizzbuzz.GetOutput(input);

            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}
