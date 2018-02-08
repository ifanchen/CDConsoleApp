// -----------------------------------------------------------------------
// <copyright file="StringUtilityTests.cs" company="-">
// Copyright © 2018
// </copyright>
// -----------------------------------------------------------------------
namespace CDUtilityUnitTest
{
    using CDUtility;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test StringUtility Class
    /// </summary>
    [TestClass]
    public class StringUtilityTests
    {
        /// <summary>
        /// Test RevereSentence function when input is null
        /// </summary>
        [TestMethod]
        public void RevereSentenceTest_InputNull()
        {
            Assert.IsNull(StringUtility.RevereSentence(null));
        }

        /// <summary>
        /// Test RevereSentence function when input is an empty string
        /// </summary>
        [TestMethod]
        public void RevereSentenceTest_InputEmpty()
        {
            Assert.AreEqual(string.Empty, StringUtility.RevereSentence(string.Empty));
        }

        /// <summary>
        /// Test RevereSentence function when input is a word.
        /// </summary>
        [TestMethod]
        public void RevereSentenceTest_InputOneWord()
        {
            Assert.AreEqual("Test", StringUtility.RevereSentence("Test"));
        }

        /// <summary>
        /// Test RevereSentence function when input is a sentence.
        /// </summary>
        [TestMethod]
        public void RevereSentenceTest_InputASentence()
        {
            Assert.AreEqual("day lovely a What", StringUtility.RevereSentence("What a lovely day"));
        }

        /// <summary>
        /// Test RevereSentence function when input is a sentence with extra space.
        /// </summary>
        [TestMethod]
        public void RevereSentenceTest_InputASentenceWithExtraSpace()
        {
            Assert.AreEqual("day lovely a What", StringUtility.RevereSentence(" What   a   lovely    day "));
        }

        /// <summary>
        /// Test GetMatching method when either input is null or empty.
        /// </summary>
        [TestMethod]
        public void GetMatchingTest_InputNullOrEmpty()
        {
            Assert.AreEqual(string.Empty, StringUtility.GetMatching(null, null));
            Assert.AreEqual(string.Empty, StringUtility.GetMatching(string.Empty, string.Empty));
            Assert.AreEqual(string.Empty, StringUtility.GetMatching("Matching", string.Empty));
            Assert.AreEqual(string.Empty, StringUtility.GetMatching(string.Empty, "Matching"));
        }

        /// <summary>
        /// Test GetMatching method .
        /// </summary>
        [TestMethod]
        public void GetMatchingTest()
        {
            Assert.AreEqual("lo", StringUtility.GetMatching("hello", "world"));
            Assert.AreEqual("input", StringUtility.GetMatching("This is input 1", "input"));            
        }
    }
}
