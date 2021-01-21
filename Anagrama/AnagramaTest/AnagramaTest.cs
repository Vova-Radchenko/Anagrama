using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrama.RewersWords;
using System;
using System.Text;

namespace AnagramaTest
{
    [TestClass]
    public class AnagramaTest
    {
        private Anagram anagram;

        [TestInitialize]
        public void TestSetUp()
        {
            anagram = new Anagram();
        }

        [TestMethod]
        public void TestMethodShortString()
        {
            var input = "q1w";
            var expected = "w1q";

            Assert.AreEqual(expected, anagram.rewSentence(input));
        }

        [TestMethod]
        public void TestMethodShortString1()
        {
            string input = "q1w as3d333";
            string expected = "w1q ds3a333";

            Assert.AreEqual(expected, anagram.rewSentence(input));
        }

        [TestMethod]
        public void CheckEmptyStringTest()
        {
            var input = string.Empty;
            Assert.ThrowsException<Exception>(() => anagram.rewSentence(input));
        }

        [TestMethod]
        public void CheckNullStringTest()
        {
            string input = null;
            Assert.ThrowsException<Exception>(() => anagram.rewSentence(input));
        }
    }
}
