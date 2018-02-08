namespace CDUtilityUnitTest
{
    using System;
    using CDUtility;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test StackContainer Class
    /// </summary>
    [TestClass]
    public class StackContainerTests
    {
        /// <summary>
        /// Test IsEmpty method.
        /// </summary>
        [TestMethod]
        public void IsEmptyTest_EmptyStack()
        {
            // Arrange
            var s = new StackContainer<int>();

            // Assert
            Assert.IsTrue(s.IsEmpty());
            Assert.AreEqual(0, s.Size());
        }

        /// <summary>
        /// Test IsEmpty method.
        /// </summary>
        [TestMethod]
        public void IsEmptyTest_WithOneItem()
        {
            // Arrange
            var s = new StackContainer<int>();
            s.Push(10);

            // Assert
            Assert.IsFalse(s.IsEmpty());
            Assert.AreEqual(1, s.Size());
        }

        /// <summary>
        /// Test Push method.
        /// </summary>
        [TestMethod]
        public void PushTest_OneItem()
        {
            // Arrange
            var s = new StackContainer<int>();

            // Action
            s.Push(10);

            // Assert
            Assert.AreEqual(1, s.Size());
        }

        /// <summary>
        /// Test Push method.
        /// </summary>
        [TestMethod]
        public void PushTest_TwoStringItems()
        {
            // Arrange
            var s = new StackContainer<string>();

            // Action
            s.Push("item1");
            s.Push("item2");

            // Assert
            Assert.AreEqual(2, s.Size());
        }

        /// <summary>
        /// Test Pop method.
        /// </summary>
        [TestMethod]
        public void PopTest_OneItem()
        {
            // Arrange
            var s = new StackContainer<string>();

            // Action
            s.Push("item1");
            s.Push("item2");
            var item = s.Pop();

            // Assert            
            Assert.AreEqual(1, s.Size());
            Assert.AreEqual("item2", item);
        }

        /// <summary>
        /// Test Pop method when stack is empty
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(StackOverflowException), "Stack is empty")]
        public void PopTest_NoItem()
        {
            // Arrange
            var s = new StackContainer<string>();

            // Action
            var item = s.Pop();            
        }

        /// <summary>
        /// Test all methods combined
        /// </summary>
        [TestMethod]
        public void StackContainerTest()
        {
            // Arrange
            var s = new StackContainer<int>();

            // Action
            s.Push(1);
            s.Push(2);
            var popItem1 = s.Pop();
            s.Push(3);
            var popItem2 = s.Pop();
            var popItem3 = s.Pop();
            
            // Assert
            Assert.IsTrue(s.IsEmpty());
            Assert.AreEqual(0, s.Size());
            Assert.AreEqual(2, popItem1);
            Assert.AreEqual(3, popItem2);
            Assert.AreEqual(1, popItem3);
        }
    }
}
