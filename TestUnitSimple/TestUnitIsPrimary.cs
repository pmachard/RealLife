using NUnit.Framework;
using System.Collections.Generic;
using Utopia.Algo.Simple;

namespace Utopia.Algo.Simple.TestUnit
{
    public class TestUnitIsPrimary
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSimple()
        {
            Assert.AreEqual(false, IsPrimary.RunIteratif(0));
            Assert.AreEqual(false, IsPrimary.RunIteratif(1));
            Assert.AreEqual(true, IsPrimary.RunIteratif(2));
            Assert.AreEqual(true, IsPrimary.RunIteratif(3));
            Assert.AreEqual(false, IsPrimary.RunIteratif(4));
            Assert.AreEqual(true, IsPrimary.RunIteratif(5));
            Assert.AreEqual(false, IsPrimary.RunIteratif(6));
            Assert.AreEqual(true, IsPrimary.RunIteratif(7));
            Assert.AreEqual(false, IsPrimary.RunIteratif(8));
            Assert.AreEqual(false, IsPrimary.RunIteratif(9));
            Assert.AreEqual(false, IsPrimary.RunIteratif(10));
            Assert.AreEqual(true, IsPrimary.RunIteratif(11));
            Assert.AreEqual(false, IsPrimary.RunIteratif(12));
            Assert.AreEqual(true, IsPrimary.RunIteratif(13));
        }
    }
}