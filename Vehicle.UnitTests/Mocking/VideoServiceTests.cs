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
        private Mock<IFileReader> _fileReader;
        private VideoService _videoService;

        [SetUp]
        public void SetUp()
        {
            _fileReader = new Mock<IFileReader>();
            _videoService = new VideoService(_fileReader.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            // Use Moq only when dealing with external dependencies
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");


            var result = _videoService.ReadVideoTitle();

            // IgnoreCase - ignores case sensitivity
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
