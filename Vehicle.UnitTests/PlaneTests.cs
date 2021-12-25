using NUnit.Framework;
using System;
using Vehicle;

namespace Vehicle.UnitTests
{
    [TestFixture]
    public class PlaneTests
    {
        [Test]
        [TestCase(2, 3, 5)]
        public void Speed_WhenCalled_RelativeSpeed(int startS, int stopS, int relativeSpeed)
        {
            var plane = new Plane();

            var result = plane.Speed(startS, stopS);

            Assert.That(result, Is.EqualTo(relativeSpeed));
        }
    }
}
