using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Vehicle.Mocking;
using Moq;

namespace Vehicle.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var fileReader = new Mock<IFileReader>();

            // Use Moq only when dealing with external dependencies
            fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

            var service = new VideoService(fileReader.Object);

            var result = service.ReadVideoTitle();

            // IgnoreCase - ignores case sensitivity
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
