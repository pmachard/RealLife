using NUnit.Framework;
using Utopia.Algo.Sequence.Implem;

namespace Utopia.Algo.Sequence.UnitTest
{
    public class TestUnitSumCube
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestIteratif()
        {
            Assert.AreEqual(0, SumCube.RunIteratif(0));
            Assert.AreEqual(1, SumCube.RunIteratif(1));
            Assert.AreEqual(0 + 1 + (2 * 2 * 2), SumCube.RunIteratif(2));
            Assert.AreEqual(0 + 1 + (2 * 2 * 2) + (3 * 3 * 3), SumCube.RunIteratif(3));
        }
    }
}