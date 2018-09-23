using NUnit.Framework;
using System;
using WordServices.Utils;

namespace WordServices.Tests
{
    [TestFixture]
    public class WordUtilsTests
    {
        [Test]
        [TestCase("a","a")]
        [TestCase("test", "tset")]
        public void Get_ReverseWord_SouldReverseWord(string initial, string reversed){           
            Assert.That(WordUtils.Reverser(initial), Is.EqualTo(reversed));
        }
    }
}
