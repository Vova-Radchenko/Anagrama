using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrama.RewersWords;
using System;

namespace AnagramaTest
{
    [TestClass]
    public class AnagramaTest
    {
        [TestMethod]
        public void TestMethodShortString()
        {
            string input = "q1w";
            string expected = "w1q";

            var anagram = new Anagram();

            Assert.AreEqual(expected, anagram.rewSentence(input));
        }

        [TestMethod]
        public void TestMethodShortString1()
        {
            string input = "q1w as3d";
            string expected = "w1q ds3a";

            var anagram = new Anagram();

            Assert.AreEqual(expected, anagram.rewSentence(input));
        }

        [TestMethod]
        public void CheckEmptyStringTest()
        {
            var input = string.Empty;
            var anagram = new Anagram();
            Assert.ThrowsException<Exception>(() => anagram.rewSentence(input));
        }

        [TestMethod]
        public void CheckNullStringTest()
        {
            string input = null;
            var anagram = new Anagram();
            Assert.ThrowsException<NullReferenceException>(() => anagram.rewSentence(input));
        }
    }
}
