using NUnit.Framework;
using System;
using Utopia.Algo.Sort.Implem;

namespace Utopia.Algo.Sort.TestUnit
{
    public class UnitTestInsertion
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Test()
        {
            int[] TabToSort = new int[] { 20,85,23,0,85,99,3,10};
            Assert.IsTrue(
                TestHelp.IsSorted(
                    ShortInsertion.Run(TabToSort),
                    TabToSort.Length
                    )
                );
        }
    }
}
