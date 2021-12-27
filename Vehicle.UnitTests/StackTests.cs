using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Vehicle.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        [TestCase(null)]
        public void Push_ObjectIsNull_ArgumentNullException(string obj)
        {
            var stackObject = new Stack<string>();

            Assert.That(() => stackObject.Push(obj), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidArgument_AddObjectToStack()
        {
            var stackObject = new Stack<string>();

            stackObject.Push("a");

            Assert.That(stackObject.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            var stackObject = new Stack<string>();

            Assert.That(stackObject.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            var stackObject = new Stack<string>();

            Assert.That(() => stackObject.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithAFewObjects_ReturnObjectOnTheTop()
        {
            // Arrange
            var stackObject = new Stack<string>();
            stackObject.Push("a");
            stackObject.Push("b");
            stackObject.Push("c");

            // Act
            var result = stackObject.Pop();

            // Assert
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        [TestCase()]
        public void Pop_StackWithAFewObjects_RemoveObjectOnTheTop()
        {
            // Arrange
            var stackObject = new Stack<string>();
            stackObject.Push("a");
            stackObject.Push("b");
            stackObject.Push("c");

            // Act
            stackObject.Pop();

            // Assert
            Assert.That(stackObject.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peak_EmptyStack_ThrowsInvalidOperationException()
        {
            var stackObject = new Stack<string>();

            Assert.That(() => stackObject.Peak(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peak_StackWithObjects_ReturnObjectOnTopOfTheStack()
        {
            // Arrange
            var stackObject = new Stack<string>();
            stackObject.Push("a");
            stackObject.Push("b");
            stackObject.Push("c");

            // Act
            var result = stackObject.Peak();

            // Assert
            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Peak_StackWithObjects_DoesNotRemoveTheObjectOnTopOfTheStack()
        {
            // Arrange
            var stackObject = new Stack<string>();
            stackObject.Push("a");
            stackObject.Push("b");
            stackObject.Push("c");

            // Act
            stackObject.Peak();

            // Assert
            Assert.That(stackObject.Count, Is.EqualTo(3));
        }
    }
}
