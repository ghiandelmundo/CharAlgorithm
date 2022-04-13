using CharAlgorithm;
using NUnit.Framework;

namespace CharAlgorithmNUnitTests
{
    public class CharCounterTests
    {
        private CharCounter charCounter;

        [SetUp]
        public void Setup()
        {
            charCounter = new CharCounter();
        }

        [Test]
        public void Test1()
        {
            string result = charCounter.SplitAndCount("aaabccccdd");
            Assert.AreEqual("a3bc4d2", result);
        }

        [Test]
        public void Test2()
        {
            string result = charCounter.SplitAndCount("yyyyyzzzzzzzzzz");
            Assert.AreEqual("y5z10", result);
        }

        [Test]
        public void Test3()
        {
            string result = charCounter.SplitAndCount("abcd");
            Assert.AreEqual("abcd", result);
        }

        [Test]
        public void Test4()
        {
            string result = charCounter.SplitAndCount("hhhccchhhccc");
            Assert.AreEqual("h3c3h3c3", result);
        }
    }
}