using NUnit.Framework;
using Utopia.Algo.Sequence.Implem;

namespace Utopia.Algo.Sequence.UnitTest
{
    public class TestUnitFibonacci
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIteratif()
        {
            Assert.AreEqual(0, Fibonacci.RunIteratif(0));
            Assert.AreEqual(1, Fibonacci.RunIteratif(1));
            Assert.AreEqual(2, Fibonacci.RunIteratif(3));
            Assert.AreEqual(3, Fibonacci.RunIteratif(4));
            Assert.AreEqual(5, Fibonacci.RunIteratif(5));
            Assert.AreEqual(8, Fibonacci.RunIteratif(6));
            Assert.AreEqual(832040, Fibonacci.RunIteratif(30));
        }

        [Test]
        public void TestRecursive()
        {
            Assert.AreEqual(0, Fibonacci.RunRecursive(0));
            Assert.AreEqual(1, Fibonacci.RunRecursive(1));
            Assert.AreEqual(2, Fibonacci.RunRecursive(3));
            Assert.AreEqual(3, Fibonacci.RunRecursive(4));
            Assert.AreEqual(5, Fibonacci.RunRecursive(5));
            Assert.AreEqual(8, Fibonacci.RunRecursive(6));
            Assert.AreEqual(832040, Fibonacci.RunRecursive(30));
        }

        [Test]
        public void TestRecursiveCache()
        {
            Assert.AreEqual(0, Fibonacci.RunRecursiveCache(0));
            Assert.AreEqual(1, Fibonacci.RunRecursiveCache(1));
            Assert.AreEqual(2, Fibonacci.RunRecursiveCache(3));
            Assert.AreEqual(3, Fibonacci.RunRecursiveCache(4));
            Assert.AreEqual(5, Fibonacci.RunRecursiveCache(5));
            Assert.AreEqual(8, Fibonacci.RunRecursiveCache(6));
            Assert.AreEqual(832040, Fibonacci.RunRecursiveCache(30));
        }
    }
}