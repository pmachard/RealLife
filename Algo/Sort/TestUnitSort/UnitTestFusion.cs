using NUnit.Framework;
using System;
using Utopia.Algo.Sort.Implem;

namespace Utopia.Algo.Sort.TestUnit
{
    public class TestsSortFusion
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Test()
        {
            int[] TabToSort = new int[] { 20,85,23,0,85,99,3,10};
            Assert.IsTrue(TestHelp.IsSorted(BubbleSort.Run(TabToSort), TabToSort.Length));
        }
    }
}
